Imports System
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Ssh.Tools.Common
Imports UnderAutomation.UniversalRobots.Ssh.Tools.Sftp
Imports UnderAutomation.UniversalRobots.Files

Public Partial Class SftpControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Public Sub New(ur As UR)
        _ur = ur
        InitializeComponent()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "File handling (SFTP)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.Sftp.Connected
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        Enabled = FeatureEnabled
    End Sub


    Public Sub OnClose() Implements IUserControl.OnClose
        Config.Current.SftpPath = txtPath.Text
        Config.Save()

        lstFolder.Items.Clear()
        gridFile.SelectedObject = Nothing
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
        Try
            InitializeFtp()
        Catch __unusedSftpPathNotFoundException1__ As SftpPathNotFoundException
            Config.Current.SftpPath = "/"
            InitializeFtp()
        End Try
    End Sub
#End Region

    Public Sub InitializeFtp()
        FillList(If(Config.Current.SftpPath, "/"))
    End Sub

    ' Display directory content in the list view
    Private Sub FillList(path As String)
        gridFile.SelectedObject = Nothing
        lstFolder.Items.Clear()

        If Not _ur.Sftp.Connected Then Return

        path = path.Replace("\", "/")
        If Not path.EndsWith("/") Then path = path & "/"

        txtPath.Text = path

        Dim files = _ur.Sftp.ListDirectory(path)

        For Each file In files
            ' do not display special folders
            If Equals(file.Name, ".") OrElse Equals(file.Name, "..") Then Continue For

            Dim itm = lstFolder.Items.Add(file.Name)

            itm.Tag = file

            If file.IsDirectory Then
                itm.ImageKey = "folder"
            ElseIf file.IsSymbolicLink Then
                itm.ImageKey = "symbolicLink"
            Else
                itm.ImageKey = "file"
            End If
        Next
    End Sub

    ' Open directory after double click
    Private Sub lstFolder_ItemActivate(sender As Object, e As EventArgs)
        Dim file = TryCast(lstFolder.SelectedItems?.OfType(Of ListViewItem)()?.FirstOrDefault()?.Tag, SftpFile)

        If file Is Nothing OrElse Not file.IsDirectory AndAlso Not file.IsSymbolicLink Then Return

        If file.IsSymbolicLink AndAlso file.IsRegularFile Then
            Try
                Dim value = _ur.Sftp.ReadAllText(file.FullName)

                MessageBox.Show(value, file.FullName)
            Catch
                FillList(file.FullName)
            End Try
        Else
            FillList(file.FullName)
        End If
    End Sub

    ' Show select item data inside right grid
    Private Sub lstFolder_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        gridFile.SelectedObject = e.Item?.Tag
    End Sub
    Private Sub lstFolder_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lstFolder.SelectedItems.Count = 0 Then gridFile.SelectedObject = Nothing
    End Sub

    ' Navigate to parent directory
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        Dim p = GetPath().TrimEnd("/"c)
        If Equals(p, "") Then Return
        FillList(Path.GetDirectoryName(p))
    End Sub

    ' Refresh current directory
    Private Sub btnOpenPath_Click(sender As Object, e As EventArgs)
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return
        ReloadList()
    End Sub
    Private Sub ReloadList()
        FillList(GetPath())
        gridFile.SelectedObject = Nothing
    End Sub

    ' Delete an element
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Do you really want to delete selected item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        If Not _ur.Sftp.Connected Then Return

        For Each itm In lstFolder.SelectedItems.OfType(Of ListViewItem)()
            Dim file = TryCast(itm.Tag, SftpFile)

            If file Is Nothing Then Return

            _ur.Sftp.Delete(file.FullName)
            Thread.Sleep(500)
            ReloadList()
        Next
    End Sub

    ' Edit item to rename element
    Private Sub btnRename_Click(sender As Object, e As EventArgs)
        lstFolder.SelectedItems?.OfType(Of ListViewItem)()?.FirstOrDefault()?.BeginEdit()
    End Sub

    ' Send file to the robot and refresh list
    Private Sub btnUpload_Click(sender As Object, e As EventArgs)
        If Not _ur.Sftp.Connected Then Return

        If dlgOpen.ShowDialog() <> DialogResult.OK Then Return

        Using selectedFile = File.OpenRead(dlgOpen.FileName)
            _ur.Sftp.UploadFile(selectedFile, GetPath() & Path.GetFileName(dlgOpen.FileName).Replace("\", "/"))
        End Using

        Thread.Sleep(500)
        ReloadList()
        SelectFile(Path.GetFileName(dlgOpen.FileName))
    End Sub

    ' Get current directory path
    Private Function GetPath() As String
        If Not txtPath.Text.EndsWith("/") Then Return txtPath.Text & "/"
        Return txtPath.Text
    End Function

    ' Select a file in list view by its name
    Private Sub SelectFile(name As String)
        Dim itm = lstFolder.Items.OfType(Of ListViewItem)().FirstOrDefault(Function(x) String.Equals(x.Text, name, StringComparison.InvariantCultureIgnoreCase))
        If itm IsNot Nothing Then itm.Selected = True
    End Sub

    ' Save remote file to local computer
    Private Sub btnDownload_Click(sender As Object, e As EventArgs)
        If Not _ur.Sftp.Connected Then Return

        Dim file = TryCast(lstFolder.SelectedItems.OfType(Of ListViewItem)()?.FirstOrDefault()?.Tag, SftpFile)

        If file Is Nothing Then Return

        dlgSave.FileName = Path.GetFileName(file.FullName).Replace("\", "/")

        If dlgSave.ShowDialog() <> DialogResult.OK Then Return

        Using selectedFile = IO.File.Open(dlgSave.FileName, FileMode.OpenOrCreate)
            _ur.Sftp.DownloadFile(file.FullName, selectedFile)
        End Using

        RevealFile(dlgSave.FileName)
    End Sub

    ' Perform renaming or directory creation
    Private Sub lstFolder_AfterLabelEdit(sender As Object, e As LabelEditEventArgs)
        If Not _ur.Sftp.Connected Then Return

        Try
            If lstFolder.Items(e.Item).Tag Is Nothing Then
                ' if it is a directory creation
                _ur.Sftp.CreateDirectory(txtPath.Text & e.Label)
            Else
                Dim file = TryCast(lstFolder.Items(e.Item).Tag, SftpFile)

                If Equals(e.Label, Nothing) OrElse file Is Nothing OrElse Equals(file.Name, e.Label) Then Return

                _ur.Sftp.RenameFile(file.FullName, Path.GetDirectoryName(file.FullName).Replace("\", "/") & "/" & e.Label)
            End If

        Finally
            e.CancelEdit = True
            Thread.Sleep(500)
            ReloadList()
            SelectFile(e.Label)
        End Try
    End Sub


    Private Sub btnNewFolder_Click(sender As Object, e As EventArgs)
        If Not _ur.Sftp.Connected Then Return
        lstFolder.Items.Add("new directory", "folder").BeginEdit()
    End Sub

    Private Sub btnDecompile_Click(sender As Object, e As EventArgs)
        Dim file = TryCast(lstFolder.SelectedItems?.OfType(Of ListViewItem)()?.FirstOrDefault()?.Tag, SftpFile)

        If file Is Nothing Then Return

        MainForm.Decompile(file.FullName)
    End Sub

    Private Sub gridFile_SelectedObjectsChanged(sender As Object, e As EventArgs)
        Dim selected = TryCast(gridFile.SelectedObject, SftpFile)

        btnDownload.Enabled = TypeOf selected Is Object AndAlso selected.IsRegularFile
        btnRename.Enabled = TypeOf selected Is Object
        btnDelete.Enabled = TypeOf selected Is Object
        btnDecompile.Enabled = TypeOf selected Is Object AndAlso selected.IsRegularFile AndAlso (selected.Name.EndsWith(URProgram.EXTENSION, StringComparison.InvariantCultureIgnoreCase) OrElse selected.Name.EndsWith(URInstallation.EXTENSION, StringComparison.InvariantCultureIgnoreCase))
    End Sub

End Class

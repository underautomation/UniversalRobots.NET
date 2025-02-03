Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Files

Public Partial Class ArchiveControl
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
            Return "Decompile programs and installation"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return True
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub
#End Region



    Private Sub btnOpen_Click(sender As Object, e As EventArgs)
        dlgOpen.InitialDirectory = Path.Combine(Path.GetDirectoryName(GetType(MainForm).Assembly.Location), "Samples")
        If dlgOpen.ShowDialog() = DialogResult.OK Then Decompile(dlgOpen.FileName)
    End Sub

    Public Sub Decompile(fullName As String)
        Dim xml As XElement = Nothing

        If fullName.StartsWith("/") Then
            ' download file by SFTP from robot
            Using stream = New MemoryStream()
                _ur.Sftp.DownloadFile(fullName, stream)
                stream.Position = 0
                xml = URArchive.Load(stream)
            End Using
        Else
            ' load local file
            xml = URArchive.Load(fullName)
        End If

        lblFile.Text = fullName
        browser.DocumentText = "<?xml version=""1.0""?>" & Microsoft.VisualBasic.Constants.vbCrLf & xml.ToString()
    End Sub
End Class

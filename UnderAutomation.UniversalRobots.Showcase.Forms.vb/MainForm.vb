Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Common

Public Partial Class MainForm
    Inherits Form

    Private Shared _Instance As MainForm
    ' UR instance that handles connection to the robot
    Private ReadOnly _ur As UR = New UR()

    Public Shared Property Instance As MainForm
        Get
            Return _Instance
        End Get
        Private Set(value As MainForm)
            _Instance = value
        End Set
    End Property

#Region "Initialisation"
    Public Sub New()
        Instance = Me

        ' Catch all unhandled exceptions
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException
        AddHandler Application.ThreadException, AddressOf Application_ThreadException

        ' Load configuration file
        Config.Load()

        InitializeComponent()

        ' Add nodes in left menu and instanciate associated control 
        AddNode(New ConnectControl(_ur))
        AddNode(New PrimaryInterfaceControl(_ur))
        AddNode(New ProgramControl(_ur))
        AddNode(New RtdeControl(_ur))
        AddNode(New DashboardControl(_ur))
        AddNode(New InterpreterModeControl(_ur))
        AddNode(New XmlRpcControl(_ur))
        AddNode(New SocketControl(_ur))
        AddNode(New SftpControl(_ur))
        AddNode(New SshControl(_ur))
        AddNode(New ToolsControl())
        AddNode(New ArchiveControl(_ur))
        AddNode(New LicenseControl())
        AddNode(New LogControl())

        AddHandler _ur.InternalErrorOccured, AddressOf _ur_InternalErrorOccured

        ' Select first node at startup
        SelectNode(leftTreeView.Nodes(0))

    End Sub


    Private Sub AddNode(control As IUserControl)
        Dim node = leftTreeView.Nodes.Add(control.Title)
        node.Tag = control
    End Sub
#End Region

#Region "Unhandled exception"
    Private Sub Application_ThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)
        CatchApplicationException(e.Exception)
    End Sub

    Private Sub CurrentDomain_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        CatchApplicationException(TryCast(e.ExceptionObject, Exception))
    End Sub

    Private Sub CatchApplicationException(e As Exception)
        If InvokeRequired Then
            Invoke(New Action(Sub() CatchApplicationException(e)))
            Return
        End If

        MessageBox.Show(e?.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region

#Region "User interaction"
    Private Sub leftTreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        SelectNode(e.Node)
    End Sub

    Friend Function SelectNode(Of T As {Class, IUserControl})() As T
        Dim node = Instance.leftTreeView.Nodes.OfType(Of TreeNode)().FirstOrDefault(Function(n) TypeOf n.Tag Is T)
        Dim control = TryCast(node.Tag, T)
        SelectNode(node)
        Return control
    End Function

    ' Open right control associated to a node
    Friend Sub SelectNode(node As TreeNode)
        If leftTreeView.SelectedNode IsNot node Then leftTreeView.SelectedNode = node

        If node Is Nothing Then Return

        mainPanel.SuspendLayout()

        mainPanel.Controls.OfType(Of IUserControl)().FirstOrDefault()?.OnClose()

        mainPanel.Controls.Clear()

        Dim control = TryCast(node.Tag, Control)

        If control Is Nothing Then
            panelTitle.Text = ""
            Return
        End If

        panelTitle.Text = TryCast(node.Tag, IUserControl)?.Title

        mainPanel.Controls.Add(control)

        control.Dock = DockStyle.Fill

        mainPanel.ResumeLayout()

        mainPanel.Controls.OfType(Of IUserControl)().FirstOrDefault()?.OnOpen()
        mainPanel.Controls.OfType(Of IUserControl)().FirstOrDefault()?.PeriodicUpdate()
    End Sub

    ' Open browser to documentation page
    Private Sub lblLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://underautomation.com/universal-robots/documentation?f")
    End Sub
#End Region

    ' Timer callback to refresh the control on the right and the left menu
    Private Sub tmrPeriodicUpdate_Tick(sender As Object, e As EventArgs)
        Try
            ' refresh control on the right
            mainPanel.Controls.OfType(Of IUserControl)().FirstOrDefault()?.PeriodicUpdate()
        Catch
        End Try

        lblStatus.Text = If(_ur.Enabled, $"Connected to {_ur.IP}", "Disconnected")

        Try
            ' Refresh left menu icons and colors
            For Each node As TreeNode In leftTreeView.Nodes
                Try
                    Dim ctrl = TryCast(node?.Tag, IUserControl)
                    If ctrl Is Nothing Then Continue For

                    Dim enabled = ctrl.FeatureEnabled

                    Dim key = If(enabled, "ON", "OFF")

                    If Not Equals(key, node.ImageKey) Then
                        node.ImageKey = key
                        node.SelectedImageKey = key
                        node.ForeColor = If(enabled, Color.Green, Color.DarkGray)
                    End If

                Catch
                End Try
            Next

        Catch
        End Try
    End Sub

    Private Sub titlePictureBox_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Generate(Me)
    End Sub

    Public Shared Sub Decompile(fullName As String)
        Dim control = Instance.SelectNode(Of ArchiveControl)()
        control?.Decompile(fullName)
    End Sub

    Public Shared Sub InvokeOnMainForm(action As [Delegate])
        If Instance.InvokeRequired Then
            Instance.Invoke(action)
            Return
        End If
        action?.DynamicInvoke()
    End Sub

#Region "Show errors"
    Public ReadOnly Errors As List(Of String) = New List(Of String)()

    Private Sub lblErrors_Click(sender As Object, e As EventArgs)
        Call SelectNode(Of LogControl)()
    End Sub

    ' Hide red label after some times
    Private Sub tmrError_Tick(sender As Object, e As EventArgs)
        tmrError.Enabled = False
        lblErrors.Text = ""
        lblErrors.Visible = False
    End Sub

    ' Callback when an error occured in SDK
    Private Sub _ur_InternalErrorOccured(sender As Object, e As InternalErrorEventArgs)
        Dim [error] = e.ToString()
        Errors.Add([error])
        ShowError([error])
    End Sub

    ' Display error
    Private Sub ShowError([error] As String)
        If InvokeRequired Then
            Invoke(New Action(Sub() ShowError([error])))
            Return
        End If

        If String.IsNullOrEmpty([error]) Then Return

        If [error].Length > 100 Then [error] = [error].Substring(0, 100) & " ..."

        lblErrors.Text = [error]
        lblErrors.Visible = True

        ' Show label some times
        tmrError.Enabled = True
    End Sub
#End Region
End Class

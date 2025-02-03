Imports System
Imports System.Reflection
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots

Public Partial Class ProgramControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Public Sub New(ur As UR)
        _ur = ur

        InitializeComponent()

        ' prevent list view from flickering
        Dim method = GetType(Control).GetMethod("SetStyle", BindingFlags.Instance Or BindingFlags.NonPublic)
        method.Invoke(lstVariables, New Object() {ControlStyles.OptimizedDoubleBuffer, True})
        method.Invoke(lstThreads, New Object() {ControlStyles.OptimizedDoubleBuffer, True})
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Running program and variables"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.PrimaryInterface.Connected OrElse _ur.Sftp.Connected AndAlso _ur.Dashboard.Initialized
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        lblWarningVariables.Visible = Not _ur.PrimaryInterface.Connected

        Dim variables = _ur.PrimaryInterface.GlobalVariables.GetAll()

        lstVariables.UpdateList(variables, Function(v) v.Name, Function(v) v.Type.ToString(), Function(v) v.ToString())

        Dim threads = _ur.PrimaryInterface.ProgramThreads?.Threads

        If TypeOf threads Is Object Then lstThreads.UpdateList(threads, Function(t) t.LineNumber.ToString(), Function(t) t.LineName)
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
    Public Sub OnOpen() Implements IUserControl.OnOpen
        cbPrograms.Items.Clear()

        Dim enabled = _ur.Sftp.Connected AndAlso _ur.Dashboard.Initialized

        btnPause.Enabled = enabled
        btnRun.Enabled = enabled
        btnStop.Enabled = enabled
        cbPrograms.Enabled = enabled

        If Not enabled Then
            lblPathToPrograms.Text = "Enable Sftp and dashboard to list available programs"
            Return
        End If

        Try
            Dim programs = _ur.Sftp.EnumeratePrograms()
            cbPrograms.Items.AddRange(programs)
            lblPathToPrograms.Text = ""
        Catch e As Exception
            lblPathToPrograms.Text = $"{lblPathToPrograms.Text} ({e.Message})"
        End Try
    End Sub
#End Region

    Private Sub btnRun_Click(sender As Object, e As EventArgs)
        Dim result = _ur.Dashboard.LoadProgram(cbPrograms.Text)

        If Not result.Succeed Then Throw New Exception(result.Message)

        result = _ur.Dashboard.Play()

        If Not result.Succeed Then Throw New Exception(result.Message)
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs)
        _ur.Dashboard.Pause()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs)
        _ur.Dashboard.Stop()
    End Sub
End Class

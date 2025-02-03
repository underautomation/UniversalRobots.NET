Imports System
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Ssh.Tools
Imports UnderAutomation.UniversalRobots.Ssh.Tools.Common

Public Partial Class SshControl
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
            Return "Linux commands (SSH)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.Ssh.Connected
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        txtShellCommand.Enabled = FeatureEnabled
        btnSendShell.Enabled = FeatureEnabled
        txtSSHCommand.Enabled = FeatureEnabled
        btnSSHSend.Enabled = FeatureEnabled
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
        ' Close shell when control is not displayed
        _shell?.Close()
        _shell = Nothing
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
        If Not _ur.Ssh.Connected Then Return

        ' Create shell when control is displayed
        _shell = _ur.Ssh.CreateShellStream("UnderAutomation", 40, 100, 40, 100, 1000)
    End Sub
#End Region

    ' Send SSH command to the robot outside a shell context
    Private Sub btnSSHSend_Click(sender As Object, e As EventArgs)
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return
        If String.IsNullOrEmpty(txtSSHCommand.Text) Then Return
        If Not _ur.Ssh.Connected Then Return

        Dim command = _ur.Ssh.CreateCommand(txtSSHCommand.Text)

        command.Execute()

        txtCommandResult.Text = $"> {command.CommandText} (Exit status : {command.ExitStatus})
{command.Result}
{command.Error}"
    End Sub

#Region "Shell"
    Private __shell As ShellStream

    Private Property _shell As ShellStream
        Get
            Return __shell
        End Get
        Set(value As ShellStream)
            ' set new shell and handlers
            If TypeOf __shell Is Object Then
                RemoveHandler __shell.DataReceived, AddressOf _shell_DataReceived
                RemoveHandler __shell.ErrorOccurred, AddressOf _shell_ErrorOccurred
            End If
            __shell = value

            If TypeOf __shell Is Object Then
                AddHandler __shell.DataReceived, AddressOf _shell_DataReceived
                AddHandler __shell.ErrorOccurred, AddressOf _shell_ErrorOccurred
            End If
        End Set
    End Property

    ' Send new command to shell
    Private Sub btnSendShell_Click(sender As Object, e As EventArgs)
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return
        If String.IsNullOrEmpty(txtShellCommand.Text) Then Return

        _shell?.WriteLine(txtShellCommand.Text)

        txtShellCommand.Text = ""
    End Sub

    ' Display received data from shell
    Private Sub _shell_DataReceived(sender As Object, e As ShellDataEventArgs)
        If txtShellHistory.InvokeRequired Then
            txtShellHistory.Invoke(New Action(Sub() shell_DataReceived(e)))
        Else
            shell_DataReceived(e)
        End If
    End Sub
    Private Sub shell_DataReceived(e As ShellDataEventArgs)
        Dim rawData = Encoding.UTF8.GetString(e.Data)

        ' remove ANSI data from answer (for example color infos)
        Dim data = Regex.Replace(rawData, "(\x9B|\x1B\[)[0-?]*[ -\/]*[@-~]", "")

        txtShellHistory.AppendText(data)

        txtShellHistory.ScrollToCaret()
    End Sub

    ' Display SSH errors
    Private Sub _shell_ErrorOccurred(sender As Object, e As ExceptionEventArgs)
        If txtShellHistory.InvokeRequired Then
            txtShellHistory.Invoke(New Action(Sub() shell_ErrorOccurred(e.Exception.Message)))
        Else
            shell_ErrorOccurred(e.Exception.Message)
        End If
    End Sub
    Private Sub shell_ErrorOccurred(message As String)
        txtShellHistory.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & " --- ERROR ---" & Microsoft.VisualBasic.Constants.vbCrLf & message & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf)
    End Sub
#End Region
End Class

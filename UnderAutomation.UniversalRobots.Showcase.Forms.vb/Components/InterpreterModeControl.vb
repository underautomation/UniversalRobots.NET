Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.InterpreterMode

Public Partial Class InterpreterModeControl
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
            Return "Interpreter mode"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.InterpreterMode.Connected
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        pnlMain.Enabled = FeatureEnabled
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub
#End Region

    ' Append command response to the console text area
    Private Sub Log(response As CommandResponse)
        txtConsole.AppendText(response.Command)
        If response.Status = CommandResponseStatus.Error Then
            txtConsole.SelectionColor = Color.Red
        ElseIf response.Status = CommandResponseStatus.Discard Then
            txtConsole.SelectionColor = Color.Orange
        Else
            txtConsole.SelectionColor = Color.Green
        End If

        txtConsole.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & "  Status: ")
        txtConsole.AppendText(response.Status.ToString())
        If response.Status <> CommandResponseStatus.Error Then
            txtConsole.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & "  Id: ")
            txtConsole.AppendText(response.Id.ToString())
        End If
        txtConsole.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & "  Body: ")
        txtConsole.AppendText(response.Body)

        txtConsole.SelectionColor = Color.White
        txtConsole.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "> ")
        txtConsole.ScrollToCaret()
    End Sub


    Private Sub btnSendCommand_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.ExecuteCommand(txtCommand.Text)
        Log(response)
    End Sub

    Private Sub btnEndInterpreter_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.EndInterpreter()
        Log(response)
    End Sub

    Private Sub btnClearInterpreter_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.ClearInterpreter()
        Log(response)
    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.Abort()
        Log(response)
    End Sub

    Private Sub btnSkipBuffer_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.SkipBuffer()
        Log(response)
    End Sub

    Private Sub btnLastExecuted_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.StateLastExecuted()
        Log(response)
    End Sub

    Private Sub btnLastInterpreted_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.StateLastInterpreted()
        Log(response)
    End Sub

    Private Sub btnLastCleared_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.StateLastCleared()
        Log(response)
    End Sub

    Private Sub btnLastUnexecuted_Click(sender As Object, e As EventArgs)
        Dim response = _ur.InterpreterMode.StateLastUnexecuted()
        Log(response)
    End Sub
End Class

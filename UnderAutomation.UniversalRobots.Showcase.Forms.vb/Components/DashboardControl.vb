Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Common
Imports UnderAutomation.UniversalRobots.Dashboard

Public Partial Class DashboardControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR
    Public Sub New(ur As UR)
        _ur = ur

        InitializeComponent()

        ' fill enum combos
        For Each value In [Enum].GetValues(GetType(UserRoles))
            cbUserRoles.Items.Add(value)
        Next
        cbUserRoles.SelectedItem = UserRoles.Operator
        For Each value In [Enum].GetValues(GetType(OperationalModes))
            cbOperationalMode.Items.Add(value)
        Next
        cbOperationalMode.SelectedItem = OperationalModes.Automatic
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Dashboard (Remote send commands)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return Not String.IsNullOrEmpty(_ur.Dashboard.IP)
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
    Private Sub Log(response As CommandResponse, command As String, Optional messageBefore As String = Nothing, Optional messageAfter As String = Nothing)
        txtConsole.AppendText(command)
        txtConsole.AppendText("()" & Microsoft.VisualBasic.Constants.vbCrLf)

        txtConsole.SelectionBullet = True
        If response.Succeed Then
            txtConsole.SelectionColor = Color.Green
            txtConsole.AppendText("OK : ")
        Else
            txtConsole.SelectionColor = Color.Red
            txtConsole.AppendText("FAILED : ")
        End If

        If Not Equals(messageBefore, Nothing) Then txtConsole.AppendText(messageBefore)
        txtConsole.AppendText(If(response.ToString(), ""))
        If Not Equals(messageAfter, Nothing) Then txtConsole.AppendText(messageAfter)


        txtConsole.SelectionBullet = False
        txtConsole.SelectionColor = Color.White
        txtConsole.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "> ")
        txtConsole.ScrollToCaret()
    End Sub

#Region "Command clicks"
    Private Sub btnGetRobotMode_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetRobotMode()
        Log(response, "GetRobotMode")
    End Sub

    Private Sub btnPowerOn_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.PowerOn()
        Log(response, "PowerOn")
    End Sub

    Private Sub btnPowerOff_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.PowerOff()
        Log(response, "PowerOff")
    End Sub

    Private Sub ReaseBrake_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.ReleaseBrake()
        Log(response, "ReleaseBrake")
    End Sub

    Private Sub btnUnlockProtectiveStop_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.UnlockProtectiveStop()
        Log(response, "UnlockProtectiveStop")
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.Shutdown()
        Log(response, "Shutdown")
    End Sub

    Private Sub btnLoadProgram_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.LoadProgram(txtProgram.Text)
        Log(response, "LoadProgram")

        Config.Current.LoadProgram = txtProgram.Text
        Config.Save()
    End Sub

    Private Sub btnGetLoadedProgram_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetLoadedProgram()
        Log(response, "GetLoadedProgram")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.Play()
        Log(response, "Play")
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.Stop()
        Log(response, "Stop")
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.Pause()
        Log(response, "Pause")
    End Sub

    Private Sub btnProgrammRunning_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.IsProgramRunning()
        Log(response, "IsProgramRunning")
    End Sub

    Private Sub btnGetProgramState_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetProgramState()
        Log(response, "GetProgramState")
    End Sub

    Private Sub btnIsProgramSaved_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.IsProgramSaved()
        Log(response, "IsProgramSaved")
    End Sub

    Private Sub btnShowPopup_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.ShowPopup(txtPopup.Text)
        Log(response, "ShowPopup")

        Config.Current.ShowPopup = txtPopup.Text
        Config.Save()
    End Sub

    Private Sub btnClosePopup_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.ClosePopup()
        Log(response, "ClosePopup")
    End Sub

    Private Sub btnAddToLog_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.AddToLog(txtLog.Text)
        Log(response, "AddToLog")

        Config.Current.AddToLog = txtLog.Text
        Config.Save()
    End Sub

    Private Sub btnPolyscopeVersion_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetPolyscopeVersion()
        Log(response, "GetPolyscopeVersion")
    End Sub

    Private Sub btnLoadInstallation_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.LoadInstallation(txtInstallation.Text)
        Log(response, "LoadInstallation")

        Config.Current.LoadInstallation = txtInstallation.Text
        Config.Save()
    End Sub

    Private Sub btnGetSerialNumber_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetSerialNumber()
        Log(response, "GetSerialNumber")
    End Sub

    Private Sub btnGetRobotModel_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetRobotModel()
        Log(response, "GetRobotModel")
    End Sub

    Private Sub btnGetOperationalMode_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetOperationalMode()
        Log(response, "GetOperationalMode")
    End Sub

    Private Sub btnClearOIperationalMode_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.ClearOperationalMode()
        Log(response, "ClearOperationalMode")
    End Sub

    Private Sub btnSetOperationalMode_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.SetOperationalMode(CType(cbOperationalMode.SelectedItem, OperationalModes))
        Log(response, "SetOperationalMode")
    End Sub

    Private Sub btnSetUserRole_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.SetUserRole(CType(cbUserRoles.SelectedItem, UserRoles))
        Log(response, "SetUserRole")
    End Sub

    Private Sub btnIsInRemoteControl_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.IsInRemoteControl()
        Log(response, "IsInRemoteControl")
    End Sub

    Private Sub btnSafetyStatus_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetSafetyStatus()
        Log(response, "GetSafetyStatus")
    End Sub

    Private Sub btnCloseSafetyPopup_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.CloseSafetyPopup()
        Log(response, "CloseSafetyPopup")
    End Sub

    Private Sub btnRestartSafety_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.RestartSafety()
        Log(response, "RestartSafety")
    End Sub

    Private Sub txtSendCustomCommand_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.SendCustomDashboardCommand(txtCustomCommand.Text)
        Log(response, "SendCustomDashboardCommand")
    End Sub

    Private Sub btnGetVariableValue_Click(sender As Object, e As EventArgs)
        Dim response = _ur.Dashboard.GetVariable(txtVariableName.Text)
        If response.Value.Type = GlobalVariableTypes.None Then
            Log(response, "GetVariableValue", $"Variable {txtVariableName.Text} is not declared. ")
        Else
            Log(response, "GetVariableValue", If(response.Succeed, $"{response.Value.Type} {response.Value.Name} = ", ""))
        End If
    End Sub
#End Region

End Class

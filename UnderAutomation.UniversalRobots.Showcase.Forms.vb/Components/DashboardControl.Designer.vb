Partial Class DashboardControl
    ''' <summary> 
    ''' Variable nécessaire au concepteur.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Nettoyage des ressources utilisées.
    ''' </summary>
    ''' <paramname="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Code généré par le Concepteur de composants"

    ''' <summary> 
    ''' Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    ''' le contenu de cette méthode avec l'éditeur de code.
    ''' </summary>
    Private Sub InitializeComponent()
        splitMain = New Windows.Forms.SplitContainer()
        txtConsole = New Windows.Forms.RichTextBox()
        pnlMain = New Windows.Forms.Panel()
        GroupBox6 = New Windows.Forms.GroupBox()
        cbOperationalMode = New Windows.Forms.ComboBox()
        cbUserRoles = New Windows.Forms.ComboBox()
        btnIsInRemoteControl = New Windows.Forms.Button()
        btnSetUserRole = New Windows.Forms.Button()
        btnSetOperationalMode = New Windows.Forms.Button()
        btnClearOIperationalMode = New Windows.Forms.Button()
        btnGetOperationalMode = New Windows.Forms.Button()
        GroupBox5 = New Windows.Forms.GroupBox()
        btnClosePopup = New Windows.Forms.Button()
        btnShowPopup = New Windows.Forms.Button()
        txtPopup = New Windows.Forms.TextBox()
        btnAddToLog = New Windows.Forms.Button()
        txtLog = New Windows.Forms.TextBox()
        btnPolyscopeVersion = New Windows.Forms.Button()
        txtInstallation = New Windows.Forms.TextBox()
        btnGetSerialNumber = New Windows.Forms.Button()
        btnGetRobotModel = New Windows.Forms.Button()
        btnLoadInstallation = New Windows.Forms.Button()
        GroupBox4 = New Windows.Forms.GroupBox()
        btnCloseSafetyPopup = New Windows.Forms.Button()
        btnSafetyStatus = New Windows.Forms.Button()
        btnRestartSafety = New Windows.Forms.Button()
        GroupBox3 = New Windows.Forms.GroupBox()
        btnPlay = New Windows.Forms.Button()
        btnStop = New Windows.Forms.Button()
        btnPause = New Windows.Forms.Button()
        btnLoadProgram = New Windows.Forms.Button()
        txtProgram = New Windows.Forms.TextBox()
        btnIsProgramSaved = New Windows.Forms.Button()
        btnProgrammRunning = New Windows.Forms.Button()
        btnGetProgramState = New Windows.Forms.Button()
        btnGetLoadedProgram = New Windows.Forms.Button()
        GroupBox1 = New Windows.Forms.GroupBox()
        btnPowerOn = New Windows.Forms.Button()
        btnPowerOff = New Windows.Forms.Button()
        ReaseBrake = New Windows.Forms.Button()
        btnUnlockProtectiveStop = New Windows.Forms.Button()
        btnGetRobotMode = New Windows.Forms.Button()
        btnShutdown = New Windows.Forms.Button()
        groupBox2 = New Windows.Forms.GroupBox()
        txtCustomCommand = New Windows.Forms.TextBox()
        txtSendCustomCommand = New Windows.Forms.Button()
        txtVariableName = New Windows.Forms.TextBox()
        btnGetVariableValue = New Windows.Forms.Button()
        splitMain.Panel1.SuspendLayout()
        splitMain.Panel2.SuspendLayout()
        splitMain.SuspendLayout()
        pnlMain.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        groupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' splitMain
        ' 
        splitMain.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        splitMain.Dock = Windows.Forms.DockStyle.Fill
        splitMain.Location = New Drawing.Point(0, 0)
        splitMain.Name = "splitMain"
        ' 
        ' splitMain.Panel1
        ' 
        splitMain.Panel1.Controls.Add(txtConsole)
        ' 
        ' splitMain.Panel2
        ' 
        splitMain.Panel2.AutoScroll = True
        splitMain.Panel2.Controls.Add(pnlMain)
        splitMain.Size = New Drawing.Size(1240, 710)
        splitMain.SplitterDistance = 413
        splitMain.TabIndex = 1
        ' 
        ' txtConsole
        ' 
        txtConsole.BackColor = Drawing.Color.Black
        txtConsole.BorderStyle = Windows.Forms.BorderStyle.None
        txtConsole.Dock = Windows.Forms.DockStyle.Fill
        txtConsole.ForeColor = Drawing.Color.White
        txtConsole.Location = New Drawing.Point(0, 0)
        txtConsole.Name = "txtConsole"
        txtConsole.ReadOnly = True
        txtConsole.Size = New Drawing.Size(409, 706)
        txtConsole.TabIndex = 0
        txtConsole.Text = "Please use commands on the right panel." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "> "
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(GroupBox6)
        pnlMain.Controls.Add(groupBox2)
        pnlMain.Controls.Add(GroupBox5)
        pnlMain.Controls.Add(GroupBox4)
        pnlMain.Controls.Add(GroupBox3)
        pnlMain.Controls.Add(GroupBox1)
        pnlMain.Location = New Drawing.Point(3, 3)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Drawing.Size(436, 582)
        pnlMain.TabIndex = 9
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(cbOperationalMode)
        GroupBox6.Controls.Add(cbUserRoles)
        GroupBox6.Controls.Add(btnIsInRemoteControl)
        GroupBox6.Controls.Add(btnSetUserRole)
        GroupBox6.Controls.Add(btnSetOperationalMode)
        GroupBox6.Controls.Add(btnClearOIperationalMode)
        GroupBox6.Controls.Add(btnGetOperationalMode)
        GroupBox6.Location = New Drawing.Point(175, 231)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Drawing.Size(253, 165)
        GroupBox6.TabIndex = 8
        GroupBox6.TabStop = False
        GroupBox6.Text = "Operational modes"
        ' 
        ' cbOperationalMode
        ' 
        cbOperationalMode.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        cbOperationalMode.FormattingEnabled = True
        cbOperationalMode.Location = New Drawing.Point(6, 76)
        cbOperationalMode.Name = "cbOperationalMode"
        cbOperationalMode.Size = New Drawing.Size(123, 21)
        cbOperationalMode.TabIndex = 3
        ' 
        ' cbUserRoles
        ' 
        cbUserRoles.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
        cbUserRoles.FormattingEnabled = True
        cbUserRoles.Location = New Drawing.Point(6, 107)
        cbUserRoles.Name = "cbUserRoles"
        cbUserRoles.Size = New Drawing.Size(123, 21)
        cbUserRoles.TabIndex = 2
        ' 
        ' btnIsInRemoteControl
        ' 
        btnIsInRemoteControl.Location = New Drawing.Point(6, 134)
        btnIsInRemoteControl.Name = "btnIsInRemoteControl"
        btnIsInRemoteControl.Size = New Drawing.Size(237, 23)
        btnIsInRemoteControl.TabIndex = 0
        btnIsInRemoteControl.Text = "Is robot in remote control ?"
        btnIsInRemoteControl.UseVisualStyleBackColor = True
        AddHandler btnIsInRemoteControl.Click, New EventHandler(AddressOf btnIsInRemoteControl_Click)
        ' 
        ' btnSetUserRole
        ' 
        btnSetUserRole.Location = New Drawing.Point(132, 106)
        btnSetUserRole.Name = "btnSetUserRole"
        btnSetUserRole.Size = New Drawing.Size(111, 23)
        btnSetUserRole.TabIndex = 0
        btnSetUserRole.Text = "Set role (old FW)"
        btnSetUserRole.UseVisualStyleBackColor = True
        AddHandler btnSetUserRole.Click, New EventHandler(AddressOf btnSetUserRole_Click)
        ' 
        ' btnSetOperationalMode
        ' 
        btnSetOperationalMode.Location = New Drawing.Point(132, 75)
        btnSetOperationalMode.Name = "btnSetOperationalMode"
        btnSetOperationalMode.Size = New Drawing.Size(111, 23)
        btnSetOperationalMode.TabIndex = 0
        btnSetOperationalMode.Text = "Set operational mode"
        btnSetOperationalMode.UseVisualStyleBackColor = True
        AddHandler btnSetOperationalMode.Click, New EventHandler(AddressOf btnSetOperationalMode_Click)
        ' 
        ' btnClearOIperationalMode
        ' 
        btnClearOIperationalMode.Location = New Drawing.Point(6, 48)
        btnClearOIperationalMode.Name = "btnClearOIperationalMode"
        btnClearOIperationalMode.Size = New Drawing.Size(237, 23)
        btnClearOIperationalMode.TabIndex = 0
        btnClearOIperationalMode.Text = "Clear operational mode"
        btnClearOIperationalMode.UseVisualStyleBackColor = True
        AddHandler btnClearOIperationalMode.Click, New EventHandler(AddressOf btnClearOIperationalMode_Click)
        ' 
        ' btnGetOperationalMode
        ' 
        btnGetOperationalMode.Location = New Drawing.Point(6, 19)
        btnGetOperationalMode.Name = "btnGetOperationalMode"
        btnGetOperationalMode.Size = New Drawing.Size(237, 23)
        btnGetOperationalMode.TabIndex = 0
        btnGetOperationalMode.Text = "Get operational mode"
        btnGetOperationalMode.UseVisualStyleBackColor = True
        AddHandler btnGetOperationalMode.Click, New EventHandler(AddressOf btnGetOperationalMode_Click)
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btnClosePopup)
        GroupBox5.Controls.Add(btnShowPopup)
        GroupBox5.Controls.Add(txtPopup)
        GroupBox5.Controls.Add(btnAddToLog)
        GroupBox5.Controls.Add(txtLog)
        GroupBox5.Controls.Add(btnPolyscopeVersion)
        GroupBox5.Controls.Add(txtInstallation)
        GroupBox5.Controls.Add(btnGetSerialNumber)
        GroupBox5.Controls.Add(btnGetRobotModel)
        GroupBox5.Controls.Add(btnLoadInstallation)
        GroupBox5.Location = New Drawing.Point(175, 0)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Drawing.Size(253, 225)
        GroupBox5.TabIndex = 7
        GroupBox5.TabStop = False
        GroupBox5.Text = "Information"
        ' 
        ' btnClosePopup
        ' 
        btnClosePopup.Location = New Drawing.Point(8, 48)
        btnClosePopup.Name = "btnClosePopup"
        btnClosePopup.Size = New Drawing.Size(235, 23)
        btnClosePopup.TabIndex = 0
        btnClosePopup.Text = "Close popup"
        btnClosePopup.UseVisualStyleBackColor = True
        AddHandler btnClosePopup.Click, New EventHandler(AddressOf btnClosePopup_Click)
        ' 
        ' btnShowPopup
        ' 
        btnShowPopup.Location = New Drawing.Point(150, 20)
        btnShowPopup.Name = "btnShowPopup"
        btnShowPopup.Size = New Drawing.Size(93, 23)
        btnShowPopup.TabIndex = 0
        btnShowPopup.Text = "Show popup"
        btnShowPopup.UseVisualStyleBackColor = True
        AddHandler btnShowPopup.Click, New EventHandler(AddressOf btnShowPopup_Click)
        ' 
        ' txtPopup
        ' 
        txtPopup.Location = New Drawing.Point(8, 22)
        txtPopup.Name = "txtPopup"
        txtPopup.Size = New Drawing.Size(136, 20)
        txtPopup.TabIndex = 1
        txtPopup.Text = "This is a popup message !"
        ' 
        ' btnAddToLog
        ' 
        btnAddToLog.Location = New Drawing.Point(150, 78)
        btnAddToLog.Name = "btnAddToLog"
        btnAddToLog.Size = New Drawing.Size(93, 23)
        btnAddToLog.TabIndex = 0
        btnAddToLog.Text = "Add to log"
        btnAddToLog.UseVisualStyleBackColor = True
        AddHandler btnAddToLog.Click, New EventHandler(AddressOf btnAddToLog_Click)
        ' 
        ' txtLog
        ' 
        txtLog.Location = New Drawing.Point(8, 80)
        txtLog.Name = "txtLog"
        txtLog.Size = New Drawing.Size(136, 20)
        txtLog.TabIndex = 1
        txtLog.Text = "This is a log message !"
        ' 
        ' btnPolyscopeVersion
        ' 
        btnPolyscopeVersion.Location = New Drawing.Point(8, 106)
        btnPolyscopeVersion.Name = "btnPolyscopeVersion"
        btnPolyscopeVersion.Size = New Drawing.Size(235, 23)
        btnPolyscopeVersion.TabIndex = 0
        btnPolyscopeVersion.Text = "Get Polyscope version"
        btnPolyscopeVersion.UseVisualStyleBackColor = True
        AddHandler btnPolyscopeVersion.Click, New EventHandler(AddressOf btnPolyscopeVersion_Click)
        ' 
        ' txtInstallation
        ' 
        txtInstallation.Location = New Drawing.Point(6, 138)
        txtInstallation.Name = "txtInstallation"
        txtInstallation.Size = New Drawing.Size(138, 20)
        txtInstallation.TabIndex = 1
        txtInstallation.Text = "default.installation"
        ' 
        ' btnGetSerialNumber
        ' 
        btnGetSerialNumber.Location = New Drawing.Point(6, 164)
        btnGetSerialNumber.Name = "btnGetSerialNumber"
        btnGetSerialNumber.Size = New Drawing.Size(237, 23)
        btnGetSerialNumber.TabIndex = 0
        btnGetSerialNumber.Text = "Get serial number"
        btnGetSerialNumber.UseVisualStyleBackColor = True
        AddHandler btnGetSerialNumber.Click, New EventHandler(AddressOf btnGetSerialNumber_Click)
        ' 
        ' btnGetRobotModel
        ' 
        btnGetRobotModel.Location = New Drawing.Point(6, 193)
        btnGetRobotModel.Name = "btnGetRobotModel"
        btnGetRobotModel.Size = New Drawing.Size(237, 23)
        btnGetRobotModel.TabIndex = 0
        btnGetRobotModel.Text = "Get robot model"
        btnGetRobotModel.UseVisualStyleBackColor = True
        AddHandler btnGetRobotModel.Click, New EventHandler(AddressOf btnGetRobotModel_Click)
        ' 
        ' btnLoadInstallation
        ' 
        btnLoadInstallation.Location = New Drawing.Point(150, 136)
        btnLoadInstallation.Name = "btnLoadInstallation"
        btnLoadInstallation.Size = New Drawing.Size(93, 23)
        btnLoadInstallation.TabIndex = 0
        btnLoadInstallation.Text = "Load installation"
        btnLoadInstallation.UseVisualStyleBackColor = True
        AddHandler btnLoadInstallation.Click, New EventHandler(AddressOf btnLoadInstallation_Click)
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnCloseSafetyPopup)
        GroupBox4.Controls.Add(btnSafetyStatus)
        GroupBox4.Controls.Add(btnRestartSafety)
        GroupBox4.Location = New Drawing.Point(175, 402)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Drawing.Size(253, 110)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "Safety"
        ' 
        ' btnCloseSafetyPopup
        ' 
        btnCloseSafetyPopup.Location = New Drawing.Point(8, 48)
        btnCloseSafetyPopup.Name = "btnCloseSafetyPopup"
        btnCloseSafetyPopup.Size = New Drawing.Size(237, 23)
        btnCloseSafetyPopup.TabIndex = 0
        btnCloseSafetyPopup.Text = "Close safety popup"
        btnCloseSafetyPopup.UseVisualStyleBackColor = True
        AddHandler btnCloseSafetyPopup.Click, New EventHandler(AddressOf btnCloseSafetyPopup_Click)
        ' 
        ' btnSafetyStatus
        ' 
        btnSafetyStatus.Location = New Drawing.Point(6, 19)
        btnSafetyStatus.Name = "btnSafetyStatus"
        btnSafetyStatus.Size = New Drawing.Size(237, 23)
        btnSafetyStatus.TabIndex = 0
        btnSafetyStatus.Text = "Get safety status"
        btnSafetyStatus.UseVisualStyleBackColor = True
        AddHandler btnSafetyStatus.Click, New EventHandler(AddressOf btnSafetyStatus_Click)
        ' 
        ' btnRestartSafety
        ' 
        btnRestartSafety.Location = New Drawing.Point(8, 77)
        btnRestartSafety.Name = "btnRestartSafety"
        btnRestartSafety.Size = New Drawing.Size(237, 23)
        btnRestartSafety.TabIndex = 0
        btnRestartSafety.Text = "Restart safety"
        btnRestartSafety.UseVisualStyleBackColor = True
        AddHandler btnRestartSafety.Click, New EventHandler(AddressOf btnRestartSafety_Click)
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnPlay)
        GroupBox3.Controls.Add(btnStop)
        GroupBox3.Controls.Add(btnPause)
        GroupBox3.Controls.Add(btnGetVariableValue)
        GroupBox3.Controls.Add(txtVariableName)
        GroupBox3.Controls.Add(btnLoadProgram)
        GroupBox3.Controls.Add(txtProgram)
        GroupBox3.Controls.Add(btnIsProgramSaved)
        GroupBox3.Controls.Add(btnProgrammRunning)
        GroupBox3.Controls.Add(btnGetProgramState)
        GroupBox3.Controls.Add(btnGetLoadedProgram)
        GroupBox3.Location = New Drawing.Point(1, 204)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Drawing.Size(168, 287)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Programs"
        ' 
        ' btnPlay
        ' 
        btnPlay.Location = New Drawing.Point(6, 80)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Drawing.Size(153, 23)
        btnPlay.TabIndex = 0
        btnPlay.Text = "Play program"
        btnPlay.UseVisualStyleBackColor = True
        AddHandler btnPlay.Click, New EventHandler(AddressOf btnPlay_Click)
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Drawing.Point(6, 109)
        btnStop.Name = "btnStop"
        btnStop.Size = New Drawing.Size(153, 23)
        btnStop.TabIndex = 0
        btnStop.Text = "Stop program"
        btnStop.UseVisualStyleBackColor = True
        AddHandler btnStop.Click, New EventHandler(AddressOf btnStop_Click)
        ' 
        ' btnPause
        ' 
        btnPause.Location = New Drawing.Point(6, 138)
        btnPause.Name = "btnPause"
        btnPause.Size = New Drawing.Size(153, 23)
        btnPause.TabIndex = 0
        btnPause.Text = "Pause program"
        btnPause.UseVisualStyleBackColor = True
        AddHandler btnPause.Click, New EventHandler(AddressOf btnPause_Click)
        ' 
        ' btnLoadProgram
        ' 
        btnLoadProgram.Location = New Drawing.Point(79, 23)
        btnLoadProgram.Name = "btnLoadProgram"
        btnLoadProgram.Size = New Drawing.Size(80, 23)
        btnLoadProgram.TabIndex = 0
        btnLoadProgram.Text = "Load program"
        btnLoadProgram.UseVisualStyleBackColor = True
        AddHandler btnLoadProgram.Click, New EventHandler(AddressOf btnLoadProgram_Click)
        ' 
        ' txtProgram
        ' 
        txtProgram.Location = New Drawing.Point(6, 25)
        txtProgram.Name = "txtProgram"
        txtProgram.Size = New Drawing.Size(70, 20)
        txtProgram.TabIndex = 1
        txtProgram.Text = "default.urp"
        ' 
        ' btnIsProgramSaved
        ' 
        btnIsProgramSaved.Location = New Drawing.Point(6, 225)
        btnIsProgramSaved.Name = "btnIsProgramSaved"
        btnIsProgramSaved.Size = New Drawing.Size(153, 23)
        btnIsProgramSaved.TabIndex = 0
        btnIsProgramSaved.Text = "Is program saved ?"
        btnIsProgramSaved.UseVisualStyleBackColor = True
        AddHandler btnIsProgramSaved.Click, New EventHandler(AddressOf btnIsProgramSaved_Click)
        ' 
        ' btnProgrammRunning
        ' 
        btnProgrammRunning.Location = New Drawing.Point(6, 167)
        btnProgrammRunning.Name = "btnProgrammRunning"
        btnProgrammRunning.Size = New Drawing.Size(153, 23)
        btnProgrammRunning.TabIndex = 0
        btnProgrammRunning.Text = "Is program running ?"
        btnProgrammRunning.UseVisualStyleBackColor = True
        AddHandler btnProgrammRunning.Click, New EventHandler(AddressOf btnProgrammRunning_Click)
        ' 
        ' btnGetProgramState
        ' 
        btnGetProgramState.Location = New Drawing.Point(6, 196)
        btnGetProgramState.Name = "btnGetProgramState"
        btnGetProgramState.Size = New Drawing.Size(153, 23)
        btnGetProgramState.TabIndex = 0
        btnGetProgramState.Text = "Get program state"
        btnGetProgramState.UseVisualStyleBackColor = True
        AddHandler btnGetProgramState.Click, New EventHandler(AddressOf btnGetProgramState_Click)
        ' 
        ' btnGetLoadedProgram
        ' 
        btnGetLoadedProgram.Location = New Drawing.Point(6, 51)
        btnGetLoadedProgram.Name = "btnGetLoadedProgram"
        btnGetLoadedProgram.Size = New Drawing.Size(153, 23)
        btnGetLoadedProgram.TabIndex = 0
        btnGetLoadedProgram.Text = "Get loaded program"
        btnGetLoadedProgram.UseVisualStyleBackColor = True
        AddHandler btnGetLoadedProgram.Click, New EventHandler(AddressOf btnGetLoadedProgram_Click)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnPowerOn)
        GroupBox1.Controls.Add(btnPowerOff)
        GroupBox1.Controls.Add(ReaseBrake)
        GroupBox1.Controls.Add(btnUnlockProtectiveStop)
        GroupBox1.Controls.Add(btnGetRobotMode)
        GroupBox1.Controls.Add(btnShutdown)
        GroupBox1.Location = New Drawing.Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Drawing.Size(169, 198)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Power commands"
        ' 
        ' btnPowerOn
        ' 
        btnPowerOn.Location = New Drawing.Point(8, 48)
        btnPowerOn.Name = "btnPowerOn"
        btnPowerOn.Size = New Drawing.Size(152, 23)
        btnPowerOn.TabIndex = 0
        btnPowerOn.Text = "Power on"
        btnPowerOn.UseVisualStyleBackColor = True
        AddHandler btnPowerOn.Click, New EventHandler(AddressOf btnPowerOn_Click)
        ' 
        ' btnPowerOff
        ' 
        btnPowerOff.Location = New Drawing.Point(8, 77)
        btnPowerOff.Name = "btnPowerOff"
        btnPowerOff.Size = New Drawing.Size(152, 23)
        btnPowerOff.TabIndex = 0
        btnPowerOff.Text = "Power off"
        btnPowerOff.UseVisualStyleBackColor = True
        AddHandler btnPowerOff.Click, New EventHandler(AddressOf btnPowerOff_Click)
        ' 
        ' ReaseBrake
        ' 
        ReaseBrake.Location = New Drawing.Point(8, 106)
        ReaseBrake.Name = "ReaseBrake"
        ReaseBrake.Size = New Drawing.Size(152, 23)
        ReaseBrake.TabIndex = 0
        ReaseBrake.Text = "Release brake"
        ReaseBrake.UseVisualStyleBackColor = True
        AddHandler ReaseBrake.Click, New EventHandler(AddressOf ReaseBrake_Click)
        ' 
        ' btnUnlockProtectiveStop
        ' 
        btnUnlockProtectiveStop.Location = New Drawing.Point(8, 135)
        btnUnlockProtectiveStop.Name = "btnUnlockProtectiveStop"
        btnUnlockProtectiveStop.Size = New Drawing.Size(152, 23)
        btnUnlockProtectiveStop.TabIndex = 0
        btnUnlockProtectiveStop.Text = "Unlock protective stop"
        btnUnlockProtectiveStop.UseVisualStyleBackColor = True
        AddHandler btnUnlockProtectiveStop.Click, New EventHandler(AddressOf btnUnlockProtectiveStop_Click)
        ' 
        ' btnGetRobotMode
        ' 
        btnGetRobotMode.Location = New Drawing.Point(8, 19)
        btnGetRobotMode.Name = "btnGetRobotMode"
        btnGetRobotMode.Size = New Drawing.Size(152, 23)
        btnGetRobotMode.TabIndex = 0
        btnGetRobotMode.Text = "Get robot mode"
        btnGetRobotMode.UseVisualStyleBackColor = True
        AddHandler btnGetRobotMode.Click, New EventHandler(AddressOf btnGetRobotMode_Click)
        ' 
        ' btnShutdown
        ' 
        btnShutdown.Location = New Drawing.Point(8, 164)
        btnShutdown.Name = "btnShutdown"
        btnShutdown.Size = New Drawing.Size(152, 23)
        btnShutdown.TabIndex = 0
        btnShutdown.Text = "Shutdown robot"
        btnShutdown.UseVisualStyleBackColor = True
        AddHandler btnShutdown.Click, New EventHandler(AddressOf btnShutdown_Click)
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(txtSendCustomCommand)
        groupBox2.Controls.Add(txtCustomCommand)
        groupBox2.Location = New Drawing.Point(175, 516)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Drawing.Size(253, 50)
        groupBox2.TabIndex = 5
        groupBox2.TabStop = False
        groupBox2.Text = "Custom"
        ' 
        ' txtCustomCommand
        ' 
        txtCustomCommand.Location = New Drawing.Point(7, 19)
        txtCustomCommand.Name = "txtCustomCommand"
        txtCustomCommand.Size = New Drawing.Size(137, 20)
        txtCustomCommand.TabIndex = 1
        txtCustomCommand.Text = "get loaded program"
        ' 
        ' txtSendCustomCommand
        ' 
        txtSendCustomCommand.Location = New Drawing.Point(150, 17)
        txtSendCustomCommand.Name = "txtSendCustomCommand"
        txtSendCustomCommand.Size = New Drawing.Size(93, 23)
        txtSendCustomCommand.TabIndex = 0
        txtSendCustomCommand.Text = "Send"
        txtSendCustomCommand.UseVisualStyleBackColor = True
        AddHandler txtSendCustomCommand.Click, New EventHandler(AddressOf txtSendCustomCommand_Click)
        ' 
        ' txtVariableName
        ' 
        txtVariableName.Location = New Drawing.Point(6, 256)
        txtVariableName.Name = "txtVariableName"
        txtVariableName.Size = New Drawing.Size(70, 20)
        txtVariableName.TabIndex = 1
        txtVariableName.Text = "var_1"
        ' 
        ' btnGetVariableValue
        ' 
        btnGetVariableValue.Location = New Drawing.Point(79, 254)
        btnGetVariableValue.Name = "btnGetVariableValue"
        btnGetVariableValue.Size = New Drawing.Size(80, 23)
        btnGetVariableValue.TabIndex = 0
        btnGetVariableValue.Text = "Get variable"
        btnGetVariableValue.UseVisualStyleBackColor = True
        AddHandler btnGetVariableValue.Click, New EventHandler(AddressOf btnGetVariableValue_Click)
        ' 
        ' DashboardServerControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(splitMain)
        Name = "DashboardServerControl"
        Size = New Drawing.Size(1240, 710)
        splitMain.Panel1.ResumeLayout(False)
        splitMain.Panel2.ResumeLayout(False)
        splitMain.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Friend splitMain As Windows.Forms.SplitContainer
    Friend txtConsole As Windows.Forms.RichTextBox
    Friend GroupBox6 As Windows.Forms.GroupBox
    Friend cbOperationalMode As Windows.Forms.ComboBox
    Friend cbUserRoles As Windows.Forms.ComboBox
    Friend btnIsInRemoteControl As Windows.Forms.Button
    Friend btnSetUserRole As Windows.Forms.Button
    Friend btnSetOperationalMode As Windows.Forms.Button
    Friend btnClearOIperationalMode As Windows.Forms.Button
    Friend btnGetOperationalMode As Windows.Forms.Button
    Friend GroupBox5 As Windows.Forms.GroupBox
    Friend btnClosePopup As Windows.Forms.Button
    Friend btnShowPopup As Windows.Forms.Button
    Friend txtPopup As Windows.Forms.TextBox
    Friend btnAddToLog As Windows.Forms.Button
    Friend txtLog As Windows.Forms.TextBox
    Friend btnPolyscopeVersion As Windows.Forms.Button
    Friend txtInstallation As Windows.Forms.TextBox
    Friend btnGetSerialNumber As Windows.Forms.Button
    Friend btnGetRobotModel As Windows.Forms.Button
    Friend btnLoadInstallation As Windows.Forms.Button
    Friend GroupBox4 As Windows.Forms.GroupBox
    Friend btnCloseSafetyPopup As Windows.Forms.Button
    Friend btnSafetyStatus As Windows.Forms.Button
    Friend btnRestartSafety As Windows.Forms.Button
    Friend GroupBox3 As Windows.Forms.GroupBox
    Friend btnPlay As Windows.Forms.Button
    Friend btnStop As Windows.Forms.Button
    Friend btnPause As Windows.Forms.Button
    Friend btnLoadProgram As Windows.Forms.Button
    Friend txtProgram As Windows.Forms.TextBox
    Friend btnIsProgramSaved As Windows.Forms.Button
    Friend btnProgrammRunning As Windows.Forms.Button
    Friend btnGetProgramState As Windows.Forms.Button
    Friend btnGetLoadedProgram As Windows.Forms.Button
    Friend GroupBox1 As Windows.Forms.GroupBox
    Friend btnPowerOn As Windows.Forms.Button
    Friend btnPowerOff As Windows.Forms.Button
    Friend ReaseBrake As Windows.Forms.Button
    Friend btnUnlockProtectiveStop As Windows.Forms.Button
    Friend btnGetRobotMode As Windows.Forms.Button
    Friend btnShutdown As Windows.Forms.Button
    Private pnlMain As Windows.Forms.Panel
    Friend groupBox2 As Windows.Forms.GroupBox
    Friend txtSendCustomCommand As Windows.Forms.Button
    Friend txtCustomCommand As Windows.Forms.TextBox
    Friend btnGetVariableValue As Windows.Forms.Button
    Friend txtVariableName As Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.tmrConnected = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAck = New System.Windows.Forms.Button()
        Me.txtErrors = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.linkDoc = New System.Windows.Forms.LinkLabel()
        Me.txtLicense = New System.Windows.Forms.RichTextBox()
        Me.licGrid = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.pnl = New System.Windows.Forms.FlowLayoutPanel()
        Me.gridRobotMode = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridCartesian = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridForce = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridTool = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridToolModeInfo = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.GridToolCommunication = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridAdditionnalInfo = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridMasterboard = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridConfiguration = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridJointData = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.gridKinematicsData = New Underautomation.UniversalRobots.Example.RobotStateControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtConsole = New System.Windows.Forms.RichTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbOperationalMode = New System.Windows.Forms.ComboBox()
        Me.cbUserRoles = New System.Windows.Forms.ComboBox()
        Me.btnIsInRemoteControl = New System.Windows.Forms.Button()
        Me.btnSetUserRole = New System.Windows.Forms.Button()
        Me.btnSetOperationalMode = New System.Windows.Forms.Button()
        Me.btnClearOIperationalMode = New System.Windows.Forms.Button()
        Me.btnGetOperationalMode = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnClosePopup = New System.Windows.Forms.Button()
        Me.btnShowPopup = New System.Windows.Forms.Button()
        Me.txtPopup = New System.Windows.Forms.TextBox()
        Me.btnAddToLog = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnPolyscopeVersion = New System.Windows.Forms.Button()
        Me.txtInstallation = New System.Windows.Forms.TextBox()
        Me.btnGetSerialNumber = New System.Windows.Forms.Button()
        Me.btnGetRobotModel = New System.Windows.Forms.Button()
        Me.btnLoadInstallation = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCloseSafetyPopup = New System.Windows.Forms.Button()
        Me.btnSafetyStatus = New System.Windows.Forms.Button()
        Me.btnRestartSafety = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnLoadProgram = New System.Windows.Forms.Button()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.btnIsProgramSaved = New System.Windows.Forms.Button()
        Me.btnProgrammRunning = New System.Windows.Forms.Button()
        Me.btnGetProgramState = New System.Windows.Forms.Button()
        Me.btnGetLoadedProgram = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPowerOn = New System.Windows.Forms.Button()
        Me.btnPowerOff = New System.Windows.Forms.Button()
        Me.ReaseBrake = New System.Windows.Forms.Button()
        Me.btnUnlockProtectiveStop = New System.Windows.Forms.Button()
        Me.btnGetRobotMode = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.docBrowser = New System.Windows.Forms.WebBrowser()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(12, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(180, 20)
        Me.txtIP.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 38)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(287, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(12, 67)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(287, 23)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'lblConnected
        '
        Me.lblConnected.Location = New System.Drawing.Point(198, 12)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(101, 20)
        Me.lblConnected.TabIndex = 2
        Me.lblConnected.Text = "Disconnected"
        Me.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrConnected
        '
        Me.tmrConnected.Enabled = True
        Me.tmrConnected.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(601, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Errors :"
        '
        'btnAck
        '
        Me.btnAck.Location = New System.Drawing.Point(604, 100)
        Me.btnAck.Name = "btnAck"
        Me.btnAck.Size = New System.Drawing.Size(293, 23)
        Me.btnAck.TabIndex = 4
        Me.btnAck.Text = "Acknowledge"
        Me.btnAck.UseVisualStyleBackColor = True
        '
        'txtErrors
        '
        Me.txtErrors.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtErrors.ForeColor = System.Drawing.Color.Red
        Me.txtErrors.Location = New System.Drawing.Point(604, 15)
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.ReadOnly = True
        Me.txtErrors.Size = New System.Drawing.Size(293, 79)
        Me.txtErrors.TabIndex = 5
        Me.txtErrors.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Script :"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(305, 100)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(293, 23)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(305, 15)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(293, 79)
        Me.txtScript.TabIndex = 6
        Me.txtScript.Text = "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.linkDoc)
        Me.Panel1.Controls.Add(Me.txtScript)
        Me.Panel1.Controls.Add(Me.txtLicense)
        Me.Panel1.Controls.Add(Me.txtErrors)
        Me.Panel1.Controls.Add(Me.licGrid)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAck)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblConnected)
        Me.Panel1.Controls.Add(Me.btnDisconnect)
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.txtIP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1610, 143)
        Me.Panel1.TabIndex = 7
        '
        'linkDoc
        '
        Me.linkDoc.AutoSize = True
        Me.linkDoc.Location = New System.Drawing.Point(12, 105)
        Me.linkDoc.Name = "linkDoc"
        Me.linkDoc.Size = New System.Drawing.Size(111, 13)
        Me.linkDoc.TabIndex = 8
        Me.linkDoc.TabStop = True
        Me.linkDoc.Text = "See documentation ..."
        '
        'txtLicense
        '
        Me.txtLicense.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLicense.Location = New System.Drawing.Point(1180, 38)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.Size = New System.Drawing.Size(365, 85)
        Me.txtLicense.TabIndex = 5
        Me.txtLicense.Text = ""
        '
        'licGrid
        '
        Me.licGrid.LabelText = "License info"
        Me.licGrid.Location = New System.Drawing.Point(902, 3)
        Me.licGrid.Name = "licGrid"
        Me.licGrid.Size = New System.Drawing.Size(272, 120)
        Me.licGrid.TabIndex = 7
        '
        'pnl
        '
        Me.pnl.AutoScroll = True
        Me.pnl.AutoScrollMinSize = New System.Drawing.Size(1, 10)
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl.Controls.Add(Me.gridRobotMode)
        Me.pnl.Controls.Add(Me.gridCartesian)
        Me.pnl.Controls.Add(Me.gridForce)
        Me.pnl.Controls.Add(Me.gridTool)
        Me.pnl.Controls.Add(Me.gridToolModeInfo)
        Me.pnl.Controls.Add(Me.GridToolCommunication)
        Me.pnl.Controls.Add(Me.gridAdditionnalInfo)
        Me.pnl.Controls.Add(Me.gridMasterboard)
        Me.pnl.Controls.Add(Me.gridConfiguration)
        Me.pnl.Controls.Add(Me.gridJointData)
        Me.pnl.Controls.Add(Me.gridKinematicsData)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnl.Location = New System.Drawing.Point(3, 3)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1596, 886)
        Me.pnl.TabIndex = 7
        '
        'gridRobotMode
        '
        Me.gridRobotMode.LabelText = "Robot mode"
        Me.gridRobotMode.Location = New System.Drawing.Point(3, 3)
        Me.gridRobotMode.Name = "gridRobotMode"
        Me.gridRobotMode.Size = New System.Drawing.Size(342, 266)
        Me.gridRobotMode.TabIndex = 1
        '
        'gridCartesian
        '
        Me.gridCartesian.LabelText = "Cartesian"
        Me.gridCartesian.Location = New System.Drawing.Point(3, 275)
        Me.gridCartesian.Name = "gridCartesian"
        Me.gridCartesian.Size = New System.Drawing.Size(342, 341)
        Me.gridCartesian.TabIndex = 2
        '
        'gridForce
        '
        Me.gridForce.LabelText = "Force mode"
        Me.gridForce.Location = New System.Drawing.Point(3, 622)
        Me.gridForce.Name = "gridForce"
        Me.gridForce.Size = New System.Drawing.Size(342, 201)
        Me.gridForce.TabIndex = 1
        '
        'gridTool
        '
        Me.gridTool.LabelText = "Tool"
        Me.gridTool.Location = New System.Drawing.Point(351, 3)
        Me.gridTool.Name = "gridTool"
        Me.gridTool.Size = New System.Drawing.Size(342, 266)
        Me.gridTool.TabIndex = 1
        '
        'gridToolModeInfo
        '
        Me.gridToolModeInfo.LabelText = "Tool mode Info"
        Me.gridToolModeInfo.Location = New System.Drawing.Point(351, 275)
        Me.gridToolModeInfo.Name = "gridToolModeInfo"
        Me.gridToolModeInfo.Size = New System.Drawing.Size(342, 141)
        Me.gridToolModeInfo.TabIndex = 6
        '
        'GridToolCommunication
        '
        Me.GridToolCommunication.LabelText = "Tool Communication Info"
        Me.GridToolCommunication.Location = New System.Drawing.Point(351, 422)
        Me.GridToolCommunication.Name = "GridToolCommunication"
        Me.GridToolCommunication.Size = New System.Drawing.Size(342, 194)
        Me.GridToolCommunication.TabIndex = 7
        '
        'gridAdditionnalInfo
        '
        Me.gridAdditionnalInfo.LabelText = "Additionnal info"
        Me.gridAdditionnalInfo.Location = New System.Drawing.Point(351, 622)
        Me.gridAdditionnalInfo.Name = "gridAdditionnalInfo"
        Me.gridAdditionnalInfo.Size = New System.Drawing.Size(342, 201)
        Me.gridAdditionnalInfo.TabIndex = 4
        '
        'gridMasterboard
        '
        Me.gridMasterboard.LabelText = "Masterboard"
        Me.gridMasterboard.Location = New System.Drawing.Point(699, 3)
        Me.gridMasterboard.Name = "gridMasterboard"
        Me.gridMasterboard.Size = New System.Drawing.Size(342, 820)
        Me.gridMasterboard.TabIndex = 3
        '
        'gridConfiguration
        '
        Me.gridConfiguration.LabelText = "Configuration"
        Me.gridConfiguration.Location = New System.Drawing.Point(1047, 3)
        Me.gridConfiguration.Name = "gridConfiguration"
        Me.gridConfiguration.Size = New System.Drawing.Size(343, 820)
        Me.gridConfiguration.TabIndex = 5
        '
        'gridJointData
        '
        Me.gridJointData.LabelText = "Joint"
        Me.gridJointData.Location = New System.Drawing.Point(1396, 3)
        Me.gridJointData.Name = "gridJointData"
        Me.gridJointData.Size = New System.Drawing.Size(342, 820)
        Me.gridJointData.TabIndex = 8
        '
        'gridKinematicsData
        '
        Me.gridKinematicsData.LabelText = "Kinematics"
        Me.gridKinematicsData.Location = New System.Drawing.Point(1744, 3)
        Me.gridKinematicsData.Name = "gridKinematicsData"
        Me.gridKinematicsData.Size = New System.Drawing.Size(342, 820)
        Me.gridKinematicsData.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 143)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1610, 919)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.pnl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1602, 892)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Streaming data"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1602, 892)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Commands"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtConsole)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1596, 886)
        Me.SplitContainer1.SplitterDistance = 532
        Me.SplitContainer1.TabIndex = 0
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsole.ForeColor = System.Drawing.Color.White
        Me.txtConsole.Location = New System.Drawing.Point(0, 0)
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.Size = New System.Drawing.Size(532, 886)
        Me.txtConsole.TabIndex = 0
        Me.txtConsole.Text = "Please use commands on the right panel." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "> "
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbOperationalMode)
        Me.GroupBox6.Controls.Add(Me.cbUserRoles)
        Me.GroupBox6.Controls.Add(Me.btnIsInRemoteControl)
        Me.GroupBox6.Controls.Add(Me.btnSetUserRole)
        Me.GroupBox6.Controls.Add(Me.btnSetOperationalMode)
        Me.GroupBox6.Controls.Add(Me.btnClearOIperationalMode)
        Me.GroupBox6.Controls.Add(Me.btnGetOperationalMode)
        Me.GroupBox6.Location = New System.Drawing.Point(394, 258)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(342, 178)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Operational modes"
        '
        'cbOperationalMode
        '
        Me.cbOperationalMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOperationalMode.FormattingEnabled = True
        Me.cbOperationalMode.Location = New System.Drawing.Point(6, 76)
        Me.cbOperationalMode.Name = "cbOperationalMode"
        Me.cbOperationalMode.Size = New System.Drawing.Size(201, 21)
        Me.cbOperationalMode.TabIndex = 3
        '
        'cbUserRoles
        '
        Me.cbUserRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUserRoles.FormattingEnabled = True
        Me.cbUserRoles.Location = New System.Drawing.Point(6, 107)
        Me.cbUserRoles.Name = "cbUserRoles"
        Me.cbUserRoles.Size = New System.Drawing.Size(201, 21)
        Me.cbUserRoles.TabIndex = 2
        '
        'btnIsInRemoteControl
        '
        Me.btnIsInRemoteControl.Location = New System.Drawing.Point(6, 134)
        Me.btnIsInRemoteControl.Name = "btnIsInRemoteControl"
        Me.btnIsInRemoteControl.Size = New System.Drawing.Size(318, 23)
        Me.btnIsInRemoteControl.TabIndex = 0
        Me.btnIsInRemoteControl.Text = "Is robot in remote control ?"
        Me.btnIsInRemoteControl.UseVisualStyleBackColor = True
        '
        'btnSetUserRole
        '
        Me.btnSetUserRole.Location = New System.Drawing.Point(213, 105)
        Me.btnSetUserRole.Name = "btnSetUserRole"
        Me.btnSetUserRole.Size = New System.Drawing.Size(111, 23)
        Me.btnSetUserRole.TabIndex = 0
        Me.btnSetUserRole.Text = "Set role (old FW)"
        Me.btnSetUserRole.UseVisualStyleBackColor = True
        '
        'btnSetOperationalMode
        '
        Me.btnSetOperationalMode.Location = New System.Drawing.Point(213, 76)
        Me.btnSetOperationalMode.Name = "btnSetOperationalMode"
        Me.btnSetOperationalMode.Size = New System.Drawing.Size(111, 23)
        Me.btnSetOperationalMode.TabIndex = 0
        Me.btnSetOperationalMode.Text = "Set operational mode"
        Me.btnSetOperationalMode.UseVisualStyleBackColor = True
        '
        'btnClearOIperationalMode
        '
        Me.btnClearOIperationalMode.Location = New System.Drawing.Point(6, 48)
        Me.btnClearOIperationalMode.Name = "btnClearOIperationalMode"
        Me.btnClearOIperationalMode.Size = New System.Drawing.Size(318, 23)
        Me.btnClearOIperationalMode.TabIndex = 0
        Me.btnClearOIperationalMode.Text = "Clear operational mode"
        Me.btnClearOIperationalMode.UseVisualStyleBackColor = True
        '
        'btnGetOperationalMode
        '
        Me.btnGetOperationalMode.Location = New System.Drawing.Point(6, 19)
        Me.btnGetOperationalMode.Name = "btnGetOperationalMode"
        Me.btnGetOperationalMode.Size = New System.Drawing.Size(318, 23)
        Me.btnGetOperationalMode.TabIndex = 0
        Me.btnGetOperationalMode.Text = "Get operational mode"
        Me.btnGetOperationalMode.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnClosePopup)
        Me.GroupBox5.Controls.Add(Me.btnShowPopup)
        Me.GroupBox5.Controls.Add(Me.txtPopup)
        Me.GroupBox5.Controls.Add(Me.btnAddToLog)
        Me.GroupBox5.Controls.Add(Me.txtLog)
        Me.GroupBox5.Controls.Add(Me.btnPolyscopeVersion)
        Me.GroupBox5.Controls.Add(Me.txtInstallation)
        Me.GroupBox5.Controls.Add(Me.btnGetSerialNumber)
        Me.GroupBox5.Controls.Add(Me.btnGetRobotModel)
        Me.GroupBox5.Controls.Add(Me.btnLoadInstallation)
        Me.GroupBox5.Location = New System.Drawing.Point(394, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(342, 237)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Information"
        '
        'btnClosePopup
        '
        Me.btnClosePopup.Location = New System.Drawing.Point(8, 48)
        Me.btnClosePopup.Name = "btnClosePopup"
        Me.btnClosePopup.Size = New System.Drawing.Size(318, 23)
        Me.btnClosePopup.TabIndex = 0
        Me.btnClosePopup.Text = "Close popup"
        Me.btnClosePopup.UseVisualStyleBackColor = True
        '
        'btnShowPopup
        '
        Me.btnShowPopup.Location = New System.Drawing.Point(215, 19)
        Me.btnShowPopup.Name = "btnShowPopup"
        Me.btnShowPopup.Size = New System.Drawing.Size(111, 23)
        Me.btnShowPopup.TabIndex = 0
        Me.btnShowPopup.Text = "Show popup"
        Me.btnShowPopup.UseVisualStyleBackColor = True
        '
        'txtPopup
        '
        Me.txtPopup.Location = New System.Drawing.Point(8, 22)
        Me.txtPopup.Name = "txtPopup"
        Me.txtPopup.Size = New System.Drawing.Size(201, 20)
        Me.txtPopup.TabIndex = 1
        Me.txtPopup.Text = "This is a popup message !"
        '
        'btnAddToLog
        '
        Me.btnAddToLog.Location = New System.Drawing.Point(215, 77)
        Me.btnAddToLog.Name = "btnAddToLog"
        Me.btnAddToLog.Size = New System.Drawing.Size(111, 23)
        Me.btnAddToLog.TabIndex = 0
        Me.btnAddToLog.Text = "Add to log"
        Me.btnAddToLog.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(8, 80)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(201, 20)
        Me.txtLog.TabIndex = 1
        Me.txtLog.Text = "This is a log message !"
        '
        'btnPolyscopeVersion
        '
        Me.btnPolyscopeVersion.Location = New System.Drawing.Point(8, 106)
        Me.btnPolyscopeVersion.Name = "btnPolyscopeVersion"
        Me.btnPolyscopeVersion.Size = New System.Drawing.Size(318, 23)
        Me.btnPolyscopeVersion.TabIndex = 0
        Me.btnPolyscopeVersion.Text = "Get Polyscope version"
        Me.btnPolyscopeVersion.UseVisualStyleBackColor = True
        '
        'txtInstallation
        '
        Me.txtInstallation.Location = New System.Drawing.Point(6, 138)
        Me.txtInstallation.Name = "txtInstallation"
        Me.txtInstallation.Size = New System.Drawing.Size(201, 20)
        Me.txtInstallation.TabIndex = 1
        Me.txtInstallation.Text = "default.installation"
        '
        'btnGetSerialNumber
        '
        Me.btnGetSerialNumber.Location = New System.Drawing.Point(6, 164)
        Me.btnGetSerialNumber.Name = "btnGetSerialNumber"
        Me.btnGetSerialNumber.Size = New System.Drawing.Size(318, 23)
        Me.btnGetSerialNumber.TabIndex = 0
        Me.btnGetSerialNumber.Text = "Get serial number"
        Me.btnGetSerialNumber.UseVisualStyleBackColor = True
        '
        'btnGetRobotModel
        '
        Me.btnGetRobotModel.Location = New System.Drawing.Point(6, 193)
        Me.btnGetRobotModel.Name = "btnGetRobotModel"
        Me.btnGetRobotModel.Size = New System.Drawing.Size(318, 23)
        Me.btnGetRobotModel.TabIndex = 0
        Me.btnGetRobotModel.Text = "Get robot model"
        Me.btnGetRobotModel.UseVisualStyleBackColor = True
        '
        'btnLoadInstallation
        '
        Me.btnLoadInstallation.Location = New System.Drawing.Point(213, 135)
        Me.btnLoadInstallation.Name = "btnLoadInstallation"
        Me.btnLoadInstallation.Size = New System.Drawing.Size(111, 23)
        Me.btnLoadInstallation.TabIndex = 0
        Me.btnLoadInstallation.Text = "Load installation"
        Me.btnLoadInstallation.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCloseSafetyPopup)
        Me.GroupBox4.Controls.Add(Me.btnSafetyStatus)
        Me.GroupBox4.Controls.Add(Me.btnRestartSafety)
        Me.GroupBox4.Location = New System.Drawing.Point(394, 443)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 117)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Safety"
        '
        'btnCloseSafetyPopup
        '
        Me.btnCloseSafetyPopup.Location = New System.Drawing.Point(8, 48)
        Me.btnCloseSafetyPopup.Name = "btnCloseSafetyPopup"
        Me.btnCloseSafetyPopup.Size = New System.Drawing.Size(318, 23)
        Me.btnCloseSafetyPopup.TabIndex = 0
        Me.btnCloseSafetyPopup.Text = "Close safety popup"
        Me.btnCloseSafetyPopup.UseVisualStyleBackColor = True
        '
        'btnSafetyStatus
        '
        Me.btnSafetyStatus.Location = New System.Drawing.Point(6, 19)
        Me.btnSafetyStatus.Name = "btnSafetyStatus"
        Me.btnSafetyStatus.Size = New System.Drawing.Size(318, 23)
        Me.btnSafetyStatus.TabIndex = 0
        Me.btnSafetyStatus.Text = "Get safety status"
        Me.btnSafetyStatus.UseVisualStyleBackColor = True
        '
        'btnRestartSafety
        '
        Me.btnRestartSafety.Location = New System.Drawing.Point(8, 77)
        Me.btnRestartSafety.Name = "btnRestartSafety"
        Me.btnRestartSafety.Size = New System.Drawing.Size(318, 23)
        Me.btnRestartSafety.TabIndex = 0
        Me.btnRestartSafety.Text = "Restart safety"
        Me.btnRestartSafety.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPlay)
        Me.GroupBox3.Controls.Add(Me.btnStop)
        Me.GroupBox3.Controls.Add(Me.btnPause)
        Me.GroupBox3.Controls.Add(Me.btnLoadProgram)
        Me.GroupBox3.Controls.Add(Me.txtProgram)
        Me.GroupBox3.Controls.Add(Me.btnIsProgramSaved)
        Me.GroupBox3.Controls.Add(Me.btnProgrammRunning)
        Me.GroupBox3.Controls.Add(Me.btnGetProgramState)
        Me.GroupBox3.Controls.Add(Me.btnGetLoadedProgram)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(341, 285)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Programs"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(6, 80)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(318, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play program"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(6, 109)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(318, 23)
        Me.btnStop.TabIndex = 0
        Me.btnStop.Text = "Stop program"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(6, 138)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(318, 23)
        Me.btnPause.TabIndex = 0
        Me.btnPause.Text = "Pause program"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnLoadProgram
        '
        Me.btnLoadProgram.Location = New System.Drawing.Point(213, 22)
        Me.btnLoadProgram.Name = "btnLoadProgram"
        Me.btnLoadProgram.Size = New System.Drawing.Size(111, 23)
        Me.btnLoadProgram.TabIndex = 0
        Me.btnLoadProgram.Text = "Load program"
        Me.btnLoadProgram.UseVisualStyleBackColor = True
        '
        'txtProgram
        '
        Me.txtProgram.Location = New System.Drawing.Point(6, 25)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(201, 20)
        Me.txtProgram.TabIndex = 1
        Me.txtProgram.Text = "default.urp"
        '
        'btnIsProgramSaved
        '
        Me.btnIsProgramSaved.Location = New System.Drawing.Point(6, 225)
        Me.btnIsProgramSaved.Name = "btnIsProgramSaved"
        Me.btnIsProgramSaved.Size = New System.Drawing.Size(318, 23)
        Me.btnIsProgramSaved.TabIndex = 0
        Me.btnIsProgramSaved.Text = "Is program saved ?"
        Me.btnIsProgramSaved.UseVisualStyleBackColor = True
        '
        'btnProgrammRunning
        '
        Me.btnProgrammRunning.Location = New System.Drawing.Point(6, 167)
        Me.btnProgrammRunning.Name = "btnProgrammRunning"
        Me.btnProgrammRunning.Size = New System.Drawing.Size(318, 23)
        Me.btnProgrammRunning.TabIndex = 0
        Me.btnProgrammRunning.Text = "Is program running ?"
        Me.btnProgrammRunning.UseVisualStyleBackColor = True
        '
        'btnGetProgramState
        '
        Me.btnGetProgramState.Location = New System.Drawing.Point(6, 196)
        Me.btnGetProgramState.Name = "btnGetProgramState"
        Me.btnGetProgramState.Size = New System.Drawing.Size(318, 23)
        Me.btnGetProgramState.TabIndex = 0
        Me.btnGetProgramState.Text = "Get program state"
        Me.btnGetProgramState.UseVisualStyleBackColor = True
        '
        'btnGetLoadedProgram
        '
        Me.btnGetLoadedProgram.Location = New System.Drawing.Point(6, 51)
        Me.btnGetLoadedProgram.Name = "btnGetLoadedProgram"
        Me.btnGetLoadedProgram.Size = New System.Drawing.Size(318, 23)
        Me.btnGetLoadedProgram.TabIndex = 0
        Me.btnGetLoadedProgram.Text = "Get loaded program"
        Me.btnGetLoadedProgram.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPowerOn)
        Me.GroupBox1.Controls.Add(Me.btnPowerOff)
        Me.GroupBox1.Controls.Add(Me.ReaseBrake)
        Me.GroupBox1.Controls.Add(Me.btnUnlockProtectiveStop)
        Me.GroupBox1.Controls.Add(Me.btnGetRobotMode)
        Me.GroupBox1.Controls.Add(Me.btnShutdown)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 254)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Power commands"
        '
        'btnPowerOn
        '
        Me.btnPowerOn.Location = New System.Drawing.Point(8, 48)
        Me.btnPowerOn.Name = "btnPowerOn"
        Me.btnPowerOn.Size = New System.Drawing.Size(318, 23)
        Me.btnPowerOn.TabIndex = 0
        Me.btnPowerOn.Text = "Power on"
        Me.btnPowerOn.UseVisualStyleBackColor = True
        '
        'btnPowerOff
        '
        Me.btnPowerOff.Location = New System.Drawing.Point(8, 77)
        Me.btnPowerOff.Name = "btnPowerOff"
        Me.btnPowerOff.Size = New System.Drawing.Size(318, 23)
        Me.btnPowerOff.TabIndex = 0
        Me.btnPowerOff.Text = "Power off"
        Me.btnPowerOff.UseVisualStyleBackColor = True
        '
        'ReaseBrake
        '
        Me.ReaseBrake.Location = New System.Drawing.Point(8, 106)
        Me.ReaseBrake.Name = "ReaseBrake"
        Me.ReaseBrake.Size = New System.Drawing.Size(318, 23)
        Me.ReaseBrake.TabIndex = 0
        Me.ReaseBrake.Text = "Release brake"
        Me.ReaseBrake.UseVisualStyleBackColor = True
        '
        'btnUnlockProtectiveStop
        '
        Me.btnUnlockProtectiveStop.Location = New System.Drawing.Point(8, 135)
        Me.btnUnlockProtectiveStop.Name = "btnUnlockProtectiveStop"
        Me.btnUnlockProtectiveStop.Size = New System.Drawing.Size(318, 23)
        Me.btnUnlockProtectiveStop.TabIndex = 0
        Me.btnUnlockProtectiveStop.Text = "Unlock protective stop"
        Me.btnUnlockProtectiveStop.UseVisualStyleBackColor = True
        '
        'btnGetRobotMode
        '
        Me.btnGetRobotMode.Location = New System.Drawing.Point(8, 19)
        Me.btnGetRobotMode.Name = "btnGetRobotMode"
        Me.btnGetRobotMode.Size = New System.Drawing.Size(318, 23)
        Me.btnGetRobotMode.TabIndex = 0
        Me.btnGetRobotMode.Text = "Get robot mode"
        Me.btnGetRobotMode.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(8, 164)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(318, 23)
        Me.btnShutdown.TabIndex = 0
        Me.btnShutdown.Text = "Shutdown robot"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.docBrowser)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1602, 892)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Documentation"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'docBrowser
        '
        Me.docBrowser.AllowWebBrowserDrop = False
        Me.docBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.docBrowser.IsWebBrowserContextMenuEnabled = False
        Me.docBrowser.Location = New System.Drawing.Point(0, 0)
        Me.docBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.docBrowser.Name = "docBrowser"
        Me.docBrowser.ScriptErrorsSuppressed = True
        Me.docBrowser.Size = New System.Drawing.Size(1602, 892)
        Me.docBrowser.TabIndex = 0
        Me.docBrowser.Url = New System.Uri("https://underautomation.com/documentation?e", System.UriKind.Absolute)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ua.ico")
        Me.ImageList1.Images.SetKeyName(1, "blank.gif")
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1610, 1062)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Universal Robots SDK - UnderAutomation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents gridRobotMode As RobotStateControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridJointData As RobotStateControl
    Friend WithEvents gridTool As RobotStateControl
    Friend WithEvents gridMasterboard As RobotStateControl
    Friend WithEvents gridCartesian As RobotStateControl
    Friend WithEvents gridConfiguration As RobotStateControl
    Friend WithEvents gridAdditionnalInfo As RobotStateControl
    Friend WithEvents gridForce As RobotStateControl
    Friend WithEvents lblConnected As Label
    Friend WithEvents tmrConnected As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAck As Button
    Friend WithEvents txtErrors As RichTextBox
    Friend WithEvents GridToolCommunication As RobotStateControl
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtScript As TextBox
    Friend WithEvents gridKinematicsData As RobotStateControl
    Friend WithEvents gridToolModeInfo As RobotStateControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl As FlowLayoutPanel
    Friend WithEvents txtLicense As RichTextBox
    Friend WithEvents licGrid As RobotStateControl
    Friend WithEvents linkDoc As LinkLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtConsole As RichTextBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnGetRobotMode As Button
    Friend WithEvents btnProgrammRunning As Button
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents btnLoadProgram As Button
    Friend WithEvents cbUserRoles As ComboBox
    Friend WithEvents txtInstallation As TextBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtPopup As TextBox
    Friend WithEvents btnSetUserRole As Button
    Friend WithEvents btnLoadInstallation As Button
    Friend WithEvents btnAddToLog As Button
    Friend WithEvents btnShowPopup As Button
    Friend WithEvents btnShutdown As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnClosePopup As Button
    Friend WithEvents btnGetLoadedProgram As Button
    Friend WithEvents btnGetRobotModel As Button
    Friend WithEvents btnGetSerialNumber As Button
    Friend WithEvents btnSafetyStatus As Button
    Friend WithEvents btnRestartSafety As Button
    Friend WithEvents btnCloseSafetyPopup As Button
    Friend WithEvents btnUnlockProtectiveStop As Button
    Friend WithEvents ReaseBrake As Button
    Friend WithEvents btnPowerOff As Button
    Friend WithEvents btnPowerOn As Button
    Friend WithEvents btnPolyscopeVersion As Button
    Friend WithEvents btnGetProgramState As Button
    Friend WithEvents btnIsProgramSaved As Button
    Friend WithEvents btnIsInRemoteControl As Button
    Friend WithEvents cbOperationalMode As ComboBox
    Friend WithEvents btnSetOperationalMode As Button
    Friend WithEvents btnClearOIperationalMode As Button
    Friend WithEvents btnGetOperationalMode As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents docBrowser As WebBrowser
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents ImageList1 As ImageList
End Class

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
        Me.pnl = New System.Windows.Forms.FlowLayoutPanel()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabCommands = New System.Windows.Forms.TabPage()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.linkXmlRpcSample = New System.Windows.Forms.LinkLabel()
        Me.udXmlRpcPort = New System.Windows.Forms.NumericUpDown()
        Me.txtXmlRpcPort = New System.Windows.Forms.TextBox()
        Me.txtLocalIP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtXmlRpcStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDisableXmlRpcServer = New System.Windows.Forms.Button()
        Me.btnEnableXmlRpcServer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioRPYToRotationVector = New System.Windows.Forms.RadioButton()
        Me.txtRz = New System.Windows.Forms.TextBox()
        Me.txtRy = New System.Windows.Forms.TextBox()
        Me.txtRx = New System.Windows.Forms.TextBox()
        Me.udRz = New System.Windows.Forms.NumericUpDown()
        Me.udRy = New System.Windows.Forms.NumericUpDown()
        Me.udRx = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.Label()
        Me.txtIn = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridSSHResult = New System.Windows.Forms.PropertyGrid()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSSHSend = New System.Windows.Forms.Button()
        Me.btnSendShell = New System.Windows.Forms.Button()
        Me.txtSSHCommand = New System.Windows.Forms.TextBox()
        Me.txtShellCommand = New System.Windows.Forms.TextBox()
        Me.txtShellHistory = New System.Windows.Forms.RichTextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.lstFolder = New System.Windows.Forms.ListView()
        Me.lstFolderImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrevious = New System.Windows.Forms.ToolStripButton()
        Me.txtPath = New System.Windows.Forms.ToolStripTextBox()
        Me.btnOpenPath = New System.Windows.Forms.ToolStripButton()
        Me.tsFolder = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRename = New System.Windows.Forms.ToolStripButton()
        Me.btnUpload = New System.Windows.Forms.ToolStripButton()
        Me.btnDownload = New System.Windows.Forms.ToolStripButton()
        Me.gridFile = New System.Windows.Forms.PropertyGrid()
        Me.blinkImg = New System.Windows.Forms.ImageList(Me.components)
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.gridRobotMode = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridCartesian = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridForce = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridTool = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridToolModeInfo = New UniversalRobotWinformsExample.RobotStateControl()
        Me.GridToolCommunication = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridAdditionnalInfo = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridMasterboard = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridConfiguration = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridJointData = New UniversalRobotWinformsExample.RobotStateControl()
        Me.gridKinematicsData = New UniversalRobotWinformsExample.RobotStateControl()
        Me.licGrid = New UniversalRobotWinformsExample.RobotStateControl()
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.mainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tabCommands.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.udXmlRpcPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.udRz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udRy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udRx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tsFolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(12, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(180, 20)
        Me.txtIP.TabIndex = 0
        Me.txtIP.Text = "192.168.0.1"
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
        Me.btnSend.Text = "Send script and execute"
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
        Me.linkDoc.Location = New System.Drawing.Point(9, 126)
        Me.linkDoc.Name = "linkDoc"
        Me.linkDoc.Size = New System.Drawing.Size(400, 13)
        Me.linkDoc.TabIndex = 8
        Me.linkDoc.TabStop = True
        Me.linkDoc.Text = "See documentation : https://underautomation.com/universal-robots/documentation"
        '
        'txtLicense
        '
        Me.txtLicense.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLicense.Location = New System.Drawing.Point(1180, 38)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.Size = New System.Drawing.Size(149, 85)
        Me.txtLicense.TabIndex = 5
        Me.txtLicense.Text = ""
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
        Me.pnl.Size = New System.Drawing.Size(1596, 885)
        Me.pnl.TabIndex = 7
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.TabPage1)
        Me.mainTabControl.Controls.Add(Me.tabCommands)
        Me.mainTabControl.Controls.Add(Me.TabPage4)
        Me.mainTabControl.Controls.Add(Me.TabPage5)
        Me.mainTabControl.Controls.Add(Me.TabPage2)
        Me.mainTabControl.Controls.Add(Me.TabPage6)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.ImageList = Me.blinkImg
        Me.mainTabControl.Location = New System.Drawing.Point(0, 143)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(1610, 918)
        Me.mainTabControl.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.pnl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1602, 891)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data streaming"
        '
        'tabCommands
        '
        Me.tabCommands.BackColor = System.Drawing.SystemColors.Control
        Me.tabCommands.Controls.Add(Me.SplitContainer1)
        Me.tabCommands.ImageIndex = 0
        Me.tabCommands.Location = New System.Drawing.Point(4, 23)
        Me.tabCommands.Name = "tabCommands"
        Me.tabCommands.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCommands.Size = New System.Drawing.Size(1602, 891)
        Me.tabCommands.TabIndex = 1
        Me.tabCommands.Text = "Commands"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1596, 885)
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
        Me.txtConsole.Size = New System.Drawing.Size(532, 885)
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.linkXmlRpcSample)
        Me.TabPage4.Controls.Add(Me.udXmlRpcPort)
        Me.TabPage4.Controls.Add(Me.txtXmlRpcPort)
        Me.TabPage4.Controls.Add(Me.txtLocalIP)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.txtXmlRpcStatus)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.btnDisableXmlRpcServer)
        Me.TabPage4.Controls.Add(Me.btnEnableXmlRpcServer)
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1602, 891)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Remote call from robot"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'linkXmlRpcSample
        '
        Me.linkXmlRpcSample.AutoSize = True
        Me.linkXmlRpcSample.Location = New System.Drawing.Point(238, 143)
        Me.linkXmlRpcSample.Name = "linkXmlRpcSample"
        Me.linkXmlRpcSample.Size = New System.Drawing.Size(100, 13)
        Me.linkXmlRpcSample.TabIndex = 9
        Me.linkXmlRpcSample.TabStop = True
        Me.linkXmlRpcSample.Text = "xml_rpc_sample.urp"
        '
        'udXmlRpcPort
        '
        Me.udXmlRpcPort.Location = New System.Drawing.Point(137, 24)
        Me.udXmlRpcPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.udXmlRpcPort.Name = "udXmlRpcPort"
        Me.udXmlRpcPort.Size = New System.Drawing.Size(98, 20)
        Me.udXmlRpcPort.TabIndex = 7
        Me.udXmlRpcPort.Value = New Decimal(New Integer() {50000, 0, 0, 0})
        '
        'txtXmlRpcPort
        '
        Me.txtXmlRpcPort.Location = New System.Drawing.Point(170, 218)
        Me.txtXmlRpcPort.Name = "txtXmlRpcPort"
        Me.txtXmlRpcPort.ReadOnly = True
        Me.txtXmlRpcPort.Size = New System.Drawing.Size(98, 20)
        Me.txtXmlRpcPort.TabIndex = 0
        '
        'txtLocalIP
        '
        Me.txtLocalIP.Location = New System.Drawing.Point(170, 192)
        Me.txtLocalIP.Name = "txtLocalIP"
        Me.txtLocalIP.ReadOnly = True
        Me.txtLocalIP.Size = New System.Drawing.Size(98, 20)
        Me.txtLocalIP.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(30, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "XML-RPC local port :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(63, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Your local port :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(63, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your local PC IP :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtXmlRpcStatus
        '
        Me.txtXmlRpcStatus.Location = New System.Drawing.Point(345, 71)
        Me.txtXmlRpcStatus.Name = "txtXmlRpcStatus"
        Me.txtXmlRpcStatus.Size = New System.Drawing.Size(101, 20)
        Me.txtXmlRpcStatus.TabIndex = 2
        Me.txtXmlRpcStatus.Text = "Enabled"
        Me.txtXmlRpcStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(30, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "2. Replace IP and port with your local machine information :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(30, 712)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(407, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "4. Wait here for a popup asking you what to answer the robot..."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(30, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "3. Run the program on your robot"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(30, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "1. Upload this program on your UR robot : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(282, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "XML-RPC status : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDisableXmlRpcServer
        '
        Me.btnDisableXmlRpcServer.Location = New System.Drawing.Point(33, 79)
        Me.btnDisableXmlRpcServer.Name = "btnDisableXmlRpcServer"
        Me.btnDisableXmlRpcServer.Size = New System.Drawing.Size(202, 23)
        Me.btnDisableXmlRpcServer.TabIndex = 1
        Me.btnDisableXmlRpcServer.Text = "Disable"
        Me.btnDisableXmlRpcServer.UseVisualStyleBackColor = True
        '
        'btnEnableXmlRpcServer
        '
        Me.btnEnableXmlRpcServer.Location = New System.Drawing.Point(33, 50)
        Me.btnEnableXmlRpcServer.Name = "btnEnableXmlRpcServer"
        Me.btnEnableXmlRpcServer.Size = New System.Drawing.Size(202, 23)
        Me.btnEnableXmlRpcServer.TabIndex = 1
        Me.btnEnableXmlRpcServer.Text = "Enable"
        Me.btnEnableXmlRpcServer.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.xml_rpc_sample
        Me.PictureBox1.Location = New System.Drawing.Point(33, 282)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1300, 408)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox7)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1602, 891)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tools"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadioButton2)
        Me.GroupBox7.Controls.Add(Me.radioRPYToRotationVector)
        Me.GroupBox7.Controls.Add(Me.txtRz)
        Me.GroupBox7.Controls.Add(Me.txtRy)
        Me.GroupBox7.Controls.Add(Me.txtRx)
        Me.GroupBox7.Controls.Add(Me.udRz)
        Me.GroupBox7.Controls.Add(Me.udRy)
        Me.GroupBox7.Controls.Add(Me.udRx)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtOut)
        Me.GroupBox7.Controls.Add(Me.txtIn)
        Me.GroupBox7.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(439, 191)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Convert angles"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(260, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(162, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.Text = "From Rotation Vector to RPY"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'radioRPYToRotationVector
        '
        Me.radioRPYToRotationVector.AutoSize = True
        Me.radioRPYToRotationVector.Checked = True
        Me.radioRPYToRotationVector.Location = New System.Drawing.Point(72, 25)
        Me.radioRPYToRotationVector.Name = "radioRPYToRotationVector"
        Me.radioRPYToRotationVector.Size = New System.Drawing.Size(161, 17)
        Me.radioRPYToRotationVector.TabIndex = 6
        Me.radioRPYToRotationVector.TabStop = True
        Me.radioRPYToRotationVector.Text = "From RPY to Rotation vector"
        Me.radioRPYToRotationVector.UseVisualStyleBackColor = True
        '
        'txtRz
        '
        Me.txtRz.Location = New System.Drawing.Point(243, 145)
        Me.txtRz.Name = "txtRz"
        Me.txtRz.ReadOnly = True
        Me.txtRz.Size = New System.Drawing.Size(100, 20)
        Me.txtRz.TabIndex = 5
        '
        'txtRy
        '
        Me.txtRy.Location = New System.Drawing.Point(243, 119)
        Me.txtRy.Name = "txtRy"
        Me.txtRy.ReadOnly = True
        Me.txtRy.Size = New System.Drawing.Size(100, 20)
        Me.txtRy.TabIndex = 4
        '
        'txtRx
        '
        Me.txtRx.Location = New System.Drawing.Point(243, 93)
        Me.txtRx.Name = "txtRx"
        Me.txtRx.ReadOnly = True
        Me.txtRx.Size = New System.Drawing.Size(100, 20)
        Me.txtRx.TabIndex = 3
        '
        'udRz
        '
        Me.udRz.DecimalPlaces = 3
        Me.udRz.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.udRz.Location = New System.Drawing.Point(72, 145)
        Me.udRz.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.udRz.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.udRz.Name = "udRz"
        Me.udRz.Size = New System.Drawing.Size(120, 20)
        Me.udRz.TabIndex = 2
        '
        'udRy
        '
        Me.udRy.DecimalPlaces = 3
        Me.udRy.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.udRy.Location = New System.Drawing.Point(72, 119)
        Me.udRy.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.udRy.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.udRy.Name = "udRy"
        Me.udRy.Size = New System.Drawing.Size(120, 20)
        Me.udRy.TabIndex = 1
        '
        'udRx
        '
        Me.udRx.DecimalPlaces = 3
        Me.udRx.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.udRx.Location = New System.Drawing.Point(72, 93)
        Me.udRx.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.udRx.Minimum = New Decimal(New Integer() {9999, 0, 0, -2147483648})
        Me.udRx.Name = "udRx"
        Me.udRx.Size = New System.Drawing.Size(120, 20)
        Me.udRx.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "RZ (rad) :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 72)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "="
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "RY (rad) :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RX (rad) :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(224, 52)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(142, 38)
        Me.txtOut.TabIndex = 1
        Me.txtOut.Text = "Rotation Vector"
        Me.txtOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIn
        '
        Me.txtIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIn.Location = New System.Drawing.Point(56, 52)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(147, 38)
        Me.txtIn.TabIndex = 1
        Me.txtIn.Text = "RPY"
        Me.txtIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridSSHResult)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.btnSSHSend)
        Me.TabPage2.Controls.Add(Me.btnSendShell)
        Me.TabPage2.Controls.Add(Me.txtSSHCommand)
        Me.TabPage2.Controls.Add(Me.txtShellCommand)
        Me.TabPage2.Controls.Add(Me.txtShellHistory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1602, 891)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "SSH command lines"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridSSHResult
        '
        Me.gridSSHResult.HelpVisible = False
        Me.gridSSHResult.Location = New System.Drawing.Point(856, 155)
        Me.gridSSHResult.Name = "gridSSHResult"
        Me.gridSSHResult.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.gridSSHResult.Size = New System.Drawing.Size(624, 156)
        Me.gridSSHResult.TabIndex = 4
        Me.gridSSHResult.ToolbarVisible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label15.Location = New System.Drawing.Point(22, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 22)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = ">"
        '
        'btnSSHSend
        '
        Me.btnSSHSend.Location = New System.Drawing.Point(1382, 126)
        Me.btnSSHSend.Name = "btnSSHSend"
        Me.btnSSHSend.Size = New System.Drawing.Size(98, 23)
        Me.btnSSHSend.TabIndex = 2
        Me.btnSSHSend.Text = "Send"
        Me.btnSSHSend.UseVisualStyleBackColor = True
        '
        'btnSendShell
        '
        Me.btnSendShell.Location = New System.Drawing.Point(656, 431)
        Me.btnSendShell.Name = "btnSendShell"
        Me.btnSendShell.Size = New System.Drawing.Size(98, 23)
        Me.btnSendShell.TabIndex = 2
        Me.btnSendShell.Text = "Send"
        Me.btnSendShell.UseVisualStyleBackColor = True
        '
        'txtSSHCommand
        '
        Me.txtSSHCommand.Location = New System.Drawing.Point(856, 128)
        Me.txtSSHCommand.Name = "txtSSHCommand"
        Me.txtSSHCommand.Size = New System.Drawing.Size(520, 20)
        Me.txtSSHCommand.TabIndex = 1
        '
        'txtShellCommand
        '
        Me.txtShellCommand.Location = New System.Drawing.Point(48, 433)
        Me.txtShellCommand.Name = "txtShellCommand"
        Me.txtShellCommand.Size = New System.Drawing.Size(602, 20)
        Me.txtShellCommand.TabIndex = 1
        '
        'txtShellHistory
        '
        Me.txtShellHistory.BackColor = System.Drawing.Color.Black
        Me.txtShellHistory.ForeColor = System.Drawing.Color.White
        Me.txtShellHistory.Location = New System.Drawing.Point(21, 128)
        Me.txtShellHistory.Name = "txtShellHistory"
        Me.txtShellHistory.ReadOnly = True
        Me.txtShellHistory.Size = New System.Drawing.Size(733, 299)
        Me.txtShellHistory.TabIndex = 0
        Me.txtShellHistory.Text = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.SplitContainer2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1602, 891)
        Me.TabPage6.TabIndex = 6
        Me.TabPage6.Text = "Secure FTP"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Location = New System.Drawing.Point(21, 49)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lstFolder)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.tsFolder)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gridFile)
        Me.SplitContainer2.Size = New System.Drawing.Size(848, 425)
        Me.SplitContainer2.SplitterDistance = 588
        Me.SplitContainer2.TabIndex = 1
        '
        'lstFolder
        '
        Me.lstFolder.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFolder.HideSelection = False
        Me.lstFolder.LabelEdit = True
        Me.lstFolder.LargeImageList = Me.lstFolderImageList
        Me.lstFolder.Location = New System.Drawing.Point(0, 50)
        Me.lstFolder.Name = "lstFolder"
        Me.lstFolder.Size = New System.Drawing.Size(584, 371)
        Me.lstFolder.TabIndex = 1
        Me.lstFolder.UseCompatibleStateImageBehavior = False
        '
        'lstFolderImageList
        '
        Me.lstFolderImageList.ImageStream = CType(resources.GetObject("lstFolderImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstFolderImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.lstFolderImageList.Images.SetKeyName(0, "folder")
        Me.lstFolderImageList.Images.SetKeyName(1, "file")
        Me.lstFolderImageList.Images.SetKeyName(2, "symbolicLink")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrevious, Me.txtPath, Me.btnOpenPath})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPrevious
        '
        Me.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrevious.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.arrow_up_line
        Me.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(23, 22)
        Me.btnPrevious.Text = "Parent folder"
        '
        'txtPath
        '
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(400, 25)
        '
        'btnOpenPath
        '
        Me.btnOpenPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOpenPath.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.arrow_right_line
        Me.btnOpenPath.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpenPath.Name = "btnOpenPath"
        Me.btnOpenPath.Size = New System.Drawing.Size(23, 22)
        Me.btnOpenPath.Text = "Open"
        '
        'tsFolder
        '
        Me.tsFolder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnDelete, Me.btnRename, Me.btnUpload, Me.btnDownload})
        Me.tsFolder.Location = New System.Drawing.Point(0, 0)
        Me.tsFolder.Name = "tsFolder"
        Me.tsFolder.Size = New System.Drawing.Size(584, 25)
        Me.tsFolder.TabIndex = 0
        Me.tsFolder.Text = "ToolStrip1"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.refresh_line
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.delete_bin_5_line
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete"
        '
        'btnRename
        '
        Me.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRename.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.file_edit_line
        Me.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(23, 22)
        Me.btnRename.Text = "Rename"
        '
        'btnUpload
        '
        Me.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUpload.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.upload_2_line
        Me.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(23, 22)
        Me.btnUpload.Text = "Upload file"
        '
        'btnDownload
        '
        Me.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDownload.Image = Global.UniversalRobotWinformsExample.My.Resources.Resources.download_2_line
        Me.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(23, 22)
        Me.btnDownload.Text = "Download File"
        '
        'gridFile
        '
        Me.gridFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridFile.HelpVisible = False
        Me.gridFile.Location = New System.Drawing.Point(0, 0)
        Me.gridFile.Name = "gridFile"
        Me.gridFile.Size = New System.Drawing.Size(252, 421)
        Me.gridFile.TabIndex = 0
        Me.gridFile.ToolbarVisible = False
        '
        'blinkImg
        '
        Me.blinkImg.ImageStream = CType(resources.GetObject("blinkImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.blinkImg.TransparentColor = System.Drawing.Color.Transparent
        Me.blinkImg.Images.SetKeyName(0, "ua.ico")
        Me.blinkImg.Images.SetKeyName(1, "empty.png")
        '
        'dlgOpen
        '
        Me.dlgOpen.Filter = "All files|*.*"
        Me.dlgOpen.Title = "Select file to upload"
        '
        'dlgSave
        '
        Me.dlgSave.Filter = "All files|*.*"
        Me.dlgSave.Title = "Download file"
        '
        'gridRobotMode
        '
        Me.gridRobotMode.LabelText = "Robot mode"
        Me.gridRobotMode.Location = New System.Drawing.Point(3, 3)
        Me.gridRobotMode.Name = "gridRobotMode"
        Me.gridRobotMode.Size = New System.Drawing.Size(293, 266)
        Me.gridRobotMode.TabIndex = 1
        '
        'gridCartesian
        '
        Me.gridCartesian.LabelText = "Cartesian"
        Me.gridCartesian.Location = New System.Drawing.Point(3, 275)
        Me.gridCartesian.Name = "gridCartesian"
        Me.gridCartesian.Size = New System.Drawing.Size(293, 341)
        Me.gridCartesian.TabIndex = 2
        '
        'gridForce
        '
        Me.gridForce.LabelText = "Force mode"
        Me.gridForce.Location = New System.Drawing.Point(3, 622)
        Me.gridForce.Name = "gridForce"
        Me.gridForce.Size = New System.Drawing.Size(293, 201)
        Me.gridForce.TabIndex = 1
        '
        'gridTool
        '
        Me.gridTool.LabelText = "Tool"
        Me.gridTool.Location = New System.Drawing.Point(302, 3)
        Me.gridTool.Name = "gridTool"
        Me.gridTool.Size = New System.Drawing.Size(293, 266)
        Me.gridTool.TabIndex = 1
        '
        'gridToolModeInfo
        '
        Me.gridToolModeInfo.LabelText = "Tool mode Info"
        Me.gridToolModeInfo.Location = New System.Drawing.Point(302, 275)
        Me.gridToolModeInfo.Name = "gridToolModeInfo"
        Me.gridToolModeInfo.Size = New System.Drawing.Size(293, 141)
        Me.gridToolModeInfo.TabIndex = 6
        '
        'GridToolCommunication
        '
        Me.GridToolCommunication.LabelText = "Tool Communication Info"
        Me.GridToolCommunication.Location = New System.Drawing.Point(302, 422)
        Me.GridToolCommunication.Name = "GridToolCommunication"
        Me.GridToolCommunication.Size = New System.Drawing.Size(293, 194)
        Me.GridToolCommunication.TabIndex = 7
        '
        'gridAdditionnalInfo
        '
        Me.gridAdditionnalInfo.LabelText = "Additionnal info"
        Me.gridAdditionnalInfo.Location = New System.Drawing.Point(302, 622)
        Me.gridAdditionnalInfo.Name = "gridAdditionnalInfo"
        Me.gridAdditionnalInfo.Size = New System.Drawing.Size(293, 201)
        Me.gridAdditionnalInfo.TabIndex = 4
        '
        'gridMasterboard
        '
        Me.gridMasterboard.LabelText = "Masterboard"
        Me.gridMasterboard.Location = New System.Drawing.Point(601, 3)
        Me.gridMasterboard.Name = "gridMasterboard"
        Me.gridMasterboard.Size = New System.Drawing.Size(293, 820)
        Me.gridMasterboard.TabIndex = 3
        '
        'gridConfiguration
        '
        Me.gridConfiguration.LabelText = "Configuration"
        Me.gridConfiguration.Location = New System.Drawing.Point(900, 3)
        Me.gridConfiguration.Name = "gridConfiguration"
        Me.gridConfiguration.Size = New System.Drawing.Size(294, 820)
        Me.gridConfiguration.TabIndex = 5
        '
        'gridJointData
        '
        Me.gridJointData.LabelText = "Joint"
        Me.gridJointData.Location = New System.Drawing.Point(1200, 3)
        Me.gridJointData.Name = "gridJointData"
        Me.gridJointData.Size = New System.Drawing.Size(293, 820)
        Me.gridJointData.TabIndex = 8
        '
        'gridKinematicsData
        '
        Me.gridKinematicsData.LabelText = "Kinematics"
        Me.gridKinematicsData.Location = New System.Drawing.Point(1499, 3)
        Me.gridKinematicsData.Name = "gridKinematicsData"
        Me.gridKinematicsData.Size = New System.Drawing.Size(293, 820)
        Me.gridKinematicsData.TabIndex = 9
        '
        'licGrid
        '
        Me.licGrid.LabelText = "License info"
        Me.licGrid.Location = New System.Drawing.Point(902, 3)
        Me.licGrid.Name = "licGrid"
        Me.licGrid.Size = New System.Drawing.Size(272, 120)
        Me.licGrid.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1610, 1061)
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Universal Robots Communication SDK - UnderAutomation (Sample)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.mainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tabCommands.ResumeLayout(False)
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
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.udXmlRpcPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.udRz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udRy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udRx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tsFolder.ResumeLayout(False)
        Me.tsFolder.PerformLayout()
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
    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabCommands As TabPage
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents radioRPYToRotationVector As RadioButton
    Friend WithEvents txtRz As TextBox
    Friend WithEvents txtRy As TextBox
    Friend WithEvents txtRx As TextBox
    Friend WithEvents udRz As NumericUpDown
    Friend WithEvents udRy As NumericUpDown
    Friend WithEvents udRx As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOut As Label
    Friend WithEvents txtIn As Label
    Friend WithEvents txtLocalIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtXmlRpcStatus As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDisableXmlRpcServer As Button
    Friend WithEvents btnEnableXmlRpcServer As Button
    Friend WithEvents udXmlRpcPort As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents linkXmlRpcSample As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtXmlRpcPort As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents blinkImg As ImageList
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSendShell As Button
    Friend WithEvents txtShellCommand As TextBox
    Friend WithEvents txtShellHistory As RichTextBox
    Friend WithEvents btnSSHSend As Button
    Friend WithEvents txtSSHCommand As TextBox
    Friend WithEvents gridSSHResult As PropertyGrid
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tsFolder As ToolStrip
    Friend WithEvents gridFile As PropertyGrid
    Friend WithEvents lstFolder As ListView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrevious As ToolStripButton
    Friend WithEvents txtPath As ToolStripTextBox
    Friend WithEvents btnOpenPath As ToolStripButton
    Friend WithEvents lstFolderImageList As ImageList
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnRename As ToolStripButton
    Friend WithEvents btnUpload As ToolStripButton
    Friend WithEvents btnDownload As ToolStripButton
    Friend WithEvents dlgOpen As OpenFileDialog
    Friend WithEvents dlgSave As SaveFileDialog
End Class

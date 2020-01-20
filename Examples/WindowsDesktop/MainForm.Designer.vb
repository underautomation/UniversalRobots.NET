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
        Me.linkDoc = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.pnl.SuspendLayout()
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
        Me.txtScript.Text = "movej([0,1.57,-1.57,3.14,-1.57,1.57],a=1.4, v=1.05, t=0, r=0)"
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
        Me.pnl.Location = New System.Drawing.Point(0, 143)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1610, 852)
        Me.pnl.TabIndex = 7
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
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1610, 995)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Universal Robots API example - UnderAutomation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl.ResumeLayout(False)
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
End Class

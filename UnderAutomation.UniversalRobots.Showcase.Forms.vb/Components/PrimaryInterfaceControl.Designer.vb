
Partial Class PrimaryInterfaceControl
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
        pnl = New Windows.Forms.FlowLayoutPanel()
        gridCartesian = New PrimaryInterfacePackageControl()
        gridForce = New PrimaryInterfacePackageControl()
        GridToolCommunication = New PrimaryInterfacePackageControl()
        gridTool = New PrimaryInterfacePackageControl()
        gridToolModeInfo = New PrimaryInterfacePackageControl()
        gridRobotMode = New PrimaryInterfacePackageControl()
        gridAdditionnalInfo = New PrimaryInterfacePackageControl()
        gridVersion = New PrimaryInterfacePackageControl()
        gridKeyMessage = New PrimaryInterfacePackageControl()
        gridPopupMessage = New PrimaryInterfacePackageControl()
        gridTextMessage = New PrimaryInterfacePackageControl()
        gridRuntimeExceptionMessage = New PrimaryInterfacePackageControl()
        panel1 = New Windows.Forms.Panel()
        btnSendScript = New Windows.Forms.Button()
        txtScript = New Windows.Forms.TextBox()
        label2 = New Windows.Forms.Label()
        label1 = New Windows.Forms.Label()
        panel2 = New Windows.Forms.Panel()
        panel6 = New Windows.Forms.Panel()
        gridJointData = New PrimaryInterfacePackageControl()
        panel4 = New Windows.Forms.Panel()
        gridKinematicsData = New PrimaryInterfacePackageControl()
        panel5 = New Windows.Forms.Panel()
        gridConfiguration = New PrimaryInterfacePackageControl()
        panel3 = New Windows.Forms.Panel()
        gridMasterboard = New PrimaryInterfacePackageControl()
        pnl.SuspendLayout()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        panel6.SuspendLayout()
        panel4.SuspendLayout()
        panel5.SuspendLayout()
        panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl
        ' 
        pnl.AutoScroll = True
        pnl.AutoSize = True
        pnl.Controls.Add(gridCartesian)
        pnl.Controls.Add(gridForce)
        pnl.Controls.Add(GridToolCommunication)
        pnl.Controls.Add(gridTool)
        pnl.Controls.Add(gridToolModeInfo)
        pnl.Controls.Add(gridRobotMode)
        pnl.Controls.Add(gridAdditionnalInfo)
        pnl.Controls.Add(gridVersion)
        pnl.Controls.Add(gridKeyMessage)
        pnl.Controls.Add(gridPopupMessage)
        pnl.Controls.Add(gridTextMessage)
        pnl.Controls.Add(gridRuntimeExceptionMessage)
        pnl.Dock = Windows.Forms.DockStyle.Left
        pnl.FlowDirection = Windows.Forms.FlowDirection.TopDown
        pnl.Location = New Drawing.Point(0, 76)
        pnl.Name = "pnl"
        pnl.Size = New Drawing.Size(1030, 477)
        pnl.TabIndex = 1
        ' 
        ' gridCartesian
        ' 
        gridCartesian.BackColor = Drawing.SystemColors.Window
        gridCartesian.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridCartesian.LabelText = "Cartesian info"
        gridCartesian.Location = New Drawing.Point(3, 3)
        gridCartesian.Name = "gridCartesian"
        gridCartesian.Size = New Drawing.Size(200, 225)
        gridCartesian.TabIndex = 0
        ' 
        ' gridForce
        ' 
        gridForce.BackColor = Drawing.SystemColors.Window
        gridForce.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridForce.LabelText = "Force data"
        gridForce.Location = New Drawing.Point(3, 234)
        gridForce.Name = "gridForce"
        gridForce.Size = New Drawing.Size(200, 149)
        gridForce.TabIndex = 0
        ' 
        ' GridToolCommunication
        ' 
        GridToolCommunication.BackColor = Drawing.SystemColors.Window
        GridToolCommunication.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        GridToolCommunication.LabelText = "Tool com."
        GridToolCommunication.Location = New Drawing.Point(209, 3)
        GridToolCommunication.Name = "GridToolCommunication"
        GridToolCommunication.Size = New Drawing.Size(200, 124)
        GridToolCommunication.TabIndex = 2
        ' 
        ' gridTool
        ' 
        gridTool.BackColor = Drawing.SystemColors.Window
        gridTool.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridTool.LabelText = "Tool data"
        gridTool.Location = New Drawing.Point(209, 133)
        gridTool.Name = "gridTool"
        gridTool.Size = New Drawing.Size(200, 162)
        gridTool.TabIndex = 3
        ' 
        ' gridToolModeInfo
        ' 
        gridToolModeInfo.BackColor = Drawing.SystemColors.Window
        gridToolModeInfo.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridToolModeInfo.LabelText = "Tool mode"
        gridToolModeInfo.Location = New Drawing.Point(209, 301)
        gridToolModeInfo.Name = "gridToolModeInfo"
        gridToolModeInfo.Size = New Drawing.Size(200, 90)
        gridToolModeInfo.TabIndex = 4
        ' 
        ' gridRobotMode
        ' 
        gridRobotMode.BackColor = Drawing.SystemColors.Window
        gridRobotMode.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridRobotMode.LabelText = "Robot mode"
        gridRobotMode.Location = New Drawing.Point(415, 3)
        gridRobotMode.Name = "gridRobotMode"
        gridRobotMode.Size = New Drawing.Size(200, 265)
        gridRobotMode.TabIndex = 12
        ' 
        ' gridAdditionnalInfo
        ' 
        gridAdditionnalInfo.BackColor = Drawing.SystemColors.Window
        gridAdditionnalInfo.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridAdditionnalInfo.LabelText = "Additionnal info"
        gridAdditionnalInfo.Location = New Drawing.Point(415, 274)
        gridAdditionnalInfo.Name = "gridAdditionnalInfo"
        gridAdditionnalInfo.Size = New Drawing.Size(200, 91)
        gridAdditionnalInfo.TabIndex = 0
        ' 
        ' gridVersion
        ' 
        gridVersion.BackColor = Drawing.SystemColors.Window
        gridVersion.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridVersion.LabelText = "Version"
        gridVersion.Location = New Drawing.Point(621, 3)
        gridVersion.Name = "gridVersion"
        gridVersion.Size = New Drawing.Size(200, 156)
        gridVersion.TabIndex = 5
        ' 
        ' gridKeyMessage
        ' 
        gridKeyMessage.BackColor = Drawing.SystemColors.Window
        gridKeyMessage.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridKeyMessage.LabelText = "Key message"
        gridKeyMessage.Location = New Drawing.Point(621, 165)
        gridKeyMessage.Name = "gridKeyMessage"
        gridKeyMessage.Size = New Drawing.Size(200, 107)
        gridKeyMessage.TabIndex = 7
        ' 
        ' gridPopupMessage
        ' 
        gridPopupMessage.BackColor = Drawing.SystemColors.Window
        gridPopupMessage.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridPopupMessage.LabelText = "Popup message"
        gridPopupMessage.Location = New Drawing.Point(621, 278)
        gridPopupMessage.Name = "gridPopupMessage"
        gridPopupMessage.Size = New Drawing.Size(200, 152)
        gridPopupMessage.TabIndex = 8
        ' 
        ' gridTextMessage
        ' 
        gridTextMessage.BackColor = Drawing.SystemColors.Window
        gridTextMessage.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridTextMessage.LabelText = "Text message"
        gridTextMessage.Location = New Drawing.Point(827, 3)
        gridTextMessage.Name = "gridTextMessage"
        gridTextMessage.Size = New Drawing.Size(200, 60)
        gridTextMessage.TabIndex = 10
        ' 
        ' gridRuntimeExceptionMessage
        ' 
        gridRuntimeExceptionMessage.BackColor = Drawing.SystemColors.Window
        gridRuntimeExceptionMessage.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridRuntimeExceptionMessage.LabelText = "Runtime exception"
        gridRuntimeExceptionMessage.Location = New Drawing.Point(827, 69)
        gridRuntimeExceptionMessage.Name = "gridRuntimeExceptionMessage"
        gridRuntimeExceptionMessage.Size = New Drawing.Size(200, 75)
        gridRuntimeExceptionMessage.TabIndex = 11
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(btnSendScript)
        panel1.Controls.Add(txtScript)
        panel1.Controls.Add(label2)
        panel1.Controls.Add(label1)
        panel1.Dock = Windows.Forms.DockStyle.Top
        panel1.Location = New Drawing.Point(0, 0)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(2249, 76)
        panel1.TabIndex = 2
        ' 
        ' btnSendScript
        ' 
        btnSendScript.Location = New Drawing.Point(578, 14)
        btnSendScript.Name = "btnSendScript"
        btnSendScript.Size = New Drawing.Size(87, 23)
        btnSendScript.TabIndex = 2
        btnSendScript.Text = "Execute"
        btnSendScript.UseVisualStyleBackColor = True
        AddHandler btnSendScript.Click, New EventHandler(AddressOf btnSendScript_Click)
        ' 
        ' txtScript
        ' 
        txtScript.Location = New Drawing.Point(6, 16)
        txtScript.Multiline = True
        txtScript.Name = "txtScript"
        txtScript.Size = New Drawing.Size(566, 41)
        txtScript.TabIndex = 1
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label2.Location = New Drawing.Point(3, 60)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(131, 13)
        label2.TabIndex = 0
        label2.Text = "Robot status data (10Hz) :"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
        label1.Location = New Drawing.Point(3, 0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(84, 13)
        label1.TabIndex = 0
        label1.Text = "Send URScript :"
        ' 
        ' panel2
        ' 
        panel2.Controls.Add(panel6)
        panel2.Controls.Add(panel4)
        panel2.Controls.Add(panel5)
        panel2.Controls.Add(panel3)
        panel2.Dock = Windows.Forms.DockStyle.Left
        panel2.Location = New Drawing.Point(1030, 76)
        panel2.Name = "panel2"
        panel2.Size = New Drawing.Size(1219, 477)
        panel2.TabIndex = 3
        ' 
        ' panel6
        ' 
        panel6.Controls.Add(gridJointData)
        panel6.Dock = Windows.Forms.DockStyle.Left
        panel6.Location = New Drawing.Point(900, 0)
        panel6.Name = "panel6"
        panel6.Padding = New Windows.Forms.Padding(3)
        panel6.Size = New Drawing.Size(300, 477)
        panel6.TabIndex = 4
        ' 
        ' gridJointData
        ' 
        gridJointData.BackColor = Drawing.SystemColors.Window
        gridJointData.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridJointData.Dock = Windows.Forms.DockStyle.Fill
        gridJointData.LabelText = "Joint data"
        gridJointData.Location = New Drawing.Point(3, 3)
        gridJointData.Name = "gridJointData"
        gridJointData.Size = New Drawing.Size(294, 471)
        gridJointData.TabIndex = 1
        ' 
        ' panel4
        ' 
        panel4.Controls.Add(gridKinematicsData)
        panel4.Dock = Windows.Forms.DockStyle.Left
        panel4.Location = New Drawing.Point(600, 0)
        panel4.Name = "panel4"
        panel4.Padding = New Windows.Forms.Padding(3)
        panel4.Size = New Drawing.Size(300, 477)
        panel4.TabIndex = 5
        ' 
        ' gridKinematicsData
        ' 
        gridKinematicsData.BackColor = Drawing.SystemColors.Window
        gridKinematicsData.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridKinematicsData.Dock = Windows.Forms.DockStyle.Fill
        gridKinematicsData.LabelText = "Kinematics"
        gridKinematicsData.Location = New Drawing.Point(3, 3)
        gridKinematicsData.Margin = New Windows.Forms.Padding(0)
        gridKinematicsData.Name = "gridKinematicsData"
        gridKinematicsData.Size = New Drawing.Size(294, 471)
        gridKinematicsData.TabIndex = 6
        ' 
        ' panel5
        ' 
        panel5.Controls.Add(gridConfiguration)
        panel5.Dock = Windows.Forms.DockStyle.Left
        panel5.Location = New Drawing.Point(300, 0)
        panel5.Name = "panel5"
        panel5.Padding = New Windows.Forms.Padding(3)
        panel5.Size = New Drawing.Size(300, 477)
        panel5.TabIndex = 4
        ' 
        ' gridConfiguration
        ' 
        gridConfiguration.BackColor = Drawing.SystemColors.Window
        gridConfiguration.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridConfiguration.Dock = Windows.Forms.DockStyle.Fill
        gridConfiguration.LabelText = "Configuration"
        gridConfiguration.Location = New Drawing.Point(3, 3)
        gridConfiguration.Margin = New Windows.Forms.Padding(0)
        gridConfiguration.Name = "gridConfiguration"
        gridConfiguration.Size = New Drawing.Size(294, 471)
        gridConfiguration.TabIndex = 7
        ' 
        ' panel3
        ' 
        panel3.Controls.Add(gridMasterboard)
        panel3.Dock = Windows.Forms.DockStyle.Left
        panel3.Location = New Drawing.Point(0, 0)
        panel3.Name = "panel3"
        panel3.Padding = New Windows.Forms.Padding(3)
        panel3.Size = New Drawing.Size(300, 477)
        panel3.TabIndex = 4
        ' 
        ' gridMasterboard
        ' 
        gridMasterboard.BackColor = Drawing.SystemColors.Window
        gridMasterboard.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        gridMasterboard.Dock = Windows.Forms.DockStyle.Fill
        gridMasterboard.LabelText = "Masterboard"
        gridMasterboard.Location = New Drawing.Point(3, 3)
        gridMasterboard.Name = "gridMasterboard"
        gridMasterboard.Size = New Drawing.Size(294, 471)
        gridMasterboard.TabIndex = 8
        ' 
        ' PrimaryInterfaceControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(panel2)
        Controls.Add(pnl)
        Controls.Add(panel1)
        Name = "PrimaryInterfaceControl"
        Size = New Drawing.Size(1927, 553)
        pnl.ResumeLayout(False)
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        panel2.ResumeLayout(False)
        panel6.ResumeLayout(False)
        panel4.ResumeLayout(False)
        panel5.ResumeLayout(False)
        panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Private gridAdditionnalInfo As PrimaryInterfacePackageControl
    Private pnl As Windows.Forms.FlowLayoutPanel
    Private gridCartesian As PrimaryInterfacePackageControl
    Private gridForce As PrimaryInterfacePackageControl
    Private GridToolCommunication As PrimaryInterfacePackageControl
    Private gridTool As PrimaryInterfacePackageControl
    Private gridToolModeInfo As PrimaryInterfacePackageControl
    Private panel1 As Windows.Forms.Panel
    Private btnSendScript As Windows.Forms.Button
    Private txtScript As Windows.Forms.TextBox
    Private label2 As Windows.Forms.Label
    Private label1 As Windows.Forms.Label
    Private panel2 As Windows.Forms.Panel
    Private panel6 As Windows.Forms.Panel
    Private gridJointData As PrimaryInterfacePackageControl
    Private panel4 As Windows.Forms.Panel
    Private gridKinematicsData As PrimaryInterfacePackageControl
    Private panel5 As Windows.Forms.Panel
    Private gridConfiguration As PrimaryInterfacePackageControl
    Private panel3 As Windows.Forms.Panel
    Private gridMasterboard As PrimaryInterfacePackageControl
    Private gridVersion As PrimaryInterfacePackageControl
    Private gridKeyMessage As PrimaryInterfacePackageControl
    Private gridPopupMessage As PrimaryInterfacePackageControl
    Private gridTextMessage As PrimaryInterfacePackageControl
    Private gridRuntimeExceptionMessage As PrimaryInterfacePackageControl
    Private gridRobotMode As PrimaryInterfacePackageControl
End Class

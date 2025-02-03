
Partial Class ConnectControl
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
        label1 = New Windows.Forms.Label()
        txtIP = New Windows.Forms.TextBox()
        chkPrimaryInterface = New Windows.Forms.CheckBox()
        chkSftp = New Windows.Forms.CheckBox()
        chkSsh = New Windows.Forms.CheckBox()
        label2 = New Windows.Forms.Label()
        txtUsername = New Windows.Forms.TextBox()
        label3 = New Windows.Forms.Label()
        txtPassword = New Windows.Forms.TextBox()
        btnConnect = New Windows.Forms.Button()
        btnDisconnect = New Windows.Forms.Button()
        chkXmlRpc = New Windows.Forms.CheckBox()
        label4 = New Windows.Forms.Label()
        udXmlRpcPort = New Windows.Forms.NumericUpDown()
        lblConnected = New Windows.Forms.Label()
        chkSocket = New Windows.Forms.CheckBox()
        label5 = New Windows.Forms.Label()
        udSocketPort = New Windows.Forms.NumericUpDown()
        chkRTDE = New Windows.Forms.CheckBox()
        btnRtdeOutputs = New Windows.Forms.Button()
        lblFrequency = New Windows.Forms.Label()
        udFrequency = New Windows.Forms.NumericUpDown()
        lnkMaxFrequency = New Windows.Forms.LinkLabel()
        btnRtdeInputs = New Windows.Forms.Button()
        lblRtdeOutputs = New Windows.Forms.Label()
        lblRtdeInputs = New Windows.Forms.Label()
        chkDashboard = New Windows.Forms.CheckBox()
        tableLayoutPanel1 = New Windows.Forms.TableLayoutPanel()
        chkInterpreterMode = New Windows.Forms.CheckBox()
        flowLayoutPanel2 = New Windows.Forms.FlowLayoutPanel()
        radioV1 = New Windows.Forms.RadioButton()
        radioV2 = New Windows.Forms.RadioButton()
        flowLayoutPanel1 = New Windows.Forms.FlowLayoutPanel()
        lblHz = New Windows.Forms.Label()
        panel1 = New Windows.Forms.Panel()
        label6 = New Windows.Forms.Label()
        label7 = New Windows.Forms.Label()
        CType(udXmlRpcPort, ComponentModel.ISupportInitialize).BeginInit()
        CType(udSocketPort, ComponentModel.ISupportInitialize).BeginInit()
        CType(udFrequency, ComponentModel.ISupportInitialize).BeginInit()
        tableLayoutPanel1.SuspendLayout()
        flowLayoutPanel2.SuspendLayout()
        flowLayoutPanel1.SuspendLayout()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.Anchor = Windows.Forms.AnchorStyles.Right
        label1.AutoSize = True
        label1.Location = New Drawing.Point(17, 6)
        label1.Margin = New Windows.Forms.Padding(0)
        label1.Name = "label1"
        label1.Size = New Drawing.Size(63, 13)
        label1.TabIndex = 0
        label1.Text = "IP address :"
        ' 
        ' txtIP
        ' 
        txtIP.Anchor = Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        txtIP.Location = New Drawing.Point(83, 3)
        txtIP.Name = "txtIP"
        txtIP.Size = New Drawing.Size(194, 20)
        txtIP.TabIndex = 1
        txtIP.Text = "192.168.0.1"
        AddHandler txtIP.KeyDown, New Windows.Forms.KeyEventHandler(AddressOf btnConnect_Click)
        ' 
        ' chkPrimaryInterface
        ' 
        chkPrimaryInterface.Anchor = Windows.Forms.AnchorStyles.Left
        chkPrimaryInterface.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkPrimaryInterface, 2)
        chkPrimaryInterface.Location = New Drawing.Point(83, 44)
        chkPrimaryInterface.Name = "chkPrimaryInterface"
        chkPrimaryInterface.Size = New Drawing.Size(268, 17)
        chkPrimaryInterface.TabIndex = 2
        chkPrimaryInterface.Text = "Enable Primary Interface (data streaming and script)"
        chkPrimaryInterface.UseVisualStyleBackColor = True
        ' 
        ' chkSftp
        ' 
        chkSftp.Anchor = Windows.Forms.AnchorStyles.Left
        chkSftp.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkSftp, 2)
        chkSftp.Location = New Drawing.Point(83, 295)
        chkSftp.Name = "chkSftp"
        chkSftp.Size = New Drawing.Size(154, 17)
        chkSftp.TabIndex = 8
        chkSftp.Text = "Enable file handling (SFTP)"
        chkSftp.UseVisualStyleBackColor = True
        ' 
        ' chkSsh
        ' 
        chkSsh.Anchor = Windows.Forms.AnchorStyles.Left
        chkSsh.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkSsh, 2)
        chkSsh.Location = New Drawing.Point(83, 320)
        chkSsh.Name = "chkSsh"
        chkSsh.Size = New Drawing.Size(172, 17)
        chkSsh.TabIndex = 9
        chkSsh.Text = "Enable Linux commands (SSH)"
        chkSsh.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.Anchor = Windows.Forms.AnchorStyles.Right
        label2.AutoSize = True
        label2.Location = New Drawing.Point(41, 347)
        label2.Margin = New Windows.Forms.Padding(0)
        label2.Name = "label2"
        label2.Size = New Drawing.Size(39, 13)
        label2.TabIndex = 0
        label2.Text = "Login :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = Windows.Forms.AnchorStyles.Left
        txtUsername.Location = New Drawing.Point(83, 344)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Drawing.Size(80, 20)
        txtUsername.TabIndex = 10
        txtUsername.Text = "ur"
        ' 
        ' label3
        ' 
        label3.Anchor = Windows.Forms.AnchorStyles.Right
        label3.AutoSize = True
        label3.Location = New Drawing.Point(21, 372)
        label3.Margin = New Windows.Forms.Padding(0)
        label3.Name = "label3"
        label3.Size = New Drawing.Size(59, 13)
        label3.TabIndex = 0
        label3.Text = "Password :"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = Windows.Forms.AnchorStyles.Left
        txtPassword.Location = New Drawing.Point(83, 369)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Drawing.Size(80, 20)
        txtPassword.TabIndex = 11
        txtPassword.Text = "easybot"
        ' 
        ' btnConnect
        ' 
        btnConnect.Dock = Windows.Forms.DockStyle.Left
        btnConnect.Location = New Drawing.Point(0, 0)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Drawing.Size(96, 29)
        btnConnect.TabIndex = 17
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = True
        AddHandler btnConnect.Click, New EventHandler(AddressOf btnConnect_Click)
        ' 
        ' btnDisconnect
        ' 
        btnDisconnect.Dock = Windows.Forms.DockStyle.Right
        btnDisconnect.Location = New Drawing.Point(102, 0)
        btnDisconnect.Name = "btnDisconnect"
        btnDisconnect.Size = New Drawing.Size(92, 29)
        btnDisconnect.TabIndex = 18
        btnDisconnect.Text = "Disconnect"
        btnDisconnect.UseVisualStyleBackColor = True
        AddHandler btnDisconnect.Click, New EventHandler(AddressOf btnDisconnect_Click)
        ' 
        ' chkXmlRpc
        ' 
        chkXmlRpc.Anchor = Windows.Forms.AnchorStyles.Left
        chkXmlRpc.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkXmlRpc, 2)
        chkXmlRpc.Location = New Drawing.Point(83, 230)
        chkXmlRpc.Name = "chkXmlRpc"
        chkXmlRpc.Size = New Drawing.Size(227, 17)
        chkXmlRpc.TabIndex = 6
        chkXmlRpc.Text = "Enable Remote Procedure Call (XML-RPC)"
        chkXmlRpc.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.Anchor = Windows.Forms.AnchorStyles.Right
        label4.AutoSize = True
        label4.Location = New Drawing.Point(20, 257)
        label4.Margin = New Windows.Forms.Padding(0)
        label4.Name = "label4"
        label4.Size = New Drawing.Size(60, 13)
        label4.TabIndex = 0
        label4.Text = "Local port :"
        ' 
        ' udXmlRpcPort
        ' 
        udXmlRpcPort.Anchor = Windows.Forms.AnchorStyles.Left
        udXmlRpcPort.Location = New Drawing.Point(83, 254)
        udXmlRpcPort.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        udXmlRpcPort.Name = "udXmlRpcPort"
        udXmlRpcPort.Size = New Drawing.Size(80, 20)
        udXmlRpcPort.TabIndex = 7
        ' 
        ' lblConnected
        ' 
        lblConnected.Dock = Windows.Forms.DockStyle.Fill
        lblConnected.Location = New Drawing.Point(83, 611)
        lblConnected.Name = "lblConnected"
        lblConnected.Size = New Drawing.Size(194, 25)
        lblConnected.TabIndex = 19
        lblConnected.Text = "______"
        lblConnected.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' chkSocket
        ' 
        chkSocket.Anchor = Windows.Forms.AnchorStyles.Left
        chkSocket.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkSocket, 2)
        chkSocket.Location = New Drawing.Point(83, 165)
        chkSocket.Name = "chkSocket"
        chkSocket.Size = New Drawing.Size(200, 17)
        chkSocket.TabIndex = 4
        chkSocket.Text = "Enable socket communication server"
        chkSocket.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.Anchor = Windows.Forms.AnchorStyles.Right
        label5.AutoSize = True
        label5.Location = New Drawing.Point(20, 192)
        label5.Margin = New Windows.Forms.Padding(0)
        label5.Name = "label5"
        label5.Size = New Drawing.Size(60, 13)
        label5.TabIndex = 0
        label5.Text = "Local port :"
        ' 
        ' udSocketPort
        ' 
        udSocketPort.Anchor = Windows.Forms.AnchorStyles.Left
        udSocketPort.Location = New Drawing.Point(83, 189)
        udSocketPort.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        udSocketPort.Name = "udSocketPort"
        udSocketPort.Size = New Drawing.Size(80, 20)
        udSocketPort.TabIndex = 5
        ' 
        ' chkRTDE
        ' 
        chkRTDE.Anchor = Windows.Forms.AnchorStyles.Left
        chkRTDE.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkRTDE, 2)
        chkRTDE.Location = New Drawing.Point(83, 410)
        chkRTDE.Name = "chkRTDE"
        chkRTDE.Size = New Drawing.Size(222, 17)
        chkRTDE.TabIndex = 12
        chkRTDE.Text = "Enable Real-time Data Exchange (RTDE)"
        chkRTDE.UseVisualStyleBackColor = True
        ' 
        ' btnRtdeOutputs
        ' 
        btnRtdeOutputs.Dock = Windows.Forms.DockStyle.Fill
        btnRtdeOutputs.Location = New Drawing.Point(83, 484)
        btnRtdeOutputs.Name = "btnRtdeOutputs"
        btnRtdeOutputs.Size = New Drawing.Size(194, 29)
        btnRtdeOutputs.TabIndex = 15
        btnRtdeOutputs.Text = "Select incoming outputs data..."
        btnRtdeOutputs.UseVisualStyleBackColor = True
        AddHandler btnRtdeOutputs.Click, New EventHandler(AddressOf btnRtdeOutputs_Click)
        ' 
        ' lblFrequency
        ' 
        lblFrequency.Anchor = Windows.Forms.AnchorStyles.Right
        lblFrequency.AutoSize = True
        lblFrequency.Location = New Drawing.Point(17, 462)
        lblFrequency.Margin = New Windows.Forms.Padding(0)
        lblFrequency.Name = "lblFrequency"
        lblFrequency.Size = New Drawing.Size(63, 13)
        lblFrequency.TabIndex = 0
        lblFrequency.Text = "Frequency :"
        ' 
        ' udFrequency
        ' 
        udFrequency.Location = New Drawing.Point(3, 3)
        udFrequency.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        udFrequency.Name = "udFrequency"
        udFrequency.Size = New Drawing.Size(80, 20)
        udFrequency.TabIndex = 13
        ' 
        ' lnkMaxFrequency
        ' 
        lnkMaxFrequency.Anchor = Windows.Forms.AnchorStyles.None
        lnkMaxFrequency.AutoSize = True
        lnkMaxFrequency.Location = New Drawing.Point(115, 6)
        lnkMaxFrequency.Name = "lnkMaxFrequency"
        lnkMaxFrequency.Size = New Drawing.Size(125, 13)
        lnkMaxFrequency.TabIndex = 14
        lnkMaxFrequency.TabStop = True
        lnkMaxFrequency.Text = "(Set 0 for max frequency)"
        AddHandler lnkMaxFrequency.LinkClicked, New Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf lnkMaxFrequency_LinkClicked)
        ' 
        ' btnRtdeInputs
        ' 
        btnRtdeInputs.Dock = Windows.Forms.DockStyle.Fill
        btnRtdeInputs.Location = New Drawing.Point(83, 519)
        btnRtdeInputs.Name = "btnRtdeInputs"
        btnRtdeInputs.Size = New Drawing.Size(194, 29)
        btnRtdeInputs.TabIndex = 16
        btnRtdeInputs.Text = "Select outgoing inputs data..."
        btnRtdeInputs.UseVisualStyleBackColor = True
        AddHandler btnRtdeInputs.Click, New EventHandler(AddressOf btnRtdeInputs_Click)
        ' 
        ' lblRtdeOutputs
        ' 
        lblRtdeOutputs.Anchor = Windows.Forms.AnchorStyles.Left
        lblRtdeOutputs.AutoSize = True
        lblRtdeOutputs.Location = New Drawing.Point(283, 492)
        lblRtdeOutputs.Name = "lblRtdeOutputs"
        lblRtdeOutputs.Size = New Drawing.Size(16, 13)
        lblRtdeOutputs.TabIndex = 0
        lblRtdeOutputs.Text = "..."
        ' 
        ' lblRtdeInputs
        ' 
        lblRtdeInputs.Anchor = Windows.Forms.AnchorStyles.Left
        lblRtdeInputs.AutoSize = True
        lblRtdeInputs.Location = New Drawing.Point(283, 527)
        lblRtdeInputs.Name = "lblRtdeInputs"
        lblRtdeInputs.Size = New Drawing.Size(16, 13)
        lblRtdeInputs.TabIndex = 0
        lblRtdeInputs.Text = "..."
        ' 
        ' chkDashboard
        ' 
        chkDashboard.Anchor = Windows.Forms.AnchorStyles.Left
        chkDashboard.AutoSize = True
        tableLayoutPanel1.SetColumnSpan(chkDashboard, 2)
        chkDashboard.Location = New Drawing.Point(83, 85)
        chkDashboard.Name = "chkDashboard"
        chkDashboard.Size = New Drawing.Size(140, 17)
        chkDashboard.TabIndex = 3
        chkDashboard.Text = "Enable dashboard client"
        chkDashboard.UseVisualStyleBackColor = True
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.ColumnCount = 3
        tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Absolute, 80F))
        tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Absolute, 200F))
        tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle())
        tableLayoutPanel1.Controls.Add(chkInterpreterMode, 1, 6)
        tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 20)
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 21)
        tableLayoutPanel1.Controls.Add(lblConnected, 1, 26)
        tableLayoutPanel1.Controls.Add(label1, 0, 0)
        tableLayoutPanel1.Controls.Add(txtIP, 1, 0)
        tableLayoutPanel1.Controls.Add(udSocketPort, 1, 9)
        tableLayoutPanel1.Controls.Add(label5, 0, 9)
        tableLayoutPanel1.Controls.Add(chkPrimaryInterface, 1, 2)
        tableLayoutPanel1.Controls.Add(chkDashboard, 1, 4)
        tableLayoutPanel1.Controls.Add(udXmlRpcPort, 1, 12)
        tableLayoutPanel1.Controls.Add(txtUsername, 1, 16)
        tableLayoutPanel1.Controls.Add(chkSocket, 1, 8)
        tableLayoutPanel1.Controls.Add(chkXmlRpc, 1, 11)
        tableLayoutPanel1.Controls.Add(label4, 0, 12)
        tableLayoutPanel1.Controls.Add(txtPassword, 1, 17)
        tableLayoutPanel1.Controls.Add(chkSsh, 1, 15)
        tableLayoutPanel1.Controls.Add(chkSftp, 1, 14)
        tableLayoutPanel1.Controls.Add(label2, 0, 16)
        tableLayoutPanel1.Controls.Add(label3, 0, 17)
        tableLayoutPanel1.Controls.Add(btnRtdeInputs, 1, 23)
        tableLayoutPanel1.Controls.Add(btnRtdeOutputs, 1, 22)
        tableLayoutPanel1.Controls.Add(lblRtdeInputs, 2, 23)
        tableLayoutPanel1.Controls.Add(lblRtdeOutputs, 2, 22)
        tableLayoutPanel1.Controls.Add(lblFrequency, 0, 21)
        tableLayoutPanel1.Controls.Add(panel1, 1, 25)
        tableLayoutPanel1.Controls.Add(chkRTDE, 1, 19)
        tableLayoutPanel1.Controls.Add(label6, 2, 16)
        tableLayoutPanel1.Controls.Add(label7, 2, 17)
        tableLayoutPanel1.Location = New Drawing.Point(3, 3)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 28
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 16F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 15F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 35F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 35F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 35F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Absolute, 25F))
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle())
        tableLayoutPanel1.Size = New Drawing.Size(538, 669)
        tableLayoutPanel1.TabIndex = 9
        ' 
        ' chkInterpreterMode
        ' 
        chkInterpreterMode.Anchor = Windows.Forms.AnchorStyles.Left
        chkInterpreterMode.AutoSize = True
        chkInterpreterMode.Location = New Drawing.Point(83, 125)
        chkInterpreterMode.Name = "chkInterpreterMode"
        chkInterpreterMode.Size = New Drawing.Size(138, 17)
        chkInterpreterMode.TabIndex = 10
        chkInterpreterMode.Text = "Enable interpreter mode"
        chkInterpreterMode.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel2
        ' 
        flowLayoutPanel2.Controls.Add(radioV1)
        flowLayoutPanel2.Controls.Add(radioV2)
        flowLayoutPanel2.Dock = Windows.Forms.DockStyle.Fill
        flowLayoutPanel2.Location = New Drawing.Point(80, 431)
        flowLayoutPanel2.Margin = New Windows.Forms.Padding(0)
        flowLayoutPanel2.Name = "flowLayoutPanel2"
        flowLayoutPanel2.Size = New Drawing.Size(200, 25)
        flowLayoutPanel2.TabIndex = 10
        ' 
        ' radioV1
        ' 
        radioV1.Anchor = Windows.Forms.AnchorStyles.Left
        radioV1.AutoSize = True
        radioV1.Location = New Drawing.Point(15, 3)
        radioV1.Margin = New Windows.Forms.Padding(15, 3, 3, 3)
        radioV1.Name = "radioV1"
        radioV1.Size = New Drawing.Size(69, 17)
        radioV1.TabIndex = 15
        radioV1.TabStop = True
        radioV1.Text = "Version 1"
        radioV1.UseVisualStyleBackColor = True
        AddHandler radioV1.CheckedChanged, New EventHandler(AddressOf radioV1_CheckedChanged)
        ' 
        ' radioV2
        ' 
        radioV2.Anchor = Windows.Forms.AnchorStyles.Left
        radioV2.AutoSize = True
        radioV2.Location = New Drawing.Point(90, 3)
        radioV2.Name = "radioV2"
        radioV2.Size = New Drawing.Size(69, 17)
        radioV2.TabIndex = 16
        radioV2.TabStop = True
        radioV2.Text = "Version 2"
        radioV2.UseVisualStyleBackColor = True
        ' 
        ' flowLayoutPanel1
        ' 
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2)
        flowLayoutPanel1.Controls.Add(udFrequency)
        flowLayoutPanel1.Controls.Add(lblHz)
        flowLayoutPanel1.Controls.Add(lnkMaxFrequency)
        flowLayoutPanel1.Dock = Windows.Forms.DockStyle.Fill
        flowLayoutPanel1.Location = New Drawing.Point(80, 456)
        flowLayoutPanel1.Margin = New Windows.Forms.Padding(0)
        flowLayoutPanel1.Name = "flowLayoutPanel1"
        flowLayoutPanel1.Size = New Drawing.Size(458, 25)
        flowLayoutPanel1.TabIndex = 11
        ' 
        ' lblHz
        ' 
        lblHz.Anchor = Windows.Forms.AnchorStyles.Right
        lblHz.AutoSize = True
        lblHz.Location = New Drawing.Point(89, 6)
        lblHz.Name = "lblHz"
        lblHz.Size = New Drawing.Size(20, 13)
        lblHz.TabIndex = 8
        lblHz.Text = "Hz"
        ' 
        ' panel1
        ' 
        panel1.Controls.Add(btnConnect)
        panel1.Controls.Add(btnDisconnect)
        panel1.Dock = Windows.Forms.DockStyle.Fill
        panel1.Location = New Drawing.Point(83, 579)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(194, 29)
        panel1.TabIndex = 12
        ' 
        ' label6
        ' 
        label6.Anchor = Windows.Forms.AnchorStyles.Left
        label6.AutoSize = True
        label6.Location = New Drawing.Point(280, 347)
        label6.Margin = New Windows.Forms.Padding(0)
        label6.Name = "label6"
        label6.Size = New Drawing.Size(219, 13)
        label6.TabIndex = 20
        label6.Text = "Default login : root (real robot)  / ur (simulator)"
        ' 
        ' label7
        ' 
        label7.Anchor = Windows.Forms.AnchorStyles.Left
        label7.AutoSize = True
        label7.Location = New Drawing.Point(280, 372)
        label7.Margin = New Windows.Forms.Padding(0)
        label7.Name = "label7"
        label7.Size = New Drawing.Size(135, 13)
        label7.TabIndex = 21
        label7.Text = "Default password : easybot"
        ' 
        ' ConnectControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(tableLayoutPanel1)
        Name = "ConnectControl"
        Size = New Drawing.Size(1225, 850)
        CType(udXmlRpcPort, ComponentModel.ISupportInitialize).EndInit()
        CType(udSocketPort, ComponentModel.ISupportInitialize).EndInit()
        CType(udFrequency, ComponentModel.ISupportInitialize).EndInit()
        tableLayoutPanel1.ResumeLayout(False)
        tableLayoutPanel1.PerformLayout()
        flowLayoutPanel2.ResumeLayout(False)
        flowLayoutPanel2.PerformLayout()
        flowLayoutPanel1.ResumeLayout(False)
        flowLayoutPanel1.PerformLayout()
        panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Private label1 As Windows.Forms.Label
    Private txtIP As Windows.Forms.TextBox
    Private chkPrimaryInterface As Windows.Forms.CheckBox
    Private chkSftp As Windows.Forms.CheckBox
    Private chkSsh As Windows.Forms.CheckBox
    Private label2 As Windows.Forms.Label
    Private txtUsername As Windows.Forms.TextBox
    Private label3 As Windows.Forms.Label
    Private txtPassword As Windows.Forms.TextBox
    Private btnConnect As Windows.Forms.Button
    Private btnDisconnect As Windows.Forms.Button
    Private chkXmlRpc As Windows.Forms.CheckBox
    Private label4 As Windows.Forms.Label
    Private udXmlRpcPort As Windows.Forms.NumericUpDown
    Private lblConnected As Windows.Forms.Label
    Private chkSocket As Windows.Forms.CheckBox
    Private label5 As Windows.Forms.Label
    Private udSocketPort As Windows.Forms.NumericUpDown
    Private chkRTDE As Windows.Forms.CheckBox
    Private btnRtdeOutputs As Windows.Forms.Button
    Private lblFrequency As Windows.Forms.Label
    Private udFrequency As Windows.Forms.NumericUpDown
    Private lnkMaxFrequency As Windows.Forms.LinkLabel
    Private btnRtdeInputs As Windows.Forms.Button
    Private lblRtdeOutputs As Windows.Forms.Label
    Private lblRtdeInputs As Windows.Forms.Label
    Private chkDashboard As Windows.Forms.CheckBox
    Private tableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Private flowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Private lblHz As Windows.Forms.Label
    Private panel1 As Windows.Forms.Panel
    Private radioV1 As Windows.Forms.RadioButton
    Private radioV2 As Windows.Forms.RadioButton
    Private flowLayoutPanel2 As Windows.Forms.FlowLayoutPanel
    Private chkInterpreterMode As Windows.Forms.CheckBox
    Private label6 As Windows.Forms.Label
    Private label7 As Windows.Forms.Label
End Class

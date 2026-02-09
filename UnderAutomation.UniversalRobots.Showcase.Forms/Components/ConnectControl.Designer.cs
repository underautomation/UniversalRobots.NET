
partial class ConnectControl
{
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtIP = new TextBox();
        chkPrimaryInterface = new CheckBox();
        chkSftp = new CheckBox();
        chkSsh = new CheckBox();
        label2 = new Label();
        cbUsername = new ComboBox();
        label3 = new Label();
        txtPassword = new TextBox();
        btnConnect = new Button();
        btnDisconnect = new Button();
        chkXmlRpc = new CheckBox();
        label4 = new Label();
        udXmlRpcPort = new NumericUpDown();
        lblConnected = new Label();
        chkSocket = new CheckBox();
        label5 = new Label();
        udSocketPort = new NumericUpDown();
        chkRTDE = new CheckBox();
        btnRtdeOutputs = new Button();
        lblFrequency = new Label();
        udFrequency = new NumericUpDown();
        lnkMaxFrequency = new LinkLabel();
        btnRtdeInputs = new Button();
        lblRtdeOutputs = new Label();
        lblRtdeInputs = new Label();
        chkDashboard = new CheckBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        chkInterpreterMode = new CheckBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        radioV1 = new RadioButton();
        radioV2 = new RadioButton();
        flowLayoutPanel1 = new FlowLayoutPanel();
        lblHz = new Label();
        panel1 = new Panel();
        label6 = new Label();
        label7 = new Label();
        chkRest = new CheckBox();
        lblLicense = new Label();
        ((System.ComponentModel.ISupportInitialize)udXmlRpcPort).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udSocketPort).BeginInit();
        ((System.ComponentModel.ISupportInitialize)udFrequency).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel2.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(27, 7);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(66, 15);
        label1.TabIndex = 0;
        label1.Text = "IP address :";
        // 
        // txtIP
        // 
        txtIP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtIP.Location = new Point(97, 3);
        txtIP.Margin = new Padding(4, 3, 4, 3);
        txtIP.Name = "txtIP";
        txtIP.Size = new Size(225, 23);
        txtIP.TabIndex = 1;
        txtIP.Text = "192.168.0.1";
        txtIP.KeyDown += btnConnect_Click;
        // 
        // chkPrimaryInterface
        // 
        chkPrimaryInterface.Anchor = AnchorStyles.Left;
        chkPrimaryInterface.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkPrimaryInterface, 2);
        chkPrimaryInterface.Location = new Point(97, 51);
        chkPrimaryInterface.Margin = new Padding(4, 3, 4, 3);
        chkPrimaryInterface.Name = "chkPrimaryInterface";
        chkPrimaryInterface.Size = new Size(299, 19);
        chkPrimaryInterface.TabIndex = 2;
        chkPrimaryInterface.Text = "Enable Primary Interface (data streaming and script)";
        chkPrimaryInterface.UseVisualStyleBackColor = true;
        // 
        // chkSftp
        // 
        chkSftp.Anchor = AnchorStyles.Left;
        chkSftp.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkSftp, 2);
        chkSftp.Location = new Point(97, 385);
        chkSftp.Margin = new Padding(4, 3, 4, 3);
        chkSftp.Name = "chkSftp";
        chkSftp.Size = new Size(167, 19);
        chkSftp.TabIndex = 8;
        chkSftp.Text = "Enable file handling (SFTP)";
        chkSftp.UseVisualStyleBackColor = true;
        // 
        // chkSsh
        // 
        chkSsh.Anchor = AnchorStyles.Left;
        chkSsh.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkSsh, 2);
        chkSsh.Location = new Point(97, 414);
        chkSsh.Margin = new Padding(4, 3, 4, 3);
        chkSsh.Name = "chkSsh";
        chkSsh.Size = new Size(187, 19);
        chkSsh.TabIndex = 9;
        chkSsh.Text = "Enable Linux commands (SSH)";
        chkSsh.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(50, 445);
        label2.Margin = new Padding(0);
        label2.Name = "label2";
        label2.Size = new Size(43, 15);
        label2.TabIndex = 0;
        label2.Text = "Login :";
        // 
        // cbUsername
        // 
        cbUsername.Anchor = AnchorStyles.Left;
        cbUsername.Items.AddRange(new object[] { "ur", "root" });
        cbUsername.Location = new Point(97, 441);
        cbUsername.Margin = new Padding(4, 3, 4, 3);
        cbUsername.Name = "cbUsername";
        cbUsername.Size = new Size(93, 23);
        cbUsername.TabIndex = 10;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(30, 474);
        label3.Margin = new Padding(0);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 0;
        label3.Text = "Password :";
        // 
        // txtPassword
        // 
        txtPassword.Anchor = AnchorStyles.Left;
        txtPassword.Location = new Point(97, 470);
        txtPassword.Margin = new Padding(4, 3, 4, 3);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(93, 23);
        txtPassword.TabIndex = 11;
        txtPassword.Text = "easybot";
        // 
        // btnConnect
        // 
        btnConnect.Dock = DockStyle.Left;
        btnConnect.Location = new Point(0, 0);
        btnConnect.Margin = new Padding(4, 3, 4, 3);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(112, 34);
        btnConnect.TabIndex = 17;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // btnDisconnect
        // 
        btnDisconnect.Dock = DockStyle.Right;
        btnDisconnect.Location = new Point(118, 0);
        btnDisconnect.Margin = new Padding(4, 3, 4, 3);
        btnDisconnect.Name = "btnDisconnect";
        btnDisconnect.Size = new Size(107, 34);
        btnDisconnect.TabIndex = 18;
        btnDisconnect.Text = "Disconnect";
        btnDisconnect.UseVisualStyleBackColor = true;
        btnDisconnect.Click += btnDisconnect_Click;
        // 
        // chkXmlRpc
        // 
        chkXmlRpc.Anchor = AnchorStyles.Left;
        chkXmlRpc.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkXmlRpc, 2);
        chkXmlRpc.Location = new Point(97, 310);
        chkXmlRpc.Margin = new Padding(4, 3, 4, 3);
        chkXmlRpc.Name = "chkXmlRpc";
        chkXmlRpc.Size = new Size(247, 19);
        chkXmlRpc.TabIndex = 6;
        chkXmlRpc.Text = "Enable Remote Procedure Call (XML-RPC)";
        chkXmlRpc.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(27, 341);
        label4.Margin = new Padding(0);
        label4.Name = "label4";
        label4.Size = new Size(66, 15);
        label4.TabIndex = 0;
        label4.Text = "Local port :";
        // 
        // udXmlRpcPort
        // 
        udXmlRpcPort.Anchor = AnchorStyles.Left;
        udXmlRpcPort.Location = new Point(97, 337);
        udXmlRpcPort.Margin = new Padding(4, 3, 4, 3);
        udXmlRpcPort.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
        udXmlRpcPort.Name = "udXmlRpcPort";
        udXmlRpcPort.Size = new Size(93, 23);
        udXmlRpcPort.TabIndex = 7;
        // 
        // lblConnected
        // 
        lblConnected.Dock = DockStyle.Fill;
        lblConnected.Location = new Point(97, 749);
        lblConnected.Margin = new Padding(4, 0, 4, 0);
        lblConnected.Name = "lblConnected";
        lblConnected.Size = new Size(225, 29);
        lblConnected.TabIndex = 19;
        lblConnected.Text = "______";
        lblConnected.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // chkSocket
        // 
        chkSocket.Anchor = AnchorStyles.Left;
        chkSocket.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkSocket, 2);
        chkSocket.Location = new Point(97, 235);
        chkSocket.Margin = new Padding(4, 3, 4, 3);
        chkSocket.Name = "chkSocket";
        chkSocket.Size = new Size(220, 19);
        chkSocket.TabIndex = 4;
        chkSocket.Text = "Enable socket communication server";
        chkSocket.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(27, 266);
        label5.Margin = new Padding(0);
        label5.Name = "label5";
        label5.Size = new Size(66, 15);
        label5.TabIndex = 0;
        label5.Text = "Local port :";
        // 
        // udSocketPort
        // 
        udSocketPort.Anchor = AnchorStyles.Left;
        udSocketPort.Location = new Point(97, 262);
        udSocketPort.Margin = new Padding(4, 3, 4, 3);
        udSocketPort.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
        udSocketPort.Name = "udSocketPort";
        udSocketPort.Size = new Size(93, 23);
        udSocketPort.TabIndex = 5;
        // 
        // chkRTDE
        // 
        chkRTDE.Anchor = AnchorStyles.Left;
        chkRTDE.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkRTDE, 2);
        chkRTDE.Location = new Point(97, 518);
        chkRTDE.Margin = new Padding(4, 3, 4, 3);
        chkRTDE.Name = "chkRTDE";
        chkRTDE.Size = new Size(233, 19);
        chkRTDE.TabIndex = 12;
        chkRTDE.Text = "Enable Real-time Data Exchange (RTDE)";
        chkRTDE.UseVisualStyleBackColor = true;
        // 
        // btnRtdeOutputs
        // 
        btnRtdeOutputs.Dock = DockStyle.Fill;
        btnRtdeOutputs.Location = new Point(97, 603);
        btnRtdeOutputs.Margin = new Padding(4, 3, 4, 3);
        btnRtdeOutputs.Name = "btnRtdeOutputs";
        btnRtdeOutputs.Size = new Size(225, 34);
        btnRtdeOutputs.TabIndex = 15;
        btnRtdeOutputs.Text = "Select incoming outputs data...";
        btnRtdeOutputs.UseVisualStyleBackColor = true;
        btnRtdeOutputs.Click += btnRtdeOutputs_Click;
        // 
        // lblFrequency
        // 
        lblFrequency.Anchor = AnchorStyles.Right;
        lblFrequency.AutoSize = true;
        lblFrequency.Location = new Point(25, 578);
        lblFrequency.Margin = new Padding(0);
        lblFrequency.Name = "lblFrequency";
        lblFrequency.Size = new Size(68, 15);
        lblFrequency.TabIndex = 0;
        lblFrequency.Text = "Frequency :";
        // 
        // udFrequency
        // 
        udFrequency.Location = new Point(4, 3);
        udFrequency.Margin = new Padding(4, 3, 4, 3);
        udFrequency.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
        udFrequency.Name = "udFrequency";
        udFrequency.Size = new Size(93, 23);
        udFrequency.TabIndex = 13;
        // 
        // lnkMaxFrequency
        // 
        lnkMaxFrequency.Anchor = AnchorStyles.None;
        lnkMaxFrequency.AutoSize = true;
        lnkMaxFrequency.Location = new Point(134, 7);
        lnkMaxFrequency.Margin = new Padding(4, 0, 4, 0);
        lnkMaxFrequency.Name = "lnkMaxFrequency";
        lnkMaxFrequency.Size = new Size(139, 15);
        lnkMaxFrequency.TabIndex = 14;
        lnkMaxFrequency.TabStop = true;
        lnkMaxFrequency.Text = "(Set 0 for max frequency)";
        lnkMaxFrequency.LinkClicked += lnkMaxFrequency_LinkClicked;
        // 
        // btnRtdeInputs
        // 
        btnRtdeInputs.Dock = DockStyle.Fill;
        btnRtdeInputs.Location = new Point(97, 643);
        btnRtdeInputs.Margin = new Padding(4, 3, 4, 3);
        btnRtdeInputs.Name = "btnRtdeInputs";
        btnRtdeInputs.Size = new Size(225, 34);
        btnRtdeInputs.TabIndex = 16;
        btnRtdeInputs.Text = "Select outgoing inputs data...";
        btnRtdeInputs.UseVisualStyleBackColor = true;
        btnRtdeInputs.Click += btnRtdeInputs_Click;
        // 
        // lblRtdeOutputs
        // 
        lblRtdeOutputs.Anchor = AnchorStyles.Left;
        lblRtdeOutputs.AutoSize = true;
        lblRtdeOutputs.Location = new Point(330, 612);
        lblRtdeOutputs.Margin = new Padding(4, 0, 4, 0);
        lblRtdeOutputs.Name = "lblRtdeOutputs";
        lblRtdeOutputs.Size = new Size(16, 15);
        lblRtdeOutputs.TabIndex = 0;
        lblRtdeOutputs.Text = "...";
        // 
        // lblRtdeInputs
        // 
        lblRtdeInputs.Anchor = AnchorStyles.Left;
        lblRtdeInputs.AutoSize = true;
        lblRtdeInputs.Location = new Point(330, 652);
        lblRtdeInputs.Margin = new Padding(4, 0, 4, 0);
        lblRtdeInputs.Name = "lblRtdeInputs";
        lblRtdeInputs.Size = new Size(16, 15);
        lblRtdeInputs.TabIndex = 0;
        lblRtdeInputs.Text = "...";
        // 
        // chkDashboard
        // 
        chkDashboard.Anchor = AnchorStyles.Left;
        chkDashboard.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkDashboard, 2);
        chkDashboard.Location = new Point(97, 97);
        chkDashboard.Margin = new Padding(4, 3, 4, 3);
        chkDashboard.Name = "chkDashboard";
        chkDashboard.Size = new Size(254, 19);
        chkDashboard.TabIndex = 3;
        chkDashboard.Text = "Enable dashboard client (Polyscope legacy)";
        chkDashboard.UseVisualStyleBackColor = true;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(chkInterpreterMode, 1, 8);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 22);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 23);
        tableLayoutPanel1.Controls.Add(lblConnected, 1, 28);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(txtIP, 1, 0);
        tableLayoutPanel1.Controls.Add(udSocketPort, 1, 11);
        tableLayoutPanel1.Controls.Add(label5, 0, 11);
        tableLayoutPanel1.Controls.Add(chkPrimaryInterface, 1, 2);
        tableLayoutPanel1.Controls.Add(chkDashboard, 1, 4);
        tableLayoutPanel1.Controls.Add(udXmlRpcPort, 1, 14);
        tableLayoutPanel1.Controls.Add(cbUsername, 1, 18);
        tableLayoutPanel1.Controls.Add(chkSocket, 1, 10);
        tableLayoutPanel1.Controls.Add(chkXmlRpc, 1, 13);
        tableLayoutPanel1.Controls.Add(label4, 0, 14);
        tableLayoutPanel1.Controls.Add(txtPassword, 1, 19);
        tableLayoutPanel1.Controls.Add(chkSsh, 1, 17);
        tableLayoutPanel1.Controls.Add(chkSftp, 1, 16);
        tableLayoutPanel1.Controls.Add(label2, 0, 18);
        tableLayoutPanel1.Controls.Add(label3, 0, 19);
        tableLayoutPanel1.Controls.Add(btnRtdeInputs, 1, 25);
        tableLayoutPanel1.Controls.Add(btnRtdeOutputs, 1, 24);
        tableLayoutPanel1.Controls.Add(lblRtdeInputs, 2, 25);
        tableLayoutPanel1.Controls.Add(lblRtdeOutputs, 2, 24);
        tableLayoutPanel1.Controls.Add(lblFrequency, 0, 23);
        tableLayoutPanel1.Controls.Add(panel1, 1, 27);
        tableLayoutPanel1.Controls.Add(chkRTDE, 1, 21);
        tableLayoutPanel1.Controls.Add(label6, 2, 18);
        tableLayoutPanel1.Controls.Add(label7, 2, 19);
        tableLayoutPanel1.Controls.Add(chkRest, 1, 6);
        tableLayoutPanel1.Controls.Add(lblLicense, 2, 27);
        tableLayoutPanel1.Location = new Point(4, 3);
        tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 30;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(628, 863);
        tableLayoutPanel1.TabIndex = 9;
        // 
        // chkInterpreterMode
        // 
        chkInterpreterMode.Anchor = AnchorStyles.Left;
        chkInterpreterMode.AutoSize = true;
        chkInterpreterMode.Location = new Point(97, 189);
        chkInterpreterMode.Margin = new Padding(4, 3, 4, 3);
        chkInterpreterMode.Name = "chkInterpreterMode";
        chkInterpreterMode.Size = new Size(153, 19);
        chkInterpreterMode.TabIndex = 10;
        chkInterpreterMode.Text = "Enable interpreter mode";
        chkInterpreterMode.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(radioV1);
        flowLayoutPanel2.Controls.Add(radioV2);
        flowLayoutPanel2.Dock = DockStyle.Fill;
        flowLayoutPanel2.Location = new Point(93, 542);
        flowLayoutPanel2.Margin = new Padding(0);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(233, 29);
        flowLayoutPanel2.TabIndex = 10;
        // 
        // radioV1
        // 
        radioV1.Anchor = AnchorStyles.Left;
        radioV1.AutoSize = true;
        radioV1.Location = new Point(18, 3);
        radioV1.Margin = new Padding(18, 3, 4, 3);
        radioV1.Name = "radioV1";
        radioV1.Size = new Size(72, 19);
        radioV1.TabIndex = 15;
        radioV1.TabStop = true;
        radioV1.Text = "Version 1";
        radioV1.UseVisualStyleBackColor = true;
        radioV1.CheckedChanged += radioV1_CheckedChanged;
        // 
        // radioV2
        // 
        radioV2.Anchor = AnchorStyles.Left;
        radioV2.AutoSize = true;
        radioV2.Location = new Point(98, 3);
        radioV2.Margin = new Padding(4, 3, 4, 3);
        radioV2.Name = "radioV2";
        radioV2.Size = new Size(72, 19);
        radioV2.TabIndex = 16;
        radioV2.TabStop = true;
        radioV2.Text = "Version 2";
        radioV2.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel1
        // 
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
        flowLayoutPanel1.Controls.Add(udFrequency);
        flowLayoutPanel1.Controls.Add(lblHz);
        flowLayoutPanel1.Controls.Add(lnkMaxFrequency);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(93, 571);
        flowLayoutPanel1.Margin = new Padding(0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(535, 29);
        flowLayoutPanel1.TabIndex = 11;
        // 
        // lblHz
        // 
        lblHz.Anchor = AnchorStyles.Right;
        lblHz.AutoSize = true;
        lblHz.Location = new Point(105, 7);
        lblHz.Margin = new Padding(4, 0, 4, 0);
        lblHz.Name = "lblHz";
        lblHz.Size = new Size(21, 15);
        lblHz.TabIndex = 8;
        lblHz.Text = "Hz";
        // 
        // panel1
        // 
        panel1.Controls.Add(btnConnect);
        panel1.Controls.Add(btnDisconnect);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(97, 712);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(225, 34);
        panel1.TabIndex = 12;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Left;
        label6.AutoSize = true;
        label6.Location = new Point(326, 445);
        label6.Margin = new Padding(0);
        label6.Name = "label6";
        label6.Size = new Size(254, 15);
        label6.TabIndex = 20;
        label6.Text = "Default login : root (real robot)  / ur (simulator)";
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Left;
        label7.AutoSize = true;
        label7.Location = new Point(326, 474);
        label7.Margin = new Padding(0);
        label7.Name = "label7";
        label7.Size = new Size(148, 15);
        label7.TabIndex = 21;
        label7.Text = "Default password : easybot";
        // 
        // chkRest
        // 
        chkRest.Anchor = AnchorStyles.Left;
        chkRest.AutoSize = true;
        tableLayoutPanel1.SetColumnSpan(chkRest, 2);
        chkRest.Location = new Point(97, 143);
        chkRest.Margin = new Padding(4, 3, 4, 3);
        chkRest.Name = "chkRest";
        chkRest.Size = new Size(209, 19);
        chkRest.TabIndex = 22;
        chkRest.Text = "Enable REST API (PolyscopeX only)";
        chkRest.UseVisualStyleBackColor = true;
        // 
        // lblLicense
        // 
        lblLicense.Anchor = AnchorStyles.Left;
        lblLicense.AutoSize = true;
        lblLicense.Location = new Point(329, 721);
        lblLicense.Name = "lblLicense";
        lblLicense.Size = new Size(16, 15);
        lblLicense.TabIndex = 23;
        lblLicense.Text = "...";
        // 
        // ConnectControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ConnectControl";
        Size = new Size(1429, 981);
        ((System.ComponentModel.ISupportInitialize)udXmlRpcPort).EndInit();
        ((System.ComponentModel.ISupportInitialize)udSocketPort).EndInit();
        ((System.ComponentModel.ISupportInitialize)udFrequency).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.CheckBox chkPrimaryInterface;
    private System.Windows.Forms.CheckBox chkSftp;
    private System.Windows.Forms.CheckBox chkSsh;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbUsername;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.CheckBox chkXmlRpc;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown udXmlRpcPort;
    private System.Windows.Forms.Label lblConnected;
    private System.Windows.Forms.CheckBox chkSocket;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown udSocketPort;
    private System.Windows.Forms.CheckBox chkRTDE;
    private System.Windows.Forms.Button btnRtdeOutputs;
    private System.Windows.Forms.Label lblFrequency;
    private System.Windows.Forms.NumericUpDown udFrequency;
    private System.Windows.Forms.LinkLabel lnkMaxFrequency;
    private System.Windows.Forms.Button btnRtdeInputs;
    private System.Windows.Forms.Label lblRtdeOutputs;
    private System.Windows.Forms.Label lblRtdeInputs;
    private System.Windows.Forms.CheckBox chkDashboard;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Label lblHz;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton radioV1;
    private System.Windows.Forms.RadioButton radioV2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.CheckBox chkInterpreterMode;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private CheckBox chkRest;
    private Label lblLicense;
}


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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.chkPrimaryInterface = new System.Windows.Forms.CheckBox();
            this.chkSftp = new System.Windows.Forms.CheckBox();
            this.chkSsh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.chkXmlRpc = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.udXmlRpcPort = new System.Windows.Forms.NumericUpDown();
            this.lblConnected = new System.Windows.Forms.Label();
            this.chkSocket = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.udSocketPort = new System.Windows.Forms.NumericUpDown();
            this.chkRTDE = new System.Windows.Forms.CheckBox();
            this.btnRtdeOutputs = new System.Windows.Forms.Button();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.udFrequency = new System.Windows.Forms.NumericUpDown();
            this.lnkMaxFrequency = new System.Windows.Forms.LinkLabel();
            this.btnRtdeInputs = new System.Windows.Forms.Button();
            this.lblRtdeOutputs = new System.Windows.Forms.Label();
            this.lblRtdeInputs = new System.Windows.Forms.Label();
            this.chkDashboard = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioV1 = new System.Windows.Forms.RadioButton();
            this.radioV2 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHz = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkInterpreterMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.udXmlRpcPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSocketPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrequency)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address :";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIP.Location = new System.Drawing.Point(83, 3);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(194, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.0.1";
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnConnect_Click);
            // 
            // chkPrimaryInterface
            // 
            this.chkPrimaryInterface.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkPrimaryInterface.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkPrimaryInterface, 2);
            this.chkPrimaryInterface.Location = new System.Drawing.Point(83, 44);
            this.chkPrimaryInterface.Name = "chkPrimaryInterface";
            this.chkPrimaryInterface.Size = new System.Drawing.Size(268, 17);
            this.chkPrimaryInterface.TabIndex = 2;
            this.chkPrimaryInterface.Text = "Enable Primary Interface (data streaming and script)";
            this.chkPrimaryInterface.UseVisualStyleBackColor = true;
            // 
            // chkSftp
            // 
            this.chkSftp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSftp.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkSftp, 2);
            this.chkSftp.Location = new System.Drawing.Point(83, 295);
            this.chkSftp.Name = "chkSftp";
            this.chkSftp.Size = new System.Drawing.Size(154, 17);
            this.chkSftp.TabIndex = 8;
            this.chkSftp.Text = "Enable file handling (SFTP)";
            this.chkSftp.UseVisualStyleBackColor = true;
            // 
            // chkSsh
            // 
            this.chkSsh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSsh.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkSsh, 2);
            this.chkSsh.Location = new System.Drawing.Point(83, 320);
            this.chkSsh.Name = "chkSsh";
            this.chkSsh.Size = new System.Drawing.Size(172, 17);
            this.chkSsh.TabIndex = 9;
            this.chkSsh.Text = "Enable Linux commands (SSH)";
            this.chkSsh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login :";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsername.Location = new System.Drawing.Point(83, 344);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(80, 20);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Text = "ur";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(83, 369);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(80, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "easybot";
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 29);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDisconnect.Location = new System.Drawing.Point(102, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(92, 29);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // chkXmlRpc
            // 
            this.chkXmlRpc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkXmlRpc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkXmlRpc, 2);
            this.chkXmlRpc.Location = new System.Drawing.Point(83, 230);
            this.chkXmlRpc.Name = "chkXmlRpc";
            this.chkXmlRpc.Size = new System.Drawing.Size(227, 17);
            this.chkXmlRpc.TabIndex = 6;
            this.chkXmlRpc.Text = "Enable Remote Procedure Call (XML-RPC)";
            this.chkXmlRpc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Local port :";
            // 
            // udXmlRpcPort
            // 
            this.udXmlRpcPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.udXmlRpcPort.Location = new System.Drawing.Point(83, 254);
            this.udXmlRpcPort.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.udXmlRpcPort.Name = "udXmlRpcPort";
            this.udXmlRpcPort.Size = new System.Drawing.Size(80, 20);
            this.udXmlRpcPort.TabIndex = 7;
            // 
            // lblConnected
            // 
            this.lblConnected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnected.Location = new System.Drawing.Point(83, 611);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(194, 25);
            this.lblConnected.TabIndex = 19;
            this.lblConnected.Text = "______";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSocket
            // 
            this.chkSocket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSocket.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkSocket, 2);
            this.chkSocket.Location = new System.Drawing.Point(83, 165);
            this.chkSocket.Name = "chkSocket";
            this.chkSocket.Size = new System.Drawing.Size(200, 17);
            this.chkSocket.TabIndex = 4;
            this.chkSocket.Text = "Enable socket communication server";
            this.chkSocket.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Local port :";
            // 
            // udSocketPort
            // 
            this.udSocketPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.udSocketPort.Location = new System.Drawing.Point(83, 189);
            this.udSocketPort.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.udSocketPort.Name = "udSocketPort";
            this.udSocketPort.Size = new System.Drawing.Size(80, 20);
            this.udSocketPort.TabIndex = 5;
            // 
            // chkRTDE
            // 
            this.chkRTDE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkRTDE.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkRTDE, 2);
            this.chkRTDE.Location = new System.Drawing.Point(83, 410);
            this.chkRTDE.Name = "chkRTDE";
            this.chkRTDE.Size = new System.Drawing.Size(222, 17);
            this.chkRTDE.TabIndex = 12;
            this.chkRTDE.Text = "Enable Real-time Data Exchange (RTDE)";
            this.chkRTDE.UseVisualStyleBackColor = true;
            // 
            // btnRtdeOutputs
            // 
            this.btnRtdeOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRtdeOutputs.Location = new System.Drawing.Point(83, 484);
            this.btnRtdeOutputs.Name = "btnRtdeOutputs";
            this.btnRtdeOutputs.Size = new System.Drawing.Size(194, 29);
            this.btnRtdeOutputs.TabIndex = 15;
            this.btnRtdeOutputs.Text = "Select incoming outputs data...";
            this.btnRtdeOutputs.UseVisualStyleBackColor = true;
            this.btnRtdeOutputs.Click += new System.EventHandler(this.btnRtdeOutputs_Click);
            // 
            // lblFrequency
            // 
            this.lblFrequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(17, 462);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(63, 13);
            this.lblFrequency.TabIndex = 0;
            this.lblFrequency.Text = "Frequency :";
            // 
            // udFrequency
            // 
            this.udFrequency.Location = new System.Drawing.Point(3, 3);
            this.udFrequency.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.udFrequency.Name = "udFrequency";
            this.udFrequency.Size = new System.Drawing.Size(80, 20);
            this.udFrequency.TabIndex = 13;
            // 
            // lnkMaxFrequency
            // 
            this.lnkMaxFrequency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkMaxFrequency.AutoSize = true;
            this.lnkMaxFrequency.Location = new System.Drawing.Point(115, 6);
            this.lnkMaxFrequency.Name = "lnkMaxFrequency";
            this.lnkMaxFrequency.Size = new System.Drawing.Size(125, 13);
            this.lnkMaxFrequency.TabIndex = 14;
            this.lnkMaxFrequency.TabStop = true;
            this.lnkMaxFrequency.Text = "(Set 0 for max frequency)";
            this.lnkMaxFrequency.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMaxFrequency_LinkClicked);
            // 
            // btnRtdeInputs
            // 
            this.btnRtdeInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRtdeInputs.Location = new System.Drawing.Point(83, 519);
            this.btnRtdeInputs.Name = "btnRtdeInputs";
            this.btnRtdeInputs.Size = new System.Drawing.Size(194, 29);
            this.btnRtdeInputs.TabIndex = 16;
            this.btnRtdeInputs.Text = "Select outgoing inputs data...";
            this.btnRtdeInputs.UseVisualStyleBackColor = true;
            this.btnRtdeInputs.Click += new System.EventHandler(this.btnRtdeInputs_Click);
            // 
            // lblRtdeOutputs
            // 
            this.lblRtdeOutputs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRtdeOutputs.AutoSize = true;
            this.lblRtdeOutputs.Location = new System.Drawing.Point(283, 492);
            this.lblRtdeOutputs.Name = "lblRtdeOutputs";
            this.lblRtdeOutputs.Size = new System.Drawing.Size(16, 13);
            this.lblRtdeOutputs.TabIndex = 0;
            this.lblRtdeOutputs.Text = "...";
            // 
            // lblRtdeInputs
            // 
            this.lblRtdeInputs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRtdeInputs.AutoSize = true;
            this.lblRtdeInputs.Location = new System.Drawing.Point(283, 527);
            this.lblRtdeInputs.Name = "lblRtdeInputs";
            this.lblRtdeInputs.Size = new System.Drawing.Size(16, 13);
            this.lblRtdeInputs.TabIndex = 0;
            this.lblRtdeInputs.Text = "...";
            // 
            // chkDashboard
            // 
            this.chkDashboard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkDashboard.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkDashboard, 2);
            this.chkDashboard.Location = new System.Drawing.Point(83, 85);
            this.chkDashboard.Name = "chkDashboard";
            this.chkDashboard.Size = new System.Drawing.Size(140, 17);
            this.chkDashboard.TabIndex = 3;
            this.chkDashboard.Text = "Enable dashboard client";
            this.chkDashboard.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.chkInterpreterMode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 20);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 21);
            this.tableLayoutPanel1.Controls.Add(this.lblConnected, 1, 26);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.udSocketPort, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.chkPrimaryInterface, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkDashboard, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.udXmlRpcPort, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.chkSocket, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.chkXmlRpc, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.chkSsh, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.chkSftp, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.btnRtdeInputs, 1, 23);
            this.tableLayoutPanel1.Controls.Add(this.btnRtdeOutputs, 1, 22);
            this.tableLayoutPanel1.Controls.Add(this.lblRtdeInputs, 2, 23);
            this.tableLayoutPanel1.Controls.Add(this.lblRtdeOutputs, 2, 22);
            this.tableLayoutPanel1.Controls.Add(this.lblFrequency, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 25);
            this.tableLayoutPanel1.Controls.Add(this.chkRTDE, 1, 19);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 28;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 669);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioV1);
            this.flowLayoutPanel2.Controls.Add(this.radioV2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(80, 431);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 25);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // radioV1
            // 
            this.radioV1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioV1.AutoSize = true;
            this.radioV1.Location = new System.Drawing.Point(15, 3);
            this.radioV1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.radioV1.Name = "radioV1";
            this.radioV1.Size = new System.Drawing.Size(69, 17);
            this.radioV1.TabIndex = 15;
            this.radioV1.TabStop = true;
            this.radioV1.Text = "Version 1";
            this.radioV1.UseVisualStyleBackColor = true;
            this.radioV1.CheckedChanged += new System.EventHandler(this.radioV1_CheckedChanged);
            // 
            // radioV2
            // 
            this.radioV2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioV2.AutoSize = true;
            this.radioV2.Location = new System.Drawing.Point(90, 3);
            this.radioV2.Name = "radioV2";
            this.radioV2.Size = new System.Drawing.Size(69, 17);
            this.radioV2.TabIndex = 16;
            this.radioV2.TabStop = true;
            this.radioV2.Text = "Version 2";
            this.radioV2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.udFrequency);
            this.flowLayoutPanel1.Controls.Add(this.lblHz);
            this.flowLayoutPanel1.Controls.Add(this.lnkMaxFrequency);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 456);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 25);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // lblHz
            // 
            this.lblHz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHz.AutoSize = true;
            this.lblHz.Location = new System.Drawing.Point(89, 6);
            this.lblHz.Name = "lblHz";
            this.lblHz.Size = new System.Drawing.Size(20, 13);
            this.lblHz.TabIndex = 8;
            this.lblHz.Text = "Hz";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(83, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 29);
            this.panel1.TabIndex = 12;
            // 
            // chkInterpreterMode
            // 
            this.chkInterpreterMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkInterpreterMode.AutoSize = true;
            this.chkInterpreterMode.Location = new System.Drawing.Point(83, 125);
            this.chkInterpreterMode.Name = "chkInterpreterMode";
            this.chkInterpreterMode.Size = new System.Drawing.Size(138, 17);
            this.chkInterpreterMode.TabIndex = 10;
            this.chkInterpreterMode.Text = "Enable interpreter mode";
            this.chkInterpreterMode.UseVisualStyleBackColor = true;
            // 
            // ConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConnectControl";
            this.Size = new System.Drawing.Size(1225, 850);
            ((System.ComponentModel.ISupportInitialize)(this.udXmlRpcPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSocketPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrequency)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.CheckBox chkPrimaryInterface;
    private System.Windows.Forms.CheckBox chkSftp;
    private System.Windows.Forms.CheckBox chkSsh;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUsername;
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
}

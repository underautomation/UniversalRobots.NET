
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
            this.chkDataStreaming = new System.Windows.Forms.CheckBox();
            this.chkSftp = new System.Windows.Forms.CheckBox();
            this.chkSsh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.udXmlRpcPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSocketPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(20, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(193, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.0.1";
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnConnect_Click);
            // 
            // chkDataStreaming
            // 
            this.chkDataStreaming.AutoSize = true;
            this.chkDataStreaming.Location = new System.Drawing.Point(20, 66);
            this.chkDataStreaming.Name = "chkDataStreaming";
            this.chkDataStreaming.Size = new System.Drawing.Size(268, 17);
            this.chkDataStreaming.TabIndex = 2;
            this.chkDataStreaming.Text = "Enable data streaming and script (Primary Interface)";
            this.chkDataStreaming.UseVisualStyleBackColor = true;
            // 
            // chkSftp
            // 
            this.chkSftp.AutoSize = true;
            this.chkSftp.Location = new System.Drawing.Point(20, 173);
            this.chkSftp.Name = "chkSftp";
            this.chkSftp.Size = new System.Drawing.Size(154, 17);
            this.chkSftp.TabIndex = 2;
            this.chkSftp.Text = "Enable file handling (SFTP)";
            this.chkSftp.UseVisualStyleBackColor = true;
            // 
            // chkSsh
            // 
            this.chkSsh.AutoSize = true;
            this.chkSsh.Location = new System.Drawing.Point(20, 211);
            this.chkSsh.Name = "chkSsh";
            this.chkSsh.Size = new System.Drawing.Size(172, 17);
            this.chkSsh.TabIndex = 2;
            this.chkSsh.Text = "Enable Linux commands (SSH)";
            this.chkSsh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(95, 228);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(67, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "ur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(242, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(67, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "easybot";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(55, 337);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(136, 337);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // chkXmlRpc
            // 
            this.chkXmlRpc.AutoSize = true;
            this.chkXmlRpc.Location = new System.Drawing.Point(20, 104);
            this.chkXmlRpc.Name = "chkXmlRpc";
            this.chkXmlRpc.Size = new System.Drawing.Size(227, 17);
            this.chkXmlRpc.TabIndex = 2;
            this.chkXmlRpc.Text = "Enable Remote Procedure Call (XML-RPC)";
            this.chkXmlRpc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Local port :";
            // 
            // udXmlRpcPort
            // 
            this.udXmlRpcPort.Location = new System.Drawing.Point(95, 122);
            this.udXmlRpcPort.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.udXmlRpcPort.Name = "udXmlRpcPort";
            this.udXmlRpcPort.Size = new System.Drawing.Size(67, 20);
            this.udXmlRpcPort.TabIndex = 4;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(55, 366);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(43, 13);
            this.lblConnected.TabIndex = 5;
            this.lblConnected.Text = "______";
            // 
            // chkSocket
            // 
            this.chkSocket.AutoSize = true;
            this.chkSocket.Location = new System.Drawing.Point(20, 271);
            this.chkSocket.Name = "chkSocket";
            this.chkSocket.Size = new System.Drawing.Size(126, 17);
            this.chkSocket.TabIndex = 2;
            this.chkSocket.Text = "Enable socket server";
            this.chkSocket.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Local port :";
            // 
            // udSocketPort
            // 
            this.udSocketPort.Location = new System.Drawing.Point(95, 294);
            this.udSocketPort.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.udSocketPort.Name = "udSocketPort";
            this.udSocketPort.Size = new System.Drawing.Size(67, 20);
            this.udSocketPort.TabIndex = 4;
            // 
            // ConnectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.udSocketPort);
            this.Controls.Add(this.udXmlRpcPort);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkSocket);
            this.Controls.Add(this.chkSsh);
            this.Controls.Add(this.chkSftp);
            this.Controls.Add(this.chkXmlRpc);
            this.Controls.Add(this.chkDataStreaming);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "ConnectControl";
            this.Size = new System.Drawing.Size(629, 461);
            ((System.ComponentModel.ISupportInitialize)(this.udXmlRpcPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSocketPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.CheckBox chkDataStreaming;
    private System.Windows.Forms.CheckBox chkSftp;
    private System.Windows.Forms.CheckBox chkSsh;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtLogin;
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
}

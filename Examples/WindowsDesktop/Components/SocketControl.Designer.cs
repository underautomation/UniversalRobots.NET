
    partial class SocketControl
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
            this.Label15 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.lstClients = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.linkSample = new System.Windows.Forms.LinkLabel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label15.Location = new System.Drawing.Point(1, 382);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(21, 22);
            this.Label15.TabIndex = 9;
            this.Label15.Text = ">";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(512, 381);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(209, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(27, 383);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(479, 20);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSend_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(5, 410);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(716, 176);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // lstClients
            // 
            this.lstClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstClients.FullRowSelect = true;
            this.lstClients.HideSelection = false;
            this.lstClients.Location = new System.Drawing.Point(27, 292);
            this.lstClients.MultiSelect = false;
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(479, 85);
            this.lstClients.TabIndex = 10;
            this.lstClients.UseCompatibleStateImageBehavior = false;
            this.lstClients.View = System.Windows.Forms.View.Details;
            this.lstClients.SelectedIndexChanged += new System.EventHandler(this.lstClients_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Local port";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Remote IP";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Remote port";
            this.columnHeader4.Width = 80;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 97);
            this.label1.TabIndex = 32;
            this.label1.Text = "WARNING : If the robot fails to connect, check your local firewall and check the " +
    "robot\'s security settings in Polyscope: Settings / Security / General";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkSample
            // 
            this.linkSample.AutoSize = true;
            this.linkSample.Location = new System.Drawing.Point(232, 8);
            this.linkSample.Name = "linkSample";
            this.linkSample.Size = new System.Drawing.Size(96, 13);
            this.linkSample.TabIndex = 36;
            this.linkSample.TabStop = true;
            this.linkSample.Text = "socket_sample.urp";
            this.linkSample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSample_LinkClicked);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(164, 72);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(98, 20);
            this.txtPort.TabIndex = 26;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(164, 46);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.ReadOnly = true;
            this.txtLocalIP.Size = new System.Drawing.Size(98, 20);
            this.txtLocalIP.TabIndex = 27;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(57, 72);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(107, 20);
            this.Label12.TabIndex = 28;
            this.Label12.Text = "Your local port :";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(57, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 20);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Your local PC IP :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(24, 25);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(368, 20);
            this.Label10.TabIndex = 30;
            this.Label10.Text = "2. Use your local machine information in function socket_open() :";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(24, 95);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(368, 20);
            this.Label13.TabIndex = 33;
            this.Label13.Text = "3. Run the program on your robot";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(24, 4);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 20);
            this.Label9.TabIndex = 34;
            this.Label9.Text = "1. Upload this program on your UR robot : ";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "4. Select a socket and exchange messages";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.socket_sample;
            this.pictureBox2.Location = new System.Drawing.Point(84, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // SocketControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkSample);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLog);
            this.Name = "SocketControl";
            this.Size = new System.Drawing.Size(735, 589);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.TextBox txtMessage;
        internal System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.ListView lstClients;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    internal System.Windows.Forms.Label label1;
    internal System.Windows.Forms.LinkLabel linkSample;
    internal System.Windows.Forms.TextBox txtPort;
    internal System.Windows.Forms.TextBox txtLocalIP;
    internal System.Windows.Forms.Label Label12;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.Label Label13;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox2;
}

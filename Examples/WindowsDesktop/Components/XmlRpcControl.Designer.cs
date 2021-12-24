
    partial class XmlRpcControl
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
            this.linkXmlRpcSample = new System.Windows.Forms.LinkLabel();
            this.txtXmlRpcPort = new System.Windows.Forms.TextBox();
            this.txtLocalIP = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkXmlRpcSample
            // 
            this.linkXmlRpcSample.AutoSize = true;
            this.linkXmlRpcSample.Location = new System.Drawing.Point(221, 16);
            this.linkXmlRpcSample.Name = "linkXmlRpcSample";
            this.linkXmlRpcSample.Size = new System.Drawing.Size(100, 13);
            this.linkXmlRpcSample.TabIndex = 25;
            this.linkXmlRpcSample.TabStop = true;
            this.linkXmlRpcSample.Text = "xml_rpc_sample.urp";
            this.linkXmlRpcSample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkXmlRpcSample_LinkClicked);
            // 
            // txtXmlRpcPort
            // 
            this.txtXmlRpcPort.Location = new System.Drawing.Point(153, 91);
            this.txtXmlRpcPort.Name = "txtXmlRpcPort";
            this.txtXmlRpcPort.ReadOnly = true;
            this.txtXmlRpcPort.Size = new System.Drawing.Size(98, 20);
            this.txtXmlRpcPort.TabIndex = 10;
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.Location = new System.Drawing.Point(153, 65);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.ReadOnly = true;
            this.txtLocalIP.Size = new System.Drawing.Size(98, 20);
            this.txtLocalIP.TabIndex = 11;
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(46, 91);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(107, 20);
            this.Label12.TabIndex = 15;
            this.Label12.Text = "Your local port :";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(46, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 20);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Your local PC IP :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(13, 44);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(368, 20);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "2. Use your local machine information in function rpc_factory() :";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(13, 423);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(368, 20);
            this.Label14.TabIndex = 19;
            this.Label14.Text = "4. Wait here for a popup asking you what to answer the robot...";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(13, 124);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(368, 20);
            this.Label13.TabIndex = 20;
            this.Label13.Text = "3. Run the program on your robot";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(13, 12);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 20);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "1. Upload this program on your UR robot : ";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox1.Image = global::UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties.Resources.xml_rpc_sample;
            this.PictureBox1.Location = new System.Drawing.Point(0, 147);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(551, 254);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 112);
            this.label1.TabIndex = 20;
            this.label1.Text = "WARNING : If the robot fails to connect, check your local firewall and check the " +
    "robot\'s security settings in Polyscope: Settings / Security / General";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XmlRpcControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkXmlRpcSample);
            this.Controls.Add(this.txtXmlRpcPort);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PictureBox1);
            this.Name = "XmlRpcControl";
            this.Size = new System.Drawing.Size(1086, 805);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel linkXmlRpcSample;
        internal System.Windows.Forms.TextBox txtXmlRpcPort;
        internal System.Windows.Forms.TextBox txtLocalIP;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
    internal System.Windows.Forms.Label label1;
}

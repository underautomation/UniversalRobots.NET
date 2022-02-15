
    partial class SshControl
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
            this.btnSendShell = new System.Windows.Forms.Button();
            this.txtSSHCommand = new System.Windows.Forms.TextBox();
            this.txtShellCommand = new System.Windows.Forms.TextBox();
            this.txtShellHistory = new System.Windows.Forms.RichTextBox();
            this.btnSSHSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommandResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label15.Location = new System.Drawing.Point(8, 19);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(21, 22);
            this.Label15.TabIndex = 9;
            this.Label15.Text = ">";
            // 
            // btnSendShell
            // 
            this.btnSendShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendShell.Location = new System.Drawing.Point(613, 18);
            this.btnSendShell.Name = "btnSendShell";
            this.btnSendShell.Size = new System.Drawing.Size(110, 23);
            this.btnSendShell.TabIndex = 8;
            this.btnSendShell.Text = "Send";
            this.btnSendShell.UseVisualStyleBackColor = true;
            this.btnSendShell.Click += new System.EventHandler(this.btnSendShell_Click);
            // 
            // txtSSHCommand
            // 
            this.txtSSHCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSHCommand.Location = new System.Drawing.Point(7, 411);
            this.txtSSHCommand.Name = "txtSSHCommand";
            this.txtSSHCommand.Size = new System.Drawing.Size(600, 20);
            this.txtSSHCommand.TabIndex = 6;
            this.txtSSHCommand.Text = "ping localhost -c 1";
            this.txtSSHCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSSHSend_Click);
            // 
            // txtShellCommand
            // 
            this.txtShellCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShellCommand.Location = new System.Drawing.Point(34, 20);
            this.txtShellCommand.Name = "txtShellCommand";
            this.txtShellCommand.Size = new System.Drawing.Size(573, 20);
            this.txtShellCommand.TabIndex = 7;
            this.txtShellCommand.Text = "DISPLAY=:0 nohup /home/ur/ursim-current/start-ursim.sh UR16 `# Remote start UR16 " +
    "emulator on virtual machine`";
            this.txtShellCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSendShell_Click);
            // 
            // txtShellHistory
            // 
            this.txtShellHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShellHistory.BackColor = System.Drawing.Color.Black;
            this.txtShellHistory.ForeColor = System.Drawing.Color.White;
            this.txtShellHistory.Location = new System.Drawing.Point(7, 44);
            this.txtShellHistory.Name = "txtShellHistory";
            this.txtShellHistory.ReadOnly = true;
            this.txtShellHistory.Size = new System.Drawing.Size(716, 327);
            this.txtShellHistory.TabIndex = 5;
            this.txtShellHistory.Text = "";
            // 
            // btnSSHSend
            // 
            this.btnSSHSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSSHSend.Location = new System.Drawing.Point(613, 409);
            this.btnSSHSend.Name = "btnSSHSend";
            this.btnSSHSend.Size = new System.Drawing.Size(110, 23);
            this.btnSSHSend.TabIndex = 11;
            this.btnSSHSend.Text = "Send";
            this.btnSSHSend.UseVisualStyleBackColor = true;
            this.btnSSHSend.Click += new System.EventHandler(this.btnSSHSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Send command outside of a shell :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Send a Linux command in a shell, like in your terminal :";
            // 
            // txtCommandResult
            // 
            this.txtCommandResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandResult.Location = new System.Drawing.Point(7, 438);
            this.txtCommandResult.Multiline = true;
            this.txtCommandResult.Name = "txtCommandResult";
            this.txtCommandResult.ReadOnly = true;
            this.txtCommandResult.Size = new System.Drawing.Size(716, 137);
            this.txtCommandResult.TabIndex = 14;
            this.txtCommandResult.Text = ">";
            // 
            // SshControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.txtCommandResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSSHSend);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.btnSendShell);
            this.Controls.Add(this.txtSSHCommand);
            this.Controls.Add(this.txtShellCommand);
            this.Controls.Add(this.txtShellHistory);
            this.Name = "SshControl";
            this.Size = new System.Drawing.Size(730, 589);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnSendShell;
        internal System.Windows.Forms.TextBox txtSSHCommand;
        internal System.Windows.Forms.TextBox txtShellCommand;
        internal System.Windows.Forms.RichTextBox txtShellHistory;
        internal System.Windows.Forms.Button btnSSHSend;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCommandResult;
}

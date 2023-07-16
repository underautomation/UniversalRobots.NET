    partial class InterpreterModeControl
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.btnEndInterpreter = new System.Windows.Forms.Button();
            this.btnClearInterpreter = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnSkipBuffer = new System.Windows.Forms.Button();
            this.btnLastExecuted = new System.Windows.Forms.Button();
            this.btnLastInterpreted = new System.Windows.Forms.Button();
            this.btnLastCleared = new System.Windows.Forms.Button();
            this.btnLastUnexecuted = new System.Windows.Forms.Button();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.txtConsole);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.AutoScroll = true;
            this.splitMain.Panel2.Controls.Add(this.txtCommand);
            this.splitMain.Panel2.Controls.Add(this.pnlMain);
            this.splitMain.Size = new System.Drawing.Size(1240, 710);
            this.splitMain.SplitterDistance = 413;
            this.splitMain.TabIndex = 1;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 0);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(409, 706);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "Please use commands on the right panel.\n\n> ";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnLastUnexecuted);
            this.pnlMain.Controls.Add(this.btnLastCleared);
            this.pnlMain.Controls.Add(this.btnLastInterpreted);
            this.pnlMain.Controls.Add(this.btnLastExecuted);
            this.pnlMain.Controls.Add(this.btnSkipBuffer);
            this.pnlMain.Controls.Add(this.btnAbort);
            this.pnlMain.Controls.Add(this.btnClearInterpreter);
            this.pnlMain.Controls.Add(this.btnEndInterpreter);
            this.pnlMain.Controls.Add(this.btnSendCommand);
            this.pnlMain.Location = new System.Drawing.Point(4, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(436, 448);
            this.pnlMain.TabIndex = 9;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(4, 3);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(435, 20);
            this.txtCommand.TabIndex = 10;
            this.txtCommand.Text = "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(131, 3);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(152, 23);
            this.btnSendCommand.TabIndex = 1;
            this.btnSendCommand.Text = "Send command";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // btnEndInterpreter
            // 
            this.btnEndInterpreter.Location = new System.Drawing.Point(3, 74);
            this.btnEndInterpreter.Name = "btnEndInterpreter";
            this.btnEndInterpreter.Size = new System.Drawing.Size(152, 23);
            this.btnEndInterpreter.TabIndex = 1;
            this.btnEndInterpreter.Text = "End interpreter";
            this.btnEndInterpreter.UseVisualStyleBackColor = true;
            this.btnEndInterpreter.Click += new System.EventHandler(this.btnEndInterpreter_Click);
            // 
            // btnClearInterpreter
            // 
            this.btnClearInterpreter.Location = new System.Drawing.Point(3, 103);
            this.btnClearInterpreter.Name = "btnClearInterpreter";
            this.btnClearInterpreter.Size = new System.Drawing.Size(152, 23);
            this.btnClearInterpreter.TabIndex = 1;
            this.btnClearInterpreter.Text = "Clear interpreter";
            this.btnClearInterpreter.UseVisualStyleBackColor = true;
            this.btnClearInterpreter.Click += new System.EventHandler(this.btnClearInterpreter_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(3, 132);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(152, 23);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnSkipBuffer
            // 
            this.btnSkipBuffer.Location = new System.Drawing.Point(3, 161);
            this.btnSkipBuffer.Name = "btnSkipBuffer";
            this.btnSkipBuffer.Size = new System.Drawing.Size(152, 23);
            this.btnSkipBuffer.TabIndex = 1;
            this.btnSkipBuffer.Text = "Skip buffer";
            this.btnSkipBuffer.UseVisualStyleBackColor = true;
            this.btnSkipBuffer.Click += new System.EventHandler(this.btnSkipBuffer_Click);
            // 
            // btnLastExecuted
            // 
            this.btnLastExecuted.Location = new System.Drawing.Point(3, 209);
            this.btnLastExecuted.Name = "btnLastExecuted";
            this.btnLastExecuted.Size = new System.Drawing.Size(152, 23);
            this.btnLastExecuted.TabIndex = 1;
            this.btnLastExecuted.Text = "Get last executed";
            this.btnLastExecuted.UseVisualStyleBackColor = true;
            this.btnLastExecuted.Click += new System.EventHandler(this.btnLastExecuted_Click);
            // 
            // btnLastInterpreted
            // 
            this.btnLastInterpreted.Location = new System.Drawing.Point(3, 238);
            this.btnLastInterpreted.Name = "btnLastInterpreted";
            this.btnLastInterpreted.Size = new System.Drawing.Size(152, 23);
            this.btnLastInterpreted.TabIndex = 1;
            this.btnLastInterpreted.Text = "Get last interpreted";
            this.btnLastInterpreted.UseVisualStyleBackColor = true;
            this.btnLastInterpreted.Click += new System.EventHandler(this.btnLastInterpreted_Click);
            // 
            // btnLastCleared
            // 
            this.btnLastCleared.Location = new System.Drawing.Point(3, 267);
            this.btnLastCleared.Name = "btnLastCleared";
            this.btnLastCleared.Size = new System.Drawing.Size(152, 23);
            this.btnLastCleared.TabIndex = 1;
            this.btnLastCleared.Text = "Get last cleared";
            this.btnLastCleared.UseVisualStyleBackColor = true;
            this.btnLastCleared.Click += new System.EventHandler(this.btnLastCleared_Click);
            // 
            // btnLastUnexecuted
            // 
            this.btnLastUnexecuted.Location = new System.Drawing.Point(3, 296);
            this.btnLastUnexecuted.Name = "btnLastUnexecuted";
            this.btnLastUnexecuted.Size = new System.Drawing.Size(152, 23);
            this.btnLastUnexecuted.TabIndex = 1;
            this.btnLastUnexecuted.Text = "Get last unexecuted";
            this.btnLastUnexecuted.UseVisualStyleBackColor = true;
            this.btnLastUnexecuted.Click += new System.EventHandler(this.btnLastUnexecuted_Click);
            // 
            // InterpreterModeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Name = "InterpreterModeControl";
            this.Size = new System.Drawing.Size(1240, 710);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
            this.splitMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer splitMain;
        internal System.Windows.Forms.RichTextBox txtConsole;
    private System.Windows.Forms.Panel pnlMain;
    internal System.Windows.Forms.TextBox txtCommand;
    internal System.Windows.Forms.Button btnEndInterpreter;
    internal System.Windows.Forms.Button btnSendCommand;
    internal System.Windows.Forms.Button btnClearInterpreter;
    internal System.Windows.Forms.Button btnAbort;
    internal System.Windows.Forms.Button btnSkipBuffer;
    internal System.Windows.Forms.Button btnLastExecuted;
    internal System.Windows.Forms.Button btnLastInterpreted;
    internal System.Windows.Forms.Button btnLastCleared;
    internal System.Windows.Forms.Button btnLastUnexecuted;
}

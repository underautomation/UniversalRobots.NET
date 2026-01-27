    partial class RestControl
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
        splitMain = new SplitContainer();
        txtConsole = new RichTextBox();
        pnlMain = new Panel();
        groupBox2 = new GroupBox();
        pictureBox1 = new PictureBox();
        groupBox1 = new GroupBox();
        txtLoadProgram = new TextBox();
        btnLoadProgram = new Button();
        btnGetProgramState = new Button();
        btnResume = new Button();
        btnStop = new Button();
        btnPause = new Button();
        btnPlay = new Button();
        GroupBox5 = new GroupBox();
        btnRestartSafety = new Button();
        btnUnlockProtectiveStop = new Button();
        btnBrakeRelease = new Button();
        btnPowerOff = new Button();
        btnPowerOn = new Button();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        pnlMain.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        groupBox1.SuspendLayout();
        GroupBox5.SuspendLayout();
        SuspendLayout();
        // 
        // splitMain
        // 
        splitMain.BorderStyle = BorderStyle.Fixed3D;
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 0);
        splitMain.Margin = new Padding(4, 3, 4, 3);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(txtConsole);
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.AutoScroll = true;
        splitMain.Panel2.Controls.Add(pnlMain);
        splitMain.Size = new Size(1447, 819);
        splitMain.SplitterDistance = 481;
        splitMain.SplitterWidth = 5;
        splitMain.TabIndex = 1;
        // 
        // txtConsole
        // 
        txtConsole.BackColor = Color.Black;
        txtConsole.BorderStyle = BorderStyle.None;
        txtConsole.Dock = DockStyle.Fill;
        txtConsole.ForeColor = Color.White;
        txtConsole.Location = new Point(0, 0);
        txtConsole.Margin = new Padding(4, 3, 4, 3);
        txtConsole.Name = "txtConsole";
        txtConsole.ReadOnly = true;
        txtConsole.Size = new Size(477, 815);
        txtConsole.TabIndex = 0;
        txtConsole.Text = "Please use commands on the right panel.\n\n> ";
        // 
        // pnlMain
        // 
        pnlMain.Controls.Add(groupBox2);
        pnlMain.Controls.Add(groupBox1);
        pnlMain.Controls.Add(GroupBox5);
        pnlMain.Dock = DockStyle.Fill;
        pnlMain.Location = new Point(0, 0);
        pnlMain.Margin = new Padding(4, 3, 4, 3);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(957, 815);
        pnlMain.TabIndex = 9;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(pictureBox1);
        groupBox2.Location = new Point(4, 266);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(462, 449);
        groupBox2.TabIndex = 9;
        groupBox2.TabStop = false;
        groupBox2.Text = "How to switch to remote mode?";
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = UnderAutomation.UniversalRobots.Showcase.Forms.Properties.Resources.remote_polyscopex;
        pictureBox1.Location = new Point(3, 19);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(456, 427);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 8;
        pictureBox1.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txtLoadProgram);
        groupBox1.Controls.Add(btnLoadProgram);
        groupBox1.Controls.Add(btnGetProgramState);
        groupBox1.Controls.Add(btnResume);
        groupBox1.Controls.Add(btnStop);
        groupBox1.Controls.Add(btnPause);
        groupBox1.Controls.Add(btnPlay);
        groupBox1.Location = new Point(204, 3);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(262, 244);
        groupBox1.TabIndex = 7;
        groupBox1.TabStop = false;
        groupBox1.Text = "Robot Program";
        // 
        // txtLoadProgram
        // 
        txtLoadProgram.Location = new Point(7, 23);
        txtLoadProgram.Name = "txtLoadProgram";
        txtLoadProgram.Size = new Size(126, 23);
        txtLoadProgram.TabIndex = 1;
        txtLoadProgram.Text = "prg.urp";
        // 
        // btnLoadProgram
        // 
        btnLoadProgram.Location = new Point(139, 23);
        btnLoadProgram.Name = "btnLoadProgram";
        btnLoadProgram.Size = new Size(116, 23);
        btnLoadProgram.TabIndex = 0;
        btnLoadProgram.Text = "Load Program";
        btnLoadProgram.UseVisualStyleBackColor = true;
        btnLoadProgram.Click += btnLoadProgram_Click;
        // 
        // btnGetProgramState
        // 
        btnGetProgramState.Location = new Point(35, 194);
        btnGetProgramState.Name = "btnGetProgramState";
        btnGetProgramState.Size = new Size(174, 23);
        btnGetProgramState.TabIndex = 0;
        btnGetProgramState.Text = "Get Program State";
        btnGetProgramState.UseVisualStyleBackColor = true;
        btnGetProgramState.Click += btnGetProgramState_Click;
        // 
        // btnResume
        // 
        btnResume.Location = new Point(35, 138);
        btnResume.Name = "btnResume";
        btnResume.Size = new Size(174, 23);
        btnResume.TabIndex = 0;
        btnResume.Text = "Resume";
        btnResume.UseVisualStyleBackColor = true;
        btnResume.Click += btnResume_Click;
        // 
        // btnStop
        // 
        btnStop.Location = new Point(35, 109);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(174, 23);
        btnStop.TabIndex = 0;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // btnPause
        // 
        btnPause.Location = new Point(35, 80);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(174, 23);
        btnPause.TabIndex = 0;
        btnPause.Text = "Pause";
        btnPause.UseVisualStyleBackColor = true;
        btnPause.Click += btnPause_Click;
        // 
        // btnPlay
        // 
        btnPlay.Location = new Point(35, 52);
        btnPlay.Name = "btnPlay";
        btnPlay.Size = new Size(174, 23);
        btnPlay.TabIndex = 0;
        btnPlay.Text = "Play";
        btnPlay.UseVisualStyleBackColor = true;
        btnPlay.Click += btnPlay_Click;
        // 
        // GroupBox5
        // 
        GroupBox5.Controls.Add(btnRestartSafety);
        GroupBox5.Controls.Add(btnUnlockProtectiveStop);
        GroupBox5.Controls.Add(btnBrakeRelease);
        GroupBox5.Controls.Add(btnPowerOff);
        GroupBox5.Controls.Add(btnPowerOn);
        GroupBox5.Location = new Point(4, 3);
        GroupBox5.Margin = new Padding(4, 3, 4, 3);
        GroupBox5.Name = "GroupBox5";
        GroupBox5.Padding = new Padding(4, 3, 4, 3);
        GroupBox5.Size = new Size(188, 244);
        GroupBox5.TabIndex = 7;
        GroupBox5.TabStop = false;
        GroupBox5.Text = "Robot State";
        // 
        // btnRestartSafety
        // 
        btnRestartSafety.Location = new Point(7, 138);
        btnRestartSafety.Name = "btnRestartSafety";
        btnRestartSafety.Size = new Size(174, 23);
        btnRestartSafety.TabIndex = 0;
        btnRestartSafety.Text = "Restart Safety";
        btnRestartSafety.UseVisualStyleBackColor = true;
        btnRestartSafety.Click += btnRestartSafety_Click;
        // 
        // btnUnlockProtectiveStop
        // 
        btnUnlockProtectiveStop.Location = new Point(7, 109);
        btnUnlockProtectiveStop.Name = "btnUnlockProtectiveStop";
        btnUnlockProtectiveStop.Size = new Size(174, 23);
        btnUnlockProtectiveStop.TabIndex = 0;
        btnUnlockProtectiveStop.Text = "Unlock Protective Stop";
        btnUnlockProtectiveStop.UseVisualStyleBackColor = true;
        btnUnlockProtectiveStop.Click += btnUnlockProtectiveStop_Click;
        // 
        // btnBrakeRelease
        // 
        btnBrakeRelease.Location = new Point(7, 80);
        btnBrakeRelease.Name = "btnBrakeRelease";
        btnBrakeRelease.Size = new Size(174, 23);
        btnBrakeRelease.TabIndex = 0;
        btnBrakeRelease.Text = "Brake Release";
        btnBrakeRelease.UseVisualStyleBackColor = true;
        btnBrakeRelease.Click += btnBrakeRelease_Click;
        // 
        // btnPowerOff
        // 
        btnPowerOff.Location = new Point(7, 51);
        btnPowerOff.Name = "btnPowerOff";
        btnPowerOff.Size = new Size(174, 23);
        btnPowerOff.TabIndex = 0;
        btnPowerOff.Text = "Power Off";
        btnPowerOff.UseVisualStyleBackColor = true;
        btnPowerOff.Click += btnPowerOff_Click;
        // 
        // btnPowerOn
        // 
        btnPowerOn.Location = new Point(7, 22);
        btnPowerOn.Name = "btnPowerOn";
        btnPowerOn.Size = new Size(174, 23);
        btnPowerOn.TabIndex = 0;
        btnPowerOn.Text = "Power On";
        btnPowerOn.UseVisualStyleBackColor = true;
        btnPowerOn.Click += btnPowerOn_Click;
        // 
        // RestControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(splitMain);
        Margin = new Padding(4, 3, 4, 3);
        Name = "RestControl";
        Size = new Size(1447, 819);
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        pnlMain.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        GroupBox5.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    internal System.Windows.Forms.SplitContainer splitMain;
        internal System.Windows.Forms.RichTextBox txtConsole;
        internal System.Windows.Forms.GroupBox GroupBox5;
    private System.Windows.Forms.Panel pnlMain;
    internal GroupBox groupBox1;
    private Button btnPowerOn;
    private Button btnRestartSafety;
    private Button btnUnlockProtectiveStop;
    private Button btnBrakeRelease;
    private Button btnPowerOff;
    private TextBox txtLoadProgram;
    private Button btnLoadProgram;
    private Button btnPlay;
    private Button btnGetProgramState;
    private Button btnResume;
    private Button btnStop;
    private Button btnPause;
    private PictureBox pictureBox1;
    private GroupBox groupBox2;
}

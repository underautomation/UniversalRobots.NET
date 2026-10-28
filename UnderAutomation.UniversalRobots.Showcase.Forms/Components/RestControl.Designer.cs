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
        groupBox6 = new GroupBox();
        btnDownloadProgramToFile = new Button();
        btnDownloadProgram = new Button();
        btnUpdateProgramFile = new Button();
        btnUploadProgramFile = new Button();
        btnGetPrograms = new Button();
        txtProgram = new TextBox();
        groupBox4 = new GroupBox();
        btnCloseSafetyPopup = new Button();
        btnClosePopup = new Button();
        btnShowPopupWithTitle = new Button();
        btnShowPopup = new Button();
        txtPopup = new TextBox();
        groupBox3 = new GroupBox();
        btnGetRobotApiVersion = new Button();
        btnGetPolyscopeVersion = new Button();
        btnIsInRemoteControl = new Button();
        btnGetOperationalMode = new Button();
        btnGetSafetyMode = new Button();
        btnGetRobotMode = new Button();
        btnGetLoadedProgram = new Button();
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
        openProgramDialog = new OpenFileDialog();
        saveProgramDialog = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        pnlMain.SuspendLayout();
        groupBox6.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
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
        pnlMain.Controls.Add(groupBox6);
        pnlMain.Controls.Add(groupBox4);
        pnlMain.Controls.Add(groupBox3);
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
        // groupBox6
        // 
        groupBox6.Controls.Add(btnDownloadProgramToFile);
        groupBox6.Controls.Add(btnDownloadProgram);
        groupBox6.Controls.Add(btnUpdateProgramFile);
        groupBox6.Controls.Add(btnUploadProgramFile);
        groupBox6.Controls.Add(btnGetPrograms);
        groupBox6.Controls.Add(txtProgram);
        groupBox6.Location = new Point(480, 250);
        groupBox6.Name = "groupBox6";
        groupBox6.Size = new Size(230, 198);
        groupBox6.TabIndex = 12;
        groupBox6.TabStop = false;
        groupBox6.Text = "Programs";
        // 
        // btnDownloadProgramToFile
        // 
        btnDownloadProgramToFile.Location = new Point(7, 167);
        btnDownloadProgramToFile.Name = "btnDownloadProgramToFile";
        btnDownloadProgramToFile.Size = new Size(216, 23);
        btnDownloadProgramToFile.TabIndex = 5;
        btnDownloadProgramToFile.Text = "Download Program To File...";
        btnDownloadProgramToFile.UseVisualStyleBackColor = true;
        btnDownloadProgramToFile.Click += btnDownloadProgramToFile_Click;
        // 
        // btnDownloadProgram
        // 
        btnDownloadProgram.Location = new Point(7, 138);
        btnDownloadProgram.Name = "btnDownloadProgram";
        btnDownloadProgram.Size = new Size(216, 23);
        btnDownloadProgram.TabIndex = 4;
        btnDownloadProgram.Text = "Download Program";
        btnDownloadProgram.UseVisualStyleBackColor = true;
        btnDownloadProgram.Click += btnDownloadProgram_Click;
        // 
        // btnUpdateProgramFile
        // 
        btnUpdateProgramFile.Location = new Point(7, 109);
        btnUpdateProgramFile.Name = "btnUpdateProgramFile";
        btnUpdateProgramFile.Size = new Size(216, 23);
        btnUpdateProgramFile.TabIndex = 3;
        btnUpdateProgramFile.Text = "Update Program File...";
        btnUpdateProgramFile.UseVisualStyleBackColor = true;
        btnUpdateProgramFile.Click += btnUpdateProgramFile_Click;
        // 
        // btnUploadProgramFile
        // 
        btnUploadProgramFile.Location = new Point(7, 80);
        btnUploadProgramFile.Name = "btnUploadProgramFile";
        btnUploadProgramFile.Size = new Size(216, 23);
        btnUploadProgramFile.TabIndex = 2;
        btnUploadProgramFile.Text = "Upload Program File...";
        btnUploadProgramFile.UseVisualStyleBackColor = true;
        btnUploadProgramFile.Click += btnUploadProgramFile_Click;
        // 
        // btnGetPrograms
        // 
        btnGetPrograms.Location = new Point(7, 51);
        btnGetPrograms.Name = "btnGetPrograms";
        btnGetPrograms.Size = new Size(216, 23);
        btnGetPrograms.TabIndex = 1;
        btnGetPrograms.Text = "Get Programs";
        btnGetPrograms.UseVisualStyleBackColor = true;
        btnGetPrograms.Click += btnGetPrograms_Click;
        // 
        // txtProgram
        // 
        txtProgram.Location = new Point(7, 22);
        txtProgram.Name = "txtProgram";
        txtProgram.Size = new Size(216, 23);
        txtProgram.TabIndex = 0;
        txtProgram.Text = "my_program";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnCloseSafetyPopup);
        groupBox4.Controls.Add(btnClosePopup);
        groupBox4.Controls.Add(btnShowPopupWithTitle);
        groupBox4.Controls.Add(btnShowPopup);
        groupBox4.Controls.Add(txtPopup);
        groupBox4.Location = new Point(480, 470);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(230, 169);
        groupBox4.TabIndex = 11;
        groupBox4.TabStop = false;
        groupBox4.Text = "Popups";
        // 
        // btnCloseSafetyPopup
        // 
        btnCloseSafetyPopup.Location = new Point(7, 138);
        btnCloseSafetyPopup.Name = "btnCloseSafetyPopup";
        btnCloseSafetyPopup.Size = new Size(216, 23);
        btnCloseSafetyPopup.TabIndex = 4;
        btnCloseSafetyPopup.Text = "Close Safety Popup";
        btnCloseSafetyPopup.UseVisualStyleBackColor = true;
        btnCloseSafetyPopup.Click += btnCloseSafetyPopup_Click;
        // 
        // btnClosePopup
        // 
        btnClosePopup.Location = new Point(7, 109);
        btnClosePopup.Name = "btnClosePopup";
        btnClosePopup.Size = new Size(216, 23);
        btnClosePopup.TabIndex = 3;
        btnClosePopup.Text = "Close Popup";
        btnClosePopup.UseVisualStyleBackColor = true;
        btnClosePopup.Click += btnClosePopup_Click;
        // 
        // btnShowPopupWithTitle
        // 
        btnShowPopupWithTitle.Location = new Point(7, 80);
        btnShowPopupWithTitle.Name = "btnShowPopupWithTitle";
        btnShowPopupWithTitle.Size = new Size(216, 23);
        btnShowPopupWithTitle.TabIndex = 2;
        btnShowPopupWithTitle.Text = "Show Popup With Title";
        btnShowPopupWithTitle.UseVisualStyleBackColor = true;
        btnShowPopupWithTitle.Click += btnShowPopupWithTitle_Click;
        // 
        // btnShowPopup
        // 
        btnShowPopup.Location = new Point(7, 51);
        btnShowPopup.Name = "btnShowPopup";
        btnShowPopup.Size = new Size(216, 23);
        btnShowPopup.TabIndex = 1;
        btnShowPopup.Text = "Show Popup";
        btnShowPopup.UseVisualStyleBackColor = true;
        btnShowPopup.Click += btnShowPopup_Click;
        // 
        // txtPopup
        // 
        txtPopup.Location = new Point(7, 22);
        txtPopup.Name = "txtPopup";
        txtPopup.Size = new Size(216, 23);
        txtPopup.TabIndex = 0;
        txtPopup.Text = "Hello from the SDK";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnGetRobotApiVersion);
        groupBox3.Controls.Add(btnGetPolyscopeVersion);
        groupBox3.Controls.Add(btnIsInRemoteControl);
        groupBox3.Controls.Add(btnGetOperationalMode);
        groupBox3.Controls.Add(btnGetSafetyMode);
        groupBox3.Controls.Add(btnGetRobotMode);
        groupBox3.Controls.Add(btnGetLoadedProgram);
        groupBox3.Location = new Point(480, 3);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(230, 227);
        groupBox3.TabIndex = 10;
        groupBox3.TabStop = false;
        groupBox3.Text = "Information";
        // 
        // btnGetRobotApiVersion
        // 
        btnGetRobotApiVersion.Location = new Point(7, 196);
        btnGetRobotApiVersion.Name = "btnGetRobotApiVersion";
        btnGetRobotApiVersion.Size = new Size(216, 23);
        btnGetRobotApiVersion.TabIndex = 6;
        btnGetRobotApiVersion.Text = "Get Robot API Version";
        btnGetRobotApiVersion.UseVisualStyleBackColor = true;
        btnGetRobotApiVersion.Click += btnGetRobotApiVersion_Click;
        // 
        // btnGetPolyscopeVersion
        // 
        btnGetPolyscopeVersion.Location = new Point(7, 167);
        btnGetPolyscopeVersion.Name = "btnGetPolyscopeVersion";
        btnGetPolyscopeVersion.Size = new Size(216, 23);
        btnGetPolyscopeVersion.TabIndex = 5;
        btnGetPolyscopeVersion.Text = "Get Polyscope Version";
        btnGetPolyscopeVersion.UseVisualStyleBackColor = true;
        btnGetPolyscopeVersion.Click += btnGetPolyscopeVersion_Click;
        // 
        // btnIsInRemoteControl
        // 
        btnIsInRemoteControl.Location = new Point(7, 138);
        btnIsInRemoteControl.Name = "btnIsInRemoteControl";
        btnIsInRemoteControl.Size = new Size(216, 23);
        btnIsInRemoteControl.TabIndex = 4;
        btnIsInRemoteControl.Text = "Is In Remote Control?";
        btnIsInRemoteControl.UseVisualStyleBackColor = true;
        btnIsInRemoteControl.Click += btnIsInRemoteControl_Click;
        // 
        // btnGetOperationalMode
        // 
        btnGetOperationalMode.Location = new Point(7, 109);
        btnGetOperationalMode.Name = "btnGetOperationalMode";
        btnGetOperationalMode.Size = new Size(216, 23);
        btnGetOperationalMode.TabIndex = 3;
        btnGetOperationalMode.Text = "Get Operational Mode";
        btnGetOperationalMode.UseVisualStyleBackColor = true;
        btnGetOperationalMode.Click += btnGetOperationalMode_Click;
        // 
        // btnGetSafetyMode
        // 
        btnGetSafetyMode.Location = new Point(7, 80);
        btnGetSafetyMode.Name = "btnGetSafetyMode";
        btnGetSafetyMode.Size = new Size(216, 23);
        btnGetSafetyMode.TabIndex = 2;
        btnGetSafetyMode.Text = "Get Safety Mode";
        btnGetSafetyMode.UseVisualStyleBackColor = true;
        btnGetSafetyMode.Click += btnGetSafetyMode_Click;
        // 
        // btnGetRobotMode
        // 
        btnGetRobotMode.Location = new Point(7, 51);
        btnGetRobotMode.Name = "btnGetRobotMode";
        btnGetRobotMode.Size = new Size(216, 23);
        btnGetRobotMode.TabIndex = 1;
        btnGetRobotMode.Text = "Get Robot Mode";
        btnGetRobotMode.UseVisualStyleBackColor = true;
        btnGetRobotMode.Click += btnGetRobotMode_Click;
        // 
        // btnGetLoadedProgram
        // 
        btnGetLoadedProgram.Location = new Point(7, 22);
        btnGetLoadedProgram.Name = "btnGetLoadedProgram";
        btnGetLoadedProgram.Size = new Size(216, 23);
        btnGetLoadedProgram.TabIndex = 0;
        btnGetLoadedProgram.Text = "Get Loaded Program";
        btnGetLoadedProgram.UseVisualStyleBackColor = true;
        btnGetLoadedProgram.Click += btnGetLoadedProgram_Click;
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
        txtLoadProgram.Text = "program";
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
        // openProgramDialog
        // 
        openProgramDialog.Filter = "All files|*.*";
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
        groupBox6.ResumeLayout(false);
        groupBox6.PerformLayout();
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        groupBox3.ResumeLayout(false);
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
    private GroupBox groupBox3;
    private Button btnGetLoadedProgram;
    private Button btnGetRobotMode;
    private Button btnGetSafetyMode;
    private Button btnGetOperationalMode;
    private Button btnIsInRemoteControl;
    private Button btnGetPolyscopeVersion;
    private Button btnGetRobotApiVersion;
    private GroupBox groupBox4;
    private TextBox txtPopup;
    private Button btnShowPopup;
    private Button btnShowPopupWithTitle;
    private Button btnClosePopup;
    private Button btnCloseSafetyPopup;
    private GroupBox groupBox6;
    private TextBox txtProgram;
    private Button btnGetPrograms;
    private Button btnUploadProgramFile;
    private Button btnUpdateProgramFile;
    private Button btnDownloadProgram;
    private Button btnDownloadProgramToFile;
    private OpenFileDialog openProgramDialog;
    private SaveFileDialog saveProgramDialog;
}

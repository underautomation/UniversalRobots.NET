    partial class DashboardServerControl
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
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.cbOperationalMode = new System.Windows.Forms.ComboBox();
            this.cbUserRoles = new System.Windows.Forms.ComboBox();
            this.btnIsInRemoteControl = new System.Windows.Forms.Button();
            this.btnSetUserRole = new System.Windows.Forms.Button();
            this.btnSetOperationalMode = new System.Windows.Forms.Button();
            this.btnClearOIperationalMode = new System.Windows.Forms.Button();
            this.btnGetOperationalMode = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClosePopup = new System.Windows.Forms.Button();
            this.btnShowPopup = new System.Windows.Forms.Button();
            this.txtPopup = new System.Windows.Forms.TextBox();
            this.btnAddToLog = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPolyscopeVersion = new System.Windows.Forms.Button();
            this.txtInstallation = new System.Windows.Forms.TextBox();
            this.btnGetSerialNumber = new System.Windows.Forms.Button();
            this.btnGetRobotModel = new System.Windows.Forms.Button();
            this.btnLoadInstallation = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCloseSafetyPopup = new System.Windows.Forms.Button();
            this.btnSafetyStatus = new System.Windows.Forms.Button();
            this.btnRestartSafety = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLoadProgram = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.btnIsProgramSaved = new System.Windows.Forms.Button();
            this.btnProgrammRunning = new System.Windows.Forms.Button();
            this.btnGetProgramState = new System.Windows.Forms.Button();
            this.btnGetLoadedProgram = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPowerOn = new System.Windows.Forms.Button();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.ReaseBrake = new System.Windows.Forms.Button();
            this.btnUnlockProtectiveStop = new System.Windows.Forms.Button();
            this.btnGetRobotMode = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomCommand = new System.Windows.Forms.TextBox();
            this.txtSendCustomCommand = new System.Windows.Forms.Button();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.btnGetVariableValue = new System.Windows.Forms.Button();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.GroupBox6);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.GroupBox5);
            this.pnlMain.Controls.Add(this.GroupBox4);
            this.pnlMain.Controls.Add(this.GroupBox3);
            this.pnlMain.Controls.Add(this.GroupBox1);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(436, 582);
            this.pnlMain.TabIndex = 9;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.cbOperationalMode);
            this.GroupBox6.Controls.Add(this.cbUserRoles);
            this.GroupBox6.Controls.Add(this.btnIsInRemoteControl);
            this.GroupBox6.Controls.Add(this.btnSetUserRole);
            this.GroupBox6.Controls.Add(this.btnSetOperationalMode);
            this.GroupBox6.Controls.Add(this.btnClearOIperationalMode);
            this.GroupBox6.Controls.Add(this.btnGetOperationalMode);
            this.GroupBox6.Location = new System.Drawing.Point(175, 231);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(253, 165);
            this.GroupBox6.TabIndex = 8;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Operational modes";
            // 
            // cbOperationalMode
            // 
            this.cbOperationalMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationalMode.FormattingEnabled = true;
            this.cbOperationalMode.Location = new System.Drawing.Point(6, 76);
            this.cbOperationalMode.Name = "cbOperationalMode";
            this.cbOperationalMode.Size = new System.Drawing.Size(123, 21);
            this.cbOperationalMode.TabIndex = 3;
            // 
            // cbUserRoles
            // 
            this.cbUserRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRoles.FormattingEnabled = true;
            this.cbUserRoles.Location = new System.Drawing.Point(6, 107);
            this.cbUserRoles.Name = "cbUserRoles";
            this.cbUserRoles.Size = new System.Drawing.Size(123, 21);
            this.cbUserRoles.TabIndex = 2;
            // 
            // btnIsInRemoteControl
            // 
            this.btnIsInRemoteControl.Location = new System.Drawing.Point(6, 134);
            this.btnIsInRemoteControl.Name = "btnIsInRemoteControl";
            this.btnIsInRemoteControl.Size = new System.Drawing.Size(237, 23);
            this.btnIsInRemoteControl.TabIndex = 0;
            this.btnIsInRemoteControl.Text = "Is robot in remote control ?";
            this.btnIsInRemoteControl.UseVisualStyleBackColor = true;
            this.btnIsInRemoteControl.Click += new System.EventHandler(this.btnIsInRemoteControl_Click);
            // 
            // btnSetUserRole
            // 
            this.btnSetUserRole.Location = new System.Drawing.Point(132, 106);
            this.btnSetUserRole.Name = "btnSetUserRole";
            this.btnSetUserRole.Size = new System.Drawing.Size(111, 23);
            this.btnSetUserRole.TabIndex = 0;
            this.btnSetUserRole.Text = "Set role (old FW)";
            this.btnSetUserRole.UseVisualStyleBackColor = true;
            this.btnSetUserRole.Click += new System.EventHandler(this.btnSetUserRole_Click);
            // 
            // btnSetOperationalMode
            // 
            this.btnSetOperationalMode.Location = new System.Drawing.Point(132, 75);
            this.btnSetOperationalMode.Name = "btnSetOperationalMode";
            this.btnSetOperationalMode.Size = new System.Drawing.Size(111, 23);
            this.btnSetOperationalMode.TabIndex = 0;
            this.btnSetOperationalMode.Text = "Set operational mode";
            this.btnSetOperationalMode.UseVisualStyleBackColor = true;
            this.btnSetOperationalMode.Click += new System.EventHandler(this.btnSetOperationalMode_Click);
            // 
            // btnClearOIperationalMode
            // 
            this.btnClearOIperationalMode.Location = new System.Drawing.Point(6, 48);
            this.btnClearOIperationalMode.Name = "btnClearOIperationalMode";
            this.btnClearOIperationalMode.Size = new System.Drawing.Size(237, 23);
            this.btnClearOIperationalMode.TabIndex = 0;
            this.btnClearOIperationalMode.Text = "Clear operational mode";
            this.btnClearOIperationalMode.UseVisualStyleBackColor = true;
            this.btnClearOIperationalMode.Click += new System.EventHandler(this.btnClearOIperationalMode_Click);
            // 
            // btnGetOperationalMode
            // 
            this.btnGetOperationalMode.Location = new System.Drawing.Point(6, 19);
            this.btnGetOperationalMode.Name = "btnGetOperationalMode";
            this.btnGetOperationalMode.Size = new System.Drawing.Size(237, 23);
            this.btnGetOperationalMode.TabIndex = 0;
            this.btnGetOperationalMode.Text = "Get operational mode";
            this.btnGetOperationalMode.UseVisualStyleBackColor = true;
            this.btnGetOperationalMode.Click += new System.EventHandler(this.btnGetOperationalMode_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnClosePopup);
            this.GroupBox5.Controls.Add(this.btnShowPopup);
            this.GroupBox5.Controls.Add(this.txtPopup);
            this.GroupBox5.Controls.Add(this.btnAddToLog);
            this.GroupBox5.Controls.Add(this.txtLog);
            this.GroupBox5.Controls.Add(this.btnPolyscopeVersion);
            this.GroupBox5.Controls.Add(this.txtInstallation);
            this.GroupBox5.Controls.Add(this.btnGetSerialNumber);
            this.GroupBox5.Controls.Add(this.btnGetRobotModel);
            this.GroupBox5.Controls.Add(this.btnLoadInstallation);
            this.GroupBox5.Location = new System.Drawing.Point(175, 0);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(253, 225);
            this.GroupBox5.TabIndex = 7;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Information";
            // 
            // btnClosePopup
            // 
            this.btnClosePopup.Location = new System.Drawing.Point(8, 48);
            this.btnClosePopup.Name = "btnClosePopup";
            this.btnClosePopup.Size = new System.Drawing.Size(235, 23);
            this.btnClosePopup.TabIndex = 0;
            this.btnClosePopup.Text = "Close popup";
            this.btnClosePopup.UseVisualStyleBackColor = true;
            this.btnClosePopup.Click += new System.EventHandler(this.btnClosePopup_Click);
            // 
            // btnShowPopup
            // 
            this.btnShowPopup.Location = new System.Drawing.Point(150, 20);
            this.btnShowPopup.Name = "btnShowPopup";
            this.btnShowPopup.Size = new System.Drawing.Size(93, 23);
            this.btnShowPopup.TabIndex = 0;
            this.btnShowPopup.Text = "Show popup";
            this.btnShowPopup.UseVisualStyleBackColor = true;
            this.btnShowPopup.Click += new System.EventHandler(this.btnShowPopup_Click);
            // 
            // txtPopup
            // 
            this.txtPopup.Location = new System.Drawing.Point(8, 22);
            this.txtPopup.Name = "txtPopup";
            this.txtPopup.Size = new System.Drawing.Size(136, 20);
            this.txtPopup.TabIndex = 1;
            this.txtPopup.Text = "This is a popup message !";
            // 
            // btnAddToLog
            // 
            this.btnAddToLog.Location = new System.Drawing.Point(150, 78);
            this.btnAddToLog.Name = "btnAddToLog";
            this.btnAddToLog.Size = new System.Drawing.Size(93, 23);
            this.btnAddToLog.TabIndex = 0;
            this.btnAddToLog.Text = "Add to log";
            this.btnAddToLog.UseVisualStyleBackColor = true;
            this.btnAddToLog.Click += new System.EventHandler(this.btnAddToLog_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(8, 80);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(136, 20);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "This is a log message !";
            // 
            // btnPolyscopeVersion
            // 
            this.btnPolyscopeVersion.Location = new System.Drawing.Point(8, 106);
            this.btnPolyscopeVersion.Name = "btnPolyscopeVersion";
            this.btnPolyscopeVersion.Size = new System.Drawing.Size(235, 23);
            this.btnPolyscopeVersion.TabIndex = 0;
            this.btnPolyscopeVersion.Text = "Get Polyscope version";
            this.btnPolyscopeVersion.UseVisualStyleBackColor = true;
            this.btnPolyscopeVersion.Click += new System.EventHandler(this.btnPolyscopeVersion_Click);
            // 
            // txtInstallation
            // 
            this.txtInstallation.Location = new System.Drawing.Point(6, 138);
            this.txtInstallation.Name = "txtInstallation";
            this.txtInstallation.Size = new System.Drawing.Size(138, 20);
            this.txtInstallation.TabIndex = 1;
            this.txtInstallation.Text = "default.installation";
            // 
            // btnGetSerialNumber
            // 
            this.btnGetSerialNumber.Location = new System.Drawing.Point(6, 164);
            this.btnGetSerialNumber.Name = "btnGetSerialNumber";
            this.btnGetSerialNumber.Size = new System.Drawing.Size(237, 23);
            this.btnGetSerialNumber.TabIndex = 0;
            this.btnGetSerialNumber.Text = "Get serial number";
            this.btnGetSerialNumber.UseVisualStyleBackColor = true;
            this.btnGetSerialNumber.Click += new System.EventHandler(this.btnGetSerialNumber_Click);
            // 
            // btnGetRobotModel
            // 
            this.btnGetRobotModel.Location = new System.Drawing.Point(6, 193);
            this.btnGetRobotModel.Name = "btnGetRobotModel";
            this.btnGetRobotModel.Size = new System.Drawing.Size(237, 23);
            this.btnGetRobotModel.TabIndex = 0;
            this.btnGetRobotModel.Text = "Get robot model";
            this.btnGetRobotModel.UseVisualStyleBackColor = true;
            this.btnGetRobotModel.Click += new System.EventHandler(this.btnGetRobotModel_Click);
            // 
            // btnLoadInstallation
            // 
            this.btnLoadInstallation.Location = new System.Drawing.Point(150, 136);
            this.btnLoadInstallation.Name = "btnLoadInstallation";
            this.btnLoadInstallation.Size = new System.Drawing.Size(93, 23);
            this.btnLoadInstallation.TabIndex = 0;
            this.btnLoadInstallation.Text = "Load installation";
            this.btnLoadInstallation.UseVisualStyleBackColor = true;
            this.btnLoadInstallation.Click += new System.EventHandler(this.btnLoadInstallation_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnCloseSafetyPopup);
            this.GroupBox4.Controls.Add(this.btnSafetyStatus);
            this.GroupBox4.Controls.Add(this.btnRestartSafety);
            this.GroupBox4.Location = new System.Drawing.Point(175, 402);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(253, 110);
            this.GroupBox4.TabIndex = 6;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Safety";
            // 
            // btnCloseSafetyPopup
            // 
            this.btnCloseSafetyPopup.Location = new System.Drawing.Point(8, 48);
            this.btnCloseSafetyPopup.Name = "btnCloseSafetyPopup";
            this.btnCloseSafetyPopup.Size = new System.Drawing.Size(237, 23);
            this.btnCloseSafetyPopup.TabIndex = 0;
            this.btnCloseSafetyPopup.Text = "Close safety popup";
            this.btnCloseSafetyPopup.UseVisualStyleBackColor = true;
            this.btnCloseSafetyPopup.Click += new System.EventHandler(this.btnCloseSafetyPopup_Click);
            // 
            // btnSafetyStatus
            // 
            this.btnSafetyStatus.Location = new System.Drawing.Point(6, 19);
            this.btnSafetyStatus.Name = "btnSafetyStatus";
            this.btnSafetyStatus.Size = new System.Drawing.Size(237, 23);
            this.btnSafetyStatus.TabIndex = 0;
            this.btnSafetyStatus.Text = "Get safety status";
            this.btnSafetyStatus.UseVisualStyleBackColor = true;
            this.btnSafetyStatus.Click += new System.EventHandler(this.btnSafetyStatus_Click);
            // 
            // btnRestartSafety
            // 
            this.btnRestartSafety.Location = new System.Drawing.Point(8, 77);
            this.btnRestartSafety.Name = "btnRestartSafety";
            this.btnRestartSafety.Size = new System.Drawing.Size(237, 23);
            this.btnRestartSafety.TabIndex = 0;
            this.btnRestartSafety.Text = "Restart safety";
            this.btnRestartSafety.UseVisualStyleBackColor = true;
            this.btnRestartSafety.Click += new System.EventHandler(this.btnRestartSafety_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnPlay);
            this.GroupBox3.Controls.Add(this.btnStop);
            this.GroupBox3.Controls.Add(this.btnPause);
            this.GroupBox3.Controls.Add(this.btnGetVariableValue);
            this.GroupBox3.Controls.Add(this.txtVariableName);
            this.GroupBox3.Controls.Add(this.btnLoadProgram);
            this.GroupBox3.Controls.Add(this.txtProgram);
            this.GroupBox3.Controls.Add(this.btnIsProgramSaved);
            this.GroupBox3.Controls.Add(this.btnProgrammRunning);
            this.GroupBox3.Controls.Add(this.btnGetProgramState);
            this.GroupBox3.Controls.Add(this.btnGetLoadedProgram);
            this.GroupBox3.Location = new System.Drawing.Point(1, 204);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(168, 287);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Programs";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 80);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(153, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play program";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(153, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop program";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(6, 138);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(153, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause program";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLoadProgram
            // 
            this.btnLoadProgram.Location = new System.Drawing.Point(79, 23);
            this.btnLoadProgram.Name = "btnLoadProgram";
            this.btnLoadProgram.Size = new System.Drawing.Size(80, 23);
            this.btnLoadProgram.TabIndex = 0;
            this.btnLoadProgram.Text = "Load program";
            this.btnLoadProgram.UseVisualStyleBackColor = true;
            this.btnLoadProgram.Click += new System.EventHandler(this.btnLoadProgram_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(6, 25);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(70, 20);
            this.txtProgram.TabIndex = 1;
            this.txtProgram.Text = "default.urp";
            // 
            // btnIsProgramSaved
            // 
            this.btnIsProgramSaved.Location = new System.Drawing.Point(6, 225);
            this.btnIsProgramSaved.Name = "btnIsProgramSaved";
            this.btnIsProgramSaved.Size = new System.Drawing.Size(153, 23);
            this.btnIsProgramSaved.TabIndex = 0;
            this.btnIsProgramSaved.Text = "Is program saved ?";
            this.btnIsProgramSaved.UseVisualStyleBackColor = true;
            this.btnIsProgramSaved.Click += new System.EventHandler(this.btnIsProgramSaved_Click);
            // 
            // btnProgrammRunning
            // 
            this.btnProgrammRunning.Location = new System.Drawing.Point(6, 167);
            this.btnProgrammRunning.Name = "btnProgrammRunning";
            this.btnProgrammRunning.Size = new System.Drawing.Size(153, 23);
            this.btnProgrammRunning.TabIndex = 0;
            this.btnProgrammRunning.Text = "Is program running ?";
            this.btnProgrammRunning.UseVisualStyleBackColor = true;
            this.btnProgrammRunning.Click += new System.EventHandler(this.btnProgrammRunning_Click);
            // 
            // btnGetProgramState
            // 
            this.btnGetProgramState.Location = new System.Drawing.Point(6, 196);
            this.btnGetProgramState.Name = "btnGetProgramState";
            this.btnGetProgramState.Size = new System.Drawing.Size(153, 23);
            this.btnGetProgramState.TabIndex = 0;
            this.btnGetProgramState.Text = "Get program state";
            this.btnGetProgramState.UseVisualStyleBackColor = true;
            this.btnGetProgramState.Click += new System.EventHandler(this.btnGetProgramState_Click);
            // 
            // btnGetLoadedProgram
            // 
            this.btnGetLoadedProgram.Location = new System.Drawing.Point(6, 51);
            this.btnGetLoadedProgram.Name = "btnGetLoadedProgram";
            this.btnGetLoadedProgram.Size = new System.Drawing.Size(153, 23);
            this.btnGetLoadedProgram.TabIndex = 0;
            this.btnGetLoadedProgram.Text = "Get loaded program";
            this.btnGetLoadedProgram.UseVisualStyleBackColor = true;
            this.btnGetLoadedProgram.Click += new System.EventHandler(this.btnGetLoadedProgram_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnPowerOn);
            this.GroupBox1.Controls.Add(this.btnPowerOff);
            this.GroupBox1.Controls.Add(this.ReaseBrake);
            this.GroupBox1.Controls.Add(this.btnUnlockProtectiveStop);
            this.GroupBox1.Controls.Add(this.btnGetRobotMode);
            this.GroupBox1.Controls.Add(this.btnShutdown);
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(169, 198);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Power commands";
            // 
            // btnPowerOn
            // 
            this.btnPowerOn.Location = new System.Drawing.Point(8, 48);
            this.btnPowerOn.Name = "btnPowerOn";
            this.btnPowerOn.Size = new System.Drawing.Size(152, 23);
            this.btnPowerOn.TabIndex = 0;
            this.btnPowerOn.Text = "Power on";
            this.btnPowerOn.UseVisualStyleBackColor = true;
            this.btnPowerOn.Click += new System.EventHandler(this.btnPowerOn_Click);
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.Location = new System.Drawing.Point(8, 77);
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.Size = new System.Drawing.Size(152, 23);
            this.btnPowerOff.TabIndex = 0;
            this.btnPowerOff.Text = "Power off";
            this.btnPowerOff.UseVisualStyleBackColor = true;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // ReaseBrake
            // 
            this.ReaseBrake.Location = new System.Drawing.Point(8, 106);
            this.ReaseBrake.Name = "ReaseBrake";
            this.ReaseBrake.Size = new System.Drawing.Size(152, 23);
            this.ReaseBrake.TabIndex = 0;
            this.ReaseBrake.Text = "Release brake";
            this.ReaseBrake.UseVisualStyleBackColor = true;
            this.ReaseBrake.Click += new System.EventHandler(this.ReaseBrake_Click);
            // 
            // btnUnlockProtectiveStop
            // 
            this.btnUnlockProtectiveStop.Location = new System.Drawing.Point(8, 135);
            this.btnUnlockProtectiveStop.Name = "btnUnlockProtectiveStop";
            this.btnUnlockProtectiveStop.Size = new System.Drawing.Size(152, 23);
            this.btnUnlockProtectiveStop.TabIndex = 0;
            this.btnUnlockProtectiveStop.Text = "Unlock protective stop";
            this.btnUnlockProtectiveStop.UseVisualStyleBackColor = true;
            this.btnUnlockProtectiveStop.Click += new System.EventHandler(this.btnUnlockProtectiveStop_Click);
            // 
            // btnGetRobotMode
            // 
            this.btnGetRobotMode.Location = new System.Drawing.Point(8, 19);
            this.btnGetRobotMode.Name = "btnGetRobotMode";
            this.btnGetRobotMode.Size = new System.Drawing.Size(152, 23);
            this.btnGetRobotMode.TabIndex = 0;
            this.btnGetRobotMode.Text = "Get robot mode";
            this.btnGetRobotMode.UseVisualStyleBackColor = true;
            this.btnGetRobotMode.Click += new System.EventHandler(this.btnGetRobotMode_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(8, 164);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(152, 23);
            this.btnShutdown.TabIndex = 0;
            this.btnShutdown.Text = "Shutdown robot";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSendCustomCommand);
            this.groupBox2.Controls.Add(this.txtCustomCommand);
            this.groupBox2.Location = new System.Drawing.Point(175, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom";
            // 
            // txtCustomCommand
            // 
            this.txtCustomCommand.Location = new System.Drawing.Point(7, 19);
            this.txtCustomCommand.Name = "txtCustomCommand";
            this.txtCustomCommand.Size = new System.Drawing.Size(137, 20);
            this.txtCustomCommand.TabIndex = 1;
            this.txtCustomCommand.Text = "get loaded program";
            // 
            // txtSendCustomCommand
            // 
            this.txtSendCustomCommand.Location = new System.Drawing.Point(150, 17);
            this.txtSendCustomCommand.Name = "txtSendCustomCommand";
            this.txtSendCustomCommand.Size = new System.Drawing.Size(93, 23);
            this.txtSendCustomCommand.TabIndex = 0;
            this.txtSendCustomCommand.Text = "Send";
            this.txtSendCustomCommand.UseVisualStyleBackColor = true;
            this.txtSendCustomCommand.Click += new System.EventHandler(this.txtSendCustomCommand_Click);
            // 
            // txtVariableName
            // 
            this.txtVariableName.Location = new System.Drawing.Point(6, 256);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(70, 20);
            this.txtVariableName.TabIndex = 1;
            this.txtVariableName.Text = "var_1";
            // 
            // btnGetVariableValue
            // 
            this.btnGetVariableValue.Location = new System.Drawing.Point(79, 254);
            this.btnGetVariableValue.Name = "btnGetVariableValue";
            this.btnGetVariableValue.Size = new System.Drawing.Size(80, 23);
            this.btnGetVariableValue.TabIndex = 0;
            this.btnGetVariableValue.Text = "Get variable";
            this.btnGetVariableValue.UseVisualStyleBackColor = true;
            this.btnGetVariableValue.Click += new System.EventHandler(this.btnGetVariableValue_Click);
            // 
            // DashboardServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMain);
            this.Name = "DashboardServerControl";
            this.Size = new System.Drawing.Size(1240, 710);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer splitMain;
        internal System.Windows.Forms.RichTextBox txtConsole;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.ComboBox cbOperationalMode;
        internal System.Windows.Forms.ComboBox cbUserRoles;
        internal System.Windows.Forms.Button btnIsInRemoteControl;
        internal System.Windows.Forms.Button btnSetUserRole;
        internal System.Windows.Forms.Button btnSetOperationalMode;
        internal System.Windows.Forms.Button btnClearOIperationalMode;
        internal System.Windows.Forms.Button btnGetOperationalMode;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnClosePopup;
        internal System.Windows.Forms.Button btnShowPopup;
        internal System.Windows.Forms.TextBox txtPopup;
        internal System.Windows.Forms.Button btnAddToLog;
        internal System.Windows.Forms.TextBox txtLog;
        internal System.Windows.Forms.Button btnPolyscopeVersion;
        internal System.Windows.Forms.TextBox txtInstallation;
        internal System.Windows.Forms.Button btnGetSerialNumber;
        internal System.Windows.Forms.Button btnGetRobotModel;
        internal System.Windows.Forms.Button btnLoadInstallation;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnCloseSafetyPopup;
        internal System.Windows.Forms.Button btnSafetyStatus;
        internal System.Windows.Forms.Button btnRestartSafety;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnPlay;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnPause;
        internal System.Windows.Forms.Button btnLoadProgram;
        internal System.Windows.Forms.TextBox txtProgram;
        internal System.Windows.Forms.Button btnIsProgramSaved;
        internal System.Windows.Forms.Button btnProgrammRunning;
        internal System.Windows.Forms.Button btnGetProgramState;
        internal System.Windows.Forms.Button btnGetLoadedProgram;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnPowerOn;
        internal System.Windows.Forms.Button btnPowerOff;
        internal System.Windows.Forms.Button ReaseBrake;
        internal System.Windows.Forms.Button btnUnlockProtectiveStop;
        internal System.Windows.Forms.Button btnGetRobotMode;
        internal System.Windows.Forms.Button btnShutdown;
    private System.Windows.Forms.Panel pnlMain;
    internal System.Windows.Forms.GroupBox groupBox2;
    internal System.Windows.Forms.Button txtSendCustomCommand;
    internal System.Windows.Forms.TextBox txtCustomCommand;
    internal System.Windows.Forms.Button btnGetVariableValue;
    internal System.Windows.Forms.TextBox txtVariableName;
}

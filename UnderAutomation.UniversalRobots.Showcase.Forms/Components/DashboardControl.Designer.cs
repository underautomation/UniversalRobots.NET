    partial class DashboardControl
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
        GroupBox7 = new GroupBox();
        btnResume = new Button();
        btnGetSafetyMode = new Button();
        btnGetUserRole = new Button();
        btnSaveLog = new Button();
        cbFlightReportType = new ComboBox();
        btnGenerateFlightReport = new Button();
        txtSupportDirectory = new TextBox();
        btnGenerateSupportFile = new Button();
        GroupBox6 = new GroupBox();
        cbOperationalMode = new ComboBox();
        cbUserRoles = new ComboBox();
        btnIsInRemoteControl = new Button();
        btnSetUserRole = new Button();
        btnSetOperationalMode = new Button();
        btnClearOIperationalMode = new Button();
        btnGetOperationalMode = new Button();
        groupBox2 = new GroupBox();
        txtSendCustomCommand = new Button();
        txtCustomCommand = new TextBox();
        GroupBox5 = new GroupBox();
        btnClosePopup = new Button();
        btnShowPopup = new Button();
        txtPopup = new TextBox();
        btnAddToLog = new Button();
        txtLog = new TextBox();
        btnPolyscopeVersion = new Button();
        txtInstallation = new TextBox();
        btnGetSerialNumber = new Button();
        btnGetRobotModel = new Button();
        btnLoadInstallation = new Button();
        GroupBox4 = new GroupBox();
        btnCloseSafetyPopup = new Button();
        btnSafetyStatus = new Button();
        btnRestartSafety = new Button();
        GroupBox3 = new GroupBox();
        btnPlay = new Button();
        btnStop = new Button();
        btnPause = new Button();
        btnGetVariableValue = new Button();
        txtVariableName = new TextBox();
        btnLoadProgram = new Button();
        txtProgram = new TextBox();
        btnIsProgramSaved = new Button();
        btnProgrammRunning = new Button();
        btnGetProgramState = new Button();
        btnGetLoadedProgram = new Button();
        GroupBox1 = new GroupBox();
        btnPowerOn = new Button();
        btnPowerOff = new Button();
        ReaseBrake = new Button();
        btnUnlockProtectiveStop = new Button();
        btnGetRobotMode = new Button();
        btnShutdown = new Button();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        pnlMain.SuspendLayout();
        GroupBox7.SuspendLayout();
        GroupBox6.SuspendLayout();
        groupBox2.SuspendLayout();
        GroupBox5.SuspendLayout();
        GroupBox4.SuspendLayout();
        GroupBox3.SuspendLayout();
        GroupBox1.SuspendLayout();
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
        pnlMain.Controls.Add(GroupBox7);
        pnlMain.Controls.Add(GroupBox6);
        pnlMain.Controls.Add(groupBox2);
        pnlMain.Controls.Add(GroupBox5);
        pnlMain.Controls.Add(GroupBox4);
        pnlMain.Controls.Add(GroupBox3);
        pnlMain.Controls.Add(GroupBox1);
        pnlMain.Location = new Point(4, 3);
        pnlMain.Margin = new Padding(4, 3, 4, 3);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new Size(844, 668);
        pnlMain.TabIndex = 9;
        // 
        // GroupBox7
        // 
        GroupBox7.Controls.Add(btnSaveLog);
        GroupBox7.Controls.Add(cbFlightReportType);
        GroupBox7.Controls.Add(btnGenerateFlightReport);
        GroupBox7.Controls.Add(txtSupportDirectory);
        GroupBox7.Controls.Add(btnGenerateSupportFile);
        GroupBox7.Location = new Point(506, 0);
        GroupBox7.Margin = new Padding(4, 3, 4, 3);
        GroupBox7.Name = "GroupBox7";
        GroupBox7.Padding = new Padding(4, 3, 4, 3);
        GroupBox7.Size = new Size(295, 133);
        GroupBox7.TabIndex = 10;
        GroupBox7.TabStop = false;
        GroupBox7.Text = "Logs";
        // 
        // btnResume
        // 
        btnResume.Location = new Point(8, 192);
        btnResume.Margin = new Padding(4, 3, 4, 3);
        btnResume.Name = "btnResume";
        btnResume.Size = new Size(177, 27);
        btnResume.TabIndex = 0;
        btnResume.Text = "Resume";
        btnResume.UseVisualStyleBackColor = true;
        btnResume.Click += btnResume_Click;
        // 
        // btnGetSafetyMode
        // 
        btnGetSafetyMode.Location = new Point(7, 55);
        btnGetSafetyMode.Margin = new Padding(4, 3, 4, 3);
        btnGetSafetyMode.Name = "btnGetSafetyMode";
        btnGetSafetyMode.Size = new Size(276, 27);
        btnGetSafetyMode.TabIndex = 1;
        btnGetSafetyMode.Text = "Get safety mode";
        btnGetSafetyMode.UseVisualStyleBackColor = true;
        btnGetSafetyMode.Click += btnGetSafetyMode_Click;
        // 
        // btnGetUserRole
        // 
        btnGetUserRole.Location = new Point(7, 120);
        btnGetUserRole.Margin = new Padding(4, 3, 4, 3);
        btnGetUserRole.Name = "btnGetUserRole";
        btnGetUserRole.Size = new Size(276, 27);
        btnGetUserRole.TabIndex = 2;
        btnGetUserRole.Text = "Get user role";
        btnGetUserRole.UseVisualStyleBackColor = true;
        btnGetUserRole.Click += btnGetUserRole_Click;
        // 
        // btnSaveLog
        // 
        btnSaveLog.Location = new Point(8, 25);
        btnSaveLog.Margin = new Padding(4, 3, 4, 3);
        btnSaveLog.Name = "btnSaveLog";
        btnSaveLog.Size = new Size(276, 27);
        btnSaveLog.TabIndex = 3;
        btnSaveLog.Text = "Save log";
        btnSaveLog.UseVisualStyleBackColor = true;
        btnSaveLog.Click += btnSaveLog_Click;
        // 
        // cbFlightReportType
        // 
        cbFlightReportType.DropDownStyle = ComboBoxStyle.DropDownList;
        cbFlightReportType.FormattingEnabled = true;
        cbFlightReportType.Location = new Point(8, 60);
        cbFlightReportType.Margin = new Padding(4, 3, 4, 3);
        cbFlightReportType.Name = "cbFlightReportType";
        cbFlightReportType.Size = new Size(143, 23);
        cbFlightReportType.TabIndex = 4;
        // 
        // btnGenerateFlightReport
        // 
        btnGenerateFlightReport.Location = new Point(155, 59);
        btnGenerateFlightReport.Margin = new Padding(4, 3, 4, 3);
        btnGenerateFlightReport.Name = "btnGenerateFlightReport";
        btnGenerateFlightReport.Size = new Size(130, 27);
        btnGenerateFlightReport.TabIndex = 5;
        btnGenerateFlightReport.Text = "Flight report";
        btnGenerateFlightReport.UseVisualStyleBackColor = true;
        btnGenerateFlightReport.Click += btnGenerateFlightReport_Click;
        // 
        // txtSupportDirectory
        // 
        txtSupportDirectory.Location = new Point(8, 95);
        txtSupportDirectory.Margin = new Padding(4, 3, 4, 3);
        txtSupportDirectory.Name = "txtSupportDirectory";
        txtSupportDirectory.Size = new Size(143, 23);
        txtSupportDirectory.TabIndex = 6;
        txtSupportDirectory.Text = "support_dir";
        // 
        // btnGenerateSupportFile
        // 
        btnGenerateSupportFile.Location = new Point(155, 92);
        btnGenerateSupportFile.Margin = new Padding(4, 3, 4, 3);
        btnGenerateSupportFile.Name = "btnGenerateSupportFile";
        btnGenerateSupportFile.Size = new Size(130, 27);
        btnGenerateSupportFile.TabIndex = 7;
        btnGenerateSupportFile.Text = "Support file";
        btnGenerateSupportFile.UseVisualStyleBackColor = true;
        btnGenerateSupportFile.Click += btnGenerateSupportFile_Click;
        // 
        // GroupBox6
        // 
        GroupBox6.Controls.Add(cbOperationalMode);
        GroupBox6.Controls.Add(btnGetUserRole);
        GroupBox6.Controls.Add(cbUserRoles);
        GroupBox6.Controls.Add(btnIsInRemoteControl);
        GroupBox6.Controls.Add(btnSetUserRole);
        GroupBox6.Controls.Add(btnSetOperationalMode);
        GroupBox6.Controls.Add(btnClearOIperationalMode);
        GroupBox6.Controls.Add(btnGetOperationalMode);
        GroupBox6.Location = new Point(205, 280);
        GroupBox6.Margin = new Padding(4, 3, 4, 3);
        GroupBox6.Name = "GroupBox6";
        GroupBox6.Padding = new Padding(4, 3, 4, 3);
        GroupBox6.Size = new Size(295, 220);
        GroupBox6.TabIndex = 8;
        GroupBox6.TabStop = false;
        GroupBox6.Text = "Operational modes";
        // 
        // cbOperationalMode
        // 
        cbOperationalMode.DropDownStyle = ComboBoxStyle.DropDownList;
        cbOperationalMode.FormattingEnabled = true;
        cbOperationalMode.Location = new Point(7, 88);
        cbOperationalMode.Margin = new Padding(4, 3, 4, 3);
        cbOperationalMode.Name = "cbOperationalMode";
        cbOperationalMode.Size = new Size(143, 23);
        cbOperationalMode.TabIndex = 3;
        // 
        // cbUserRoles
        // 
        cbUserRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        cbUserRoles.FormattingEnabled = true;
        cbUserRoles.Location = new Point(7, 153);
        cbUserRoles.Margin = new Padding(4, 3, 4, 3);
        cbUserRoles.Name = "cbUserRoles";
        cbUserRoles.Size = new Size(143, 23);
        cbUserRoles.TabIndex = 2;
        // 
        // btnIsInRemoteControl
        // 
        btnIsInRemoteControl.Location = new Point(7, 185);
        btnIsInRemoteControl.Margin = new Padding(4, 3, 4, 3);
        btnIsInRemoteControl.Name = "btnIsInRemoteControl";
        btnIsInRemoteControl.Size = new Size(276, 27);
        btnIsInRemoteControl.TabIndex = 0;
        btnIsInRemoteControl.Text = "Is robot in remote control ?";
        btnIsInRemoteControl.UseVisualStyleBackColor = true;
        btnIsInRemoteControl.Click += btnIsInRemoteControl_Click;
        // 
        // btnSetUserRole
        // 
        btnSetUserRole.Location = new Point(154, 152);
        btnSetUserRole.Margin = new Padding(4, 3, 4, 3);
        btnSetUserRole.Name = "btnSetUserRole";
        btnSetUserRole.Size = new Size(130, 27);
        btnSetUserRole.TabIndex = 0;
        btnSetUserRole.Text = "Set role (old FW)";
        btnSetUserRole.UseVisualStyleBackColor = true;
        btnSetUserRole.Click += btnSetUserRole_Click;
        // 
        // btnSetOperationalMode
        // 
        btnSetOperationalMode.Location = new Point(154, 87);
        btnSetOperationalMode.Margin = new Padding(4, 3, 4, 3);
        btnSetOperationalMode.Name = "btnSetOperationalMode";
        btnSetOperationalMode.Size = new Size(130, 27);
        btnSetOperationalMode.TabIndex = 0;
        btnSetOperationalMode.Text = "Set operational mode";
        btnSetOperationalMode.UseVisualStyleBackColor = true;
        btnSetOperationalMode.Click += btnSetOperationalMode_Click;
        // 
        // btnClearOIperationalMode
        // 
        btnClearOIperationalMode.Location = new Point(7, 55);
        btnClearOIperationalMode.Margin = new Padding(4, 3, 4, 3);
        btnClearOIperationalMode.Name = "btnClearOIperationalMode";
        btnClearOIperationalMode.Size = new Size(276, 27);
        btnClearOIperationalMode.TabIndex = 0;
        btnClearOIperationalMode.Text = "Clear operational mode";
        btnClearOIperationalMode.UseVisualStyleBackColor = true;
        btnClearOIperationalMode.Click += btnClearOIperationalMode_Click;
        // 
        // btnGetOperationalMode
        // 
        btnGetOperationalMode.Location = new Point(7, 22);
        btnGetOperationalMode.Margin = new Padding(4, 3, 4, 3);
        btnGetOperationalMode.Name = "btnGetOperationalMode";
        btnGetOperationalMode.Size = new Size(276, 27);
        btnGetOperationalMode.TabIndex = 0;
        btnGetOperationalMode.Text = "Get operational mode";
        btnGetOperationalMode.UseVisualStyleBackColor = true;
        btnGetOperationalMode.Click += btnGetOperationalMode_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtSendCustomCommand);
        groupBox2.Controls.Add(txtCustomCommand);
        groupBox2.Location = new Point(508, 442);
        groupBox2.Margin = new Padding(4, 3, 4, 3);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 3, 4, 3);
        groupBox2.Size = new Size(295, 58);
        groupBox2.TabIndex = 5;
        groupBox2.TabStop = false;
        groupBox2.Text = "Custom";
        // 
        // txtSendCustomCommand
        // 
        txtSendCustomCommand.Location = new Point(175, 20);
        txtSendCustomCommand.Margin = new Padding(4, 3, 4, 3);
        txtSendCustomCommand.Name = "txtSendCustomCommand";
        txtSendCustomCommand.Size = new Size(108, 27);
        txtSendCustomCommand.TabIndex = 0;
        txtSendCustomCommand.Text = "Send";
        txtSendCustomCommand.UseVisualStyleBackColor = true;
        txtSendCustomCommand.Click += txtSendCustomCommand_Click;
        // 
        // txtCustomCommand
        // 
        txtCustomCommand.Location = new Point(8, 22);
        txtCustomCommand.Margin = new Padding(4, 3, 4, 3);
        txtCustomCommand.Name = "txtCustomCommand";
        txtCustomCommand.Size = new Size(159, 23);
        txtCustomCommand.TabIndex = 1;
        txtCustomCommand.Text = "get loaded program";
        // 
        // GroupBox5
        // 
        GroupBox5.Controls.Add(btnClosePopup);
        GroupBox5.Controls.Add(btnShowPopup);
        GroupBox5.Controls.Add(txtPopup);
        GroupBox5.Controls.Add(btnAddToLog);
        GroupBox5.Controls.Add(txtLog);
        GroupBox5.Controls.Add(btnPolyscopeVersion);
        GroupBox5.Controls.Add(txtInstallation);
        GroupBox5.Controls.Add(btnGetSerialNumber);
        GroupBox5.Controls.Add(btnGetRobotModel);
        GroupBox5.Controls.Add(btnLoadInstallation);
        GroupBox5.Location = new Point(204, 0);
        GroupBox5.Margin = new Padding(4, 3, 4, 3);
        GroupBox5.Name = "GroupBox5";
        GroupBox5.Padding = new Padding(4, 3, 4, 3);
        GroupBox5.Size = new Size(295, 260);
        GroupBox5.TabIndex = 7;
        GroupBox5.TabStop = false;
        GroupBox5.Text = "Information";
        // 
        // btnClosePopup
        // 
        btnClosePopup.Location = new Point(9, 55);
        btnClosePopup.Margin = new Padding(4, 3, 4, 3);
        btnClosePopup.Name = "btnClosePopup";
        btnClosePopup.Size = new Size(274, 27);
        btnClosePopup.TabIndex = 0;
        btnClosePopup.Text = "Close popup";
        btnClosePopup.UseVisualStyleBackColor = true;
        btnClosePopup.Click += btnClosePopup_Click;
        // 
        // btnShowPopup
        // 
        btnShowPopup.Location = new Point(175, 23);
        btnShowPopup.Margin = new Padding(4, 3, 4, 3);
        btnShowPopup.Name = "btnShowPopup";
        btnShowPopup.Size = new Size(108, 27);
        btnShowPopup.TabIndex = 0;
        btnShowPopup.Text = "Show popup";
        btnShowPopup.UseVisualStyleBackColor = true;
        btnShowPopup.Click += btnShowPopup_Click;
        // 
        // txtPopup
        // 
        txtPopup.Location = new Point(9, 25);
        txtPopup.Margin = new Padding(4, 3, 4, 3);
        txtPopup.Name = "txtPopup";
        txtPopup.Size = new Size(158, 23);
        txtPopup.TabIndex = 1;
        txtPopup.Text = "This is a popup message !";
        // 
        // btnAddToLog
        // 
        btnAddToLog.Location = new Point(175, 90);
        btnAddToLog.Margin = new Padding(4, 3, 4, 3);
        btnAddToLog.Name = "btnAddToLog";
        btnAddToLog.Size = new Size(108, 27);
        btnAddToLog.TabIndex = 0;
        btnAddToLog.Text = "Add to log";
        btnAddToLog.UseVisualStyleBackColor = true;
        btnAddToLog.Click += btnAddToLog_Click;
        // 
        // txtLog
        // 
        txtLog.Location = new Point(9, 92);
        txtLog.Margin = new Padding(4, 3, 4, 3);
        txtLog.Name = "txtLog";
        txtLog.Size = new Size(158, 23);
        txtLog.TabIndex = 1;
        txtLog.Text = "This is a log message !";
        // 
        // btnPolyscopeVersion
        // 
        btnPolyscopeVersion.Location = new Point(9, 122);
        btnPolyscopeVersion.Margin = new Padding(4, 3, 4, 3);
        btnPolyscopeVersion.Name = "btnPolyscopeVersion";
        btnPolyscopeVersion.Size = new Size(274, 27);
        btnPolyscopeVersion.TabIndex = 0;
        btnPolyscopeVersion.Text = "Get Polyscope version";
        btnPolyscopeVersion.UseVisualStyleBackColor = true;
        btnPolyscopeVersion.Click += btnPolyscopeVersion_Click;
        // 
        // txtInstallation
        // 
        txtInstallation.Location = new Point(7, 159);
        txtInstallation.Margin = new Padding(4, 3, 4, 3);
        txtInstallation.Name = "txtInstallation";
        txtInstallation.Size = new Size(160, 23);
        txtInstallation.TabIndex = 1;
        txtInstallation.Text = "default.installation";
        // 
        // btnGetSerialNumber
        // 
        btnGetSerialNumber.Location = new Point(7, 189);
        btnGetSerialNumber.Margin = new Padding(4, 3, 4, 3);
        btnGetSerialNumber.Name = "btnGetSerialNumber";
        btnGetSerialNumber.Size = new Size(276, 27);
        btnGetSerialNumber.TabIndex = 0;
        btnGetSerialNumber.Text = "Get serial number";
        btnGetSerialNumber.UseVisualStyleBackColor = true;
        btnGetSerialNumber.Click += btnGetSerialNumber_Click;
        // 
        // btnGetRobotModel
        // 
        btnGetRobotModel.Location = new Point(7, 223);
        btnGetRobotModel.Margin = new Padding(4, 3, 4, 3);
        btnGetRobotModel.Name = "btnGetRobotModel";
        btnGetRobotModel.Size = new Size(276, 27);
        btnGetRobotModel.TabIndex = 0;
        btnGetRobotModel.Text = "Get robot model";
        btnGetRobotModel.UseVisualStyleBackColor = true;
        btnGetRobotModel.Click += btnGetRobotModel_Click;
        // 
        // btnLoadInstallation
        // 
        btnLoadInstallation.Location = new Point(175, 157);
        btnLoadInstallation.Margin = new Padding(4, 3, 4, 3);
        btnLoadInstallation.Name = "btnLoadInstallation";
        btnLoadInstallation.Size = new Size(108, 27);
        btnLoadInstallation.TabIndex = 0;
        btnLoadInstallation.Text = "Load installation";
        btnLoadInstallation.UseVisualStyleBackColor = true;
        btnLoadInstallation.Click += btnLoadInstallation_Click;
        // 
        // GroupBox4
        // 
        GroupBox4.Controls.Add(btnGetSafetyMode);
        GroupBox4.Controls.Add(btnCloseSafetyPopup);
        GroupBox4.Controls.Add(btnSafetyStatus);
        GroupBox4.Controls.Add(btnRestartSafety);
        GroupBox4.Location = new Point(507, 189);
        GroupBox4.Margin = new Padding(4, 3, 4, 3);
        GroupBox4.Name = "GroupBox4";
        GroupBox4.Padding = new Padding(4, 3, 4, 3);
        GroupBox4.Size = new Size(295, 177);
        GroupBox4.TabIndex = 6;
        GroupBox4.TabStop = false;
        GroupBox4.Text = "Safety";
        // 
        // btnCloseSafetyPopup
        // 
        btnCloseSafetyPopup.Location = new Point(7, 88);
        btnCloseSafetyPopup.Margin = new Padding(4, 3, 4, 3);
        btnCloseSafetyPopup.Name = "btnCloseSafetyPopup";
        btnCloseSafetyPopup.Size = new Size(276, 27);
        btnCloseSafetyPopup.TabIndex = 0;
        btnCloseSafetyPopup.Text = "Close safety popup";
        btnCloseSafetyPopup.UseVisualStyleBackColor = true;
        btnCloseSafetyPopup.Click += btnCloseSafetyPopup_Click;
        // 
        // btnSafetyStatus
        // 
        btnSafetyStatus.Location = new Point(7, 22);
        btnSafetyStatus.Margin = new Padding(4, 3, 4, 3);
        btnSafetyStatus.Name = "btnSafetyStatus";
        btnSafetyStatus.Size = new Size(276, 27);
        btnSafetyStatus.TabIndex = 0;
        btnSafetyStatus.Text = "Get safety status";
        btnSafetyStatus.UseVisualStyleBackColor = true;
        btnSafetyStatus.Click += btnSafetyStatus_Click;
        // 
        // btnRestartSafety
        // 
        btnRestartSafety.Location = new Point(7, 122);
        btnRestartSafety.Margin = new Padding(4, 3, 4, 3);
        btnRestartSafety.Name = "btnRestartSafety";
        btnRestartSafety.Size = new Size(276, 27);
        btnRestartSafety.TabIndex = 0;
        btnRestartSafety.Text = "Restart safety";
        btnRestartSafety.UseVisualStyleBackColor = true;
        btnRestartSafety.Click += btnRestartSafety_Click;
        // 
        // GroupBox3
        // 
        GroupBox3.Controls.Add(btnResume);
        GroupBox3.Controls.Add(btnPlay);
        GroupBox3.Controls.Add(btnStop);
        GroupBox3.Controls.Add(btnPause);
        GroupBox3.Controls.Add(btnGetVariableValue);
        GroupBox3.Controls.Add(txtVariableName);
        GroupBox3.Controls.Add(btnLoadProgram);
        GroupBox3.Controls.Add(txtProgram);
        GroupBox3.Controls.Add(btnIsProgramSaved);
        GroupBox3.Controls.Add(btnProgrammRunning);
        GroupBox3.Controls.Add(btnGetProgramState);
        GroupBox3.Controls.Add(btnGetLoadedProgram);
        GroupBox3.Location = new Point(1, 235);
        GroupBox3.Margin = new Padding(4, 3, 4, 3);
        GroupBox3.Name = "GroupBox3";
        GroupBox3.Padding = new Padding(4, 3, 4, 3);
        GroupBox3.Size = new Size(196, 366);
        GroupBox3.TabIndex = 5;
        GroupBox3.TabStop = false;
        GroupBox3.Text = "Programs";
        // 
        // btnPlay
        // 
        btnPlay.Location = new Point(7, 92);
        btnPlay.Margin = new Padding(4, 3, 4, 3);
        btnPlay.Name = "btnPlay";
        btnPlay.Size = new Size(178, 27);
        btnPlay.TabIndex = 0;
        btnPlay.Text = "Play program";
        btnPlay.UseVisualStyleBackColor = true;
        btnPlay.Click += btnPlay_Click;
        // 
        // btnStop
        // 
        btnStop.Location = new Point(7, 126);
        btnStop.Margin = new Padding(4, 3, 4, 3);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(178, 27);
        btnStop.TabIndex = 0;
        btnStop.Text = "Stop program";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // btnPause
        // 
        btnPause.Location = new Point(7, 159);
        btnPause.Margin = new Padding(4, 3, 4, 3);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(178, 27);
        btnPause.TabIndex = 0;
        btnPause.Text = "Pause program";
        btnPause.UseVisualStyleBackColor = true;
        btnPause.Click += btnPause_Click;
        // 
        // btnGetVariableValue
        // 
        btnGetVariableValue.Location = new Point(92, 325);
        btnGetVariableValue.Margin = new Padding(4, 3, 4, 3);
        btnGetVariableValue.Name = "btnGetVariableValue";
        btnGetVariableValue.Size = new Size(93, 27);
        btnGetVariableValue.TabIndex = 0;
        btnGetVariableValue.Text = "Get variable";
        btnGetVariableValue.UseVisualStyleBackColor = true;
        btnGetVariableValue.Click += btnGetVariableValue_Click;
        // 
        // txtVariableName
        // 
        txtVariableName.Location = new Point(7, 327);
        txtVariableName.Margin = new Padding(4, 3, 4, 3);
        txtVariableName.Name = "txtVariableName";
        txtVariableName.Size = new Size(81, 23);
        txtVariableName.TabIndex = 1;
        txtVariableName.Text = "var_1";
        // 
        // btnLoadProgram
        // 
        btnLoadProgram.Location = new Point(92, 27);
        btnLoadProgram.Margin = new Padding(4, 3, 4, 3);
        btnLoadProgram.Name = "btnLoadProgram";
        btnLoadProgram.Size = new Size(93, 27);
        btnLoadProgram.TabIndex = 0;
        btnLoadProgram.Text = "Load program";
        btnLoadProgram.UseVisualStyleBackColor = true;
        btnLoadProgram.Click += btnLoadProgram_Click;
        // 
        // txtProgram
        // 
        txtProgram.Location = new Point(7, 29);
        txtProgram.Margin = new Padding(4, 3, 4, 3);
        txtProgram.Name = "txtProgram";
        txtProgram.Size = new Size(81, 23);
        txtProgram.TabIndex = 1;
        txtProgram.Text = "default.urp";
        // 
        // btnIsProgramSaved
        // 
        btnIsProgramSaved.Location = new Point(7, 292);
        btnIsProgramSaved.Margin = new Padding(4, 3, 4, 3);
        btnIsProgramSaved.Name = "btnIsProgramSaved";
        btnIsProgramSaved.Size = new Size(178, 27);
        btnIsProgramSaved.TabIndex = 0;
        btnIsProgramSaved.Text = "Is program saved ?";
        btnIsProgramSaved.UseVisualStyleBackColor = true;
        btnIsProgramSaved.Click += btnIsProgramSaved_Click;
        // 
        // btnProgrammRunning
        // 
        btnProgrammRunning.Location = new Point(7, 225);
        btnProgrammRunning.Margin = new Padding(4, 3, 4, 3);
        btnProgrammRunning.Name = "btnProgrammRunning";
        btnProgrammRunning.Size = new Size(178, 27);
        btnProgrammRunning.TabIndex = 0;
        btnProgrammRunning.Text = "Is program running ?";
        btnProgrammRunning.UseVisualStyleBackColor = true;
        btnProgrammRunning.Click += btnProgrammRunning_Click;
        // 
        // btnGetProgramState
        // 
        btnGetProgramState.Location = new Point(7, 258);
        btnGetProgramState.Margin = new Padding(4, 3, 4, 3);
        btnGetProgramState.Name = "btnGetProgramState";
        btnGetProgramState.Size = new Size(178, 27);
        btnGetProgramState.TabIndex = 0;
        btnGetProgramState.Text = "Get program state";
        btnGetProgramState.UseVisualStyleBackColor = true;
        btnGetProgramState.Click += btnGetProgramState_Click;
        // 
        // btnGetLoadedProgram
        // 
        btnGetLoadedProgram.Location = new Point(7, 59);
        btnGetLoadedProgram.Margin = new Padding(4, 3, 4, 3);
        btnGetLoadedProgram.Name = "btnGetLoadedProgram";
        btnGetLoadedProgram.Size = new Size(178, 27);
        btnGetLoadedProgram.TabIndex = 0;
        btnGetLoadedProgram.Text = "Get loaded program";
        btnGetLoadedProgram.UseVisualStyleBackColor = true;
        btnGetLoadedProgram.Click += btnGetLoadedProgram_Click;
        // 
        // GroupBox1
        // 
        GroupBox1.Controls.Add(btnPowerOn);
        GroupBox1.Controls.Add(btnPowerOff);
        GroupBox1.Controls.Add(ReaseBrake);
        GroupBox1.Controls.Add(btnUnlockProtectiveStop);
        GroupBox1.Controls.Add(btnGetRobotMode);
        GroupBox1.Controls.Add(btnShutdown);
        GroupBox1.Location = new Point(0, 0);
        GroupBox1.Margin = new Padding(4, 3, 4, 3);
        GroupBox1.Name = "GroupBox1";
        GroupBox1.Padding = new Padding(4, 3, 4, 3);
        GroupBox1.Size = new Size(197, 228);
        GroupBox1.TabIndex = 4;
        GroupBox1.TabStop = false;
        GroupBox1.Text = "Power commands";
        // 
        // btnPowerOn
        // 
        btnPowerOn.Location = new Point(9, 55);
        btnPowerOn.Margin = new Padding(4, 3, 4, 3);
        btnPowerOn.Name = "btnPowerOn";
        btnPowerOn.Size = new Size(177, 27);
        btnPowerOn.TabIndex = 0;
        btnPowerOn.Text = "Power on";
        btnPowerOn.UseVisualStyleBackColor = true;
        btnPowerOn.Click += btnPowerOn_Click;
        // 
        // btnPowerOff
        // 
        btnPowerOff.Location = new Point(9, 89);
        btnPowerOff.Margin = new Padding(4, 3, 4, 3);
        btnPowerOff.Name = "btnPowerOff";
        btnPowerOff.Size = new Size(177, 27);
        btnPowerOff.TabIndex = 0;
        btnPowerOff.Text = "Power off";
        btnPowerOff.UseVisualStyleBackColor = true;
        btnPowerOff.Click += btnPowerOff_Click;
        // 
        // ReaseBrake
        // 
        ReaseBrake.Location = new Point(9, 122);
        ReaseBrake.Margin = new Padding(4, 3, 4, 3);
        ReaseBrake.Name = "ReaseBrake";
        ReaseBrake.Size = new Size(177, 27);
        ReaseBrake.TabIndex = 0;
        ReaseBrake.Text = "Release brake";
        ReaseBrake.UseVisualStyleBackColor = true;
        ReaseBrake.Click += ReaseBrake_Click;
        // 
        // btnUnlockProtectiveStop
        // 
        btnUnlockProtectiveStop.Location = new Point(9, 156);
        btnUnlockProtectiveStop.Margin = new Padding(4, 3, 4, 3);
        btnUnlockProtectiveStop.Name = "btnUnlockProtectiveStop";
        btnUnlockProtectiveStop.Size = new Size(177, 27);
        btnUnlockProtectiveStop.TabIndex = 0;
        btnUnlockProtectiveStop.Text = "Unlock protective stop";
        btnUnlockProtectiveStop.UseVisualStyleBackColor = true;
        btnUnlockProtectiveStop.Click += btnUnlockProtectiveStop_Click;
        // 
        // btnGetRobotMode
        // 
        btnGetRobotMode.Location = new Point(9, 22);
        btnGetRobotMode.Margin = new Padding(4, 3, 4, 3);
        btnGetRobotMode.Name = "btnGetRobotMode";
        btnGetRobotMode.Size = new Size(177, 27);
        btnGetRobotMode.TabIndex = 0;
        btnGetRobotMode.Text = "Get robot mode";
        btnGetRobotMode.UseVisualStyleBackColor = true;
        btnGetRobotMode.Click += btnGetRobotMode_Click;
        // 
        // btnShutdown
        // 
        btnShutdown.Location = new Point(9, 189);
        btnShutdown.Margin = new Padding(4, 3, 4, 3);
        btnShutdown.Name = "btnShutdown";
        btnShutdown.Size = new Size(177, 27);
        btnShutdown.TabIndex = 0;
        btnShutdown.Text = "Shutdown robot";
        btnShutdown.UseVisualStyleBackColor = true;
        btnShutdown.Click += btnShutdown_Click;
        // 
        // DashboardControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(splitMain);
        Margin = new Padding(4, 3, 4, 3);
        Name = "DashboardControl";
        Size = new Size(1447, 819);
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        pnlMain.ResumeLayout(false);
        GroupBox7.ResumeLayout(false);
        GroupBox7.PerformLayout();
        GroupBox6.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        GroupBox5.ResumeLayout(false);
        GroupBox5.PerformLayout();
        GroupBox4.ResumeLayout(false);
        GroupBox3.ResumeLayout(false);
        GroupBox3.PerformLayout();
        GroupBox1.ResumeLayout(false);
        ResumeLayout(false);
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
    internal System.Windows.Forms.GroupBox GroupBox7;
    internal System.Windows.Forms.Button btnResume;
    internal System.Windows.Forms.Button btnGetSafetyMode;
    internal System.Windows.Forms.Button btnGetUserRole;
    internal System.Windows.Forms.Button btnSaveLog;
    internal System.Windows.Forms.ComboBox cbFlightReportType;
    internal System.Windows.Forms.Button btnGenerateFlightReport;
    internal System.Windows.Forms.TextBox txtSupportDirectory;
    internal System.Windows.Forms.Button btnGenerateSupportFile;
}

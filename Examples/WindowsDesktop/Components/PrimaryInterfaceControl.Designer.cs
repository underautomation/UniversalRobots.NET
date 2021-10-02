
    partial class PrimaryInterfaceControl
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
            this.pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.gridCartesian = new PrimaryInterfacePackageControl();
            this.gridForce = new PrimaryInterfacePackageControl();
            this.GridToolCommunication = new PrimaryInterfacePackageControl();
            this.gridTool = new PrimaryInterfacePackageControl();
            this.gridToolModeInfo = new PrimaryInterfacePackageControl();
            this.gridAdditionnalInfo = new PrimaryInterfacePackageControl();
            this.gridRobotMode = new PrimaryInterfacePackageControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendScript = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gridJointData = new PrimaryInterfacePackageControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridKinematicsData = new PrimaryInterfacePackageControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridConfiguration = new PrimaryInterfacePackageControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridMasterboard = new PrimaryInterfacePackageControl();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.AutoSize = true;
            this.pnl.Controls.Add(this.gridCartesian);
            this.pnl.Controls.Add(this.gridForce);
            this.pnl.Controls.Add(this.GridToolCommunication);
            this.pnl.Controls.Add(this.gridTool);
            this.pnl.Controls.Add(this.gridToolModeInfo);
            this.pnl.Controls.Add(this.gridAdditionnalInfo);
            this.pnl.Controls.Add(this.gridRobotMode);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnl.Location = new System.Drawing.Point(0, 76);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(618, 562);
            this.pnl.TabIndex = 1;
            // 
            // gridCartesian
            // 
            this.gridCartesian.BackColor = System.Drawing.SystemColors.Window;
            this.gridCartesian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridCartesian.LabelText = "Cartesian info";
            this.gridCartesian.Location = new System.Drawing.Point(3, 3);
            this.gridCartesian.Name = "gridCartesian";
            this.gridCartesian.Size = new System.Drawing.Size(200, 225);
            this.gridCartesian.TabIndex = 0;
            // 
            // gridForce
            // 
            this.gridForce.BackColor = System.Drawing.SystemColors.Window;
            this.gridForce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridForce.LabelText = "Force data";
            this.gridForce.Location = new System.Drawing.Point(3, 234);
            this.gridForce.Name = "gridForce";
            this.gridForce.Size = new System.Drawing.Size(200, 149);
            this.gridForce.TabIndex = 0;
            // 
            // GridToolCommunication
            // 
            this.GridToolCommunication.BackColor = System.Drawing.SystemColors.Window;
            this.GridToolCommunication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GridToolCommunication.LabelText = "Tool com.";
            this.GridToolCommunication.Location = new System.Drawing.Point(3, 389);
            this.GridToolCommunication.Name = "GridToolCommunication";
            this.GridToolCommunication.Size = new System.Drawing.Size(200, 124);
            this.GridToolCommunication.TabIndex = 2;
            // 
            // gridTool
            // 
            this.gridTool.BackColor = System.Drawing.SystemColors.Window;
            this.gridTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridTool.LabelText = "Tool data";
            this.gridTool.Location = new System.Drawing.Point(209, 3);
            this.gridTool.Name = "gridTool";
            this.gridTool.Size = new System.Drawing.Size(200, 182);
            this.gridTool.TabIndex = 3;
            // 
            // gridToolModeInfo
            // 
            this.gridToolModeInfo.BackColor = System.Drawing.SystemColors.Window;
            this.gridToolModeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridToolModeInfo.LabelText = "Tool mode";
            this.gridToolModeInfo.Location = new System.Drawing.Point(209, 191);
            this.gridToolModeInfo.Name = "gridToolModeInfo";
            this.gridToolModeInfo.Size = new System.Drawing.Size(200, 80);
            this.gridToolModeInfo.TabIndex = 4;
            // 
            // gridAdditionnalInfo
            // 
            this.gridAdditionnalInfo.BackColor = System.Drawing.SystemColors.Window;
            this.gridAdditionnalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAdditionnalInfo.LabelText = "Additionnal info";
            this.gridAdditionnalInfo.Location = new System.Drawing.Point(209, 277);
            this.gridAdditionnalInfo.Name = "gridAdditionnalInfo";
            this.gridAdditionnalInfo.Size = new System.Drawing.Size(200, 91);
            this.gridAdditionnalInfo.TabIndex = 0;
            // 
            // gridRobotMode
            // 
            this.gridRobotMode.BackColor = System.Drawing.SystemColors.Window;
            this.gridRobotMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridRobotMode.LabelText = "Robot mode";
            this.gridRobotMode.Location = new System.Drawing.Point(415, 3);
            this.gridRobotMode.Name = "gridRobotMode";
            this.gridRobotMode.Size = new System.Drawing.Size(200, 237);
            this.gridRobotMode.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendScript);
            this.panel1.Controls.Add(this.txtScript);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 76);
            this.panel1.TabIndex = 2;
            // 
            // btnSendScript
            // 
            this.btnSendScript.Location = new System.Drawing.Point(578, 14);
            this.btnSendScript.Name = "btnSendScript";
            this.btnSendScript.Size = new System.Drawing.Size(87, 23);
            this.btnSendScript.TabIndex = 2;
            this.btnSendScript.Text = "Execute";
            this.btnSendScript.UseVisualStyleBackColor = true;
            this.btnSendScript.Click += new System.EventHandler(this.btnSendScript_Click);
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(6, 16);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(566, 20);
            this.txtScript.TabIndex = 1;
            this.txtScript.Text = "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)";
            this.txtScript.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSendScript_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Robot status data (10Hz) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send a line of URScript :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(618, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 562);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gridJointData);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(900, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(300, 562);
            this.panel6.TabIndex = 4;
            // 
            // gridJointData
            // 
            this.gridJointData.BackColor = System.Drawing.SystemColors.Window;
            this.gridJointData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridJointData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJointData.LabelText = "Joint data";
            this.gridJointData.Location = new System.Drawing.Point(3, 3);
            this.gridJointData.Name = "gridJointData";
            this.gridJointData.Size = new System.Drawing.Size(294, 556);
            this.gridJointData.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridKinematicsData);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(600, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(300, 562);
            this.panel4.TabIndex = 5;
            // 
            // gridKinematicsData
            // 
            this.gridKinematicsData.BackColor = System.Drawing.SystemColors.Window;
            this.gridKinematicsData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridKinematicsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKinematicsData.LabelText = "Kinematics";
            this.gridKinematicsData.Location = new System.Drawing.Point(3, 3);
            this.gridKinematicsData.Margin = new System.Windows.Forms.Padding(0);
            this.gridKinematicsData.Name = "gridKinematicsData";
            this.gridKinematicsData.Size = new System.Drawing.Size(294, 556);
            this.gridKinematicsData.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridConfiguration);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(300, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(300, 562);
            this.panel5.TabIndex = 4;
            // 
            // gridConfiguration
            // 
            this.gridConfiguration.BackColor = System.Drawing.SystemColors.Window;
            this.gridConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConfiguration.LabelText = "Configuration";
            this.gridConfiguration.Location = new System.Drawing.Point(3, 3);
            this.gridConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.gridConfiguration.Name = "gridConfiguration";
            this.gridConfiguration.Size = new System.Drawing.Size(294, 556);
            this.gridConfiguration.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridMasterboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(300, 562);
            this.panel3.TabIndex = 4;
            // 
            // gridMasterboard
            // 
            this.gridMasterboard.BackColor = System.Drawing.SystemColors.Window;
            this.gridMasterboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridMasterboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMasterboard.LabelText = "Masterboard";
            this.gridMasterboard.Location = new System.Drawing.Point(3, 3);
            this.gridMasterboard.Name = "gridMasterboard";
            this.gridMasterboard.Size = new System.Drawing.Size(294, 556);
            this.gridMasterboard.TabIndex = 8;
            // 
            // PrimaryInterfaceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.panel1);
            this.Name = "PrimaryInterfaceControl";
            this.Size = new System.Drawing.Size(1927, 638);
            this.pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private PrimaryInterfacePackageControl gridAdditionnalInfo;
    private System.Windows.Forms.FlowLayoutPanel pnl;
    private PrimaryInterfacePackageControl gridCartesian;
    private PrimaryInterfacePackageControl gridForce;
    private PrimaryInterfacePackageControl gridRobotMode;
    private PrimaryInterfacePackageControl GridToolCommunication;
    private PrimaryInterfacePackageControl gridTool;
    private PrimaryInterfacePackageControl gridToolModeInfo;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSendScript;
    private System.Windows.Forms.TextBox txtScript;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel6;
    private PrimaryInterfacePackageControl gridJointData;
    private System.Windows.Forms.Panel panel4;
    private PrimaryInterfacePackageControl gridKinematicsData;
    private System.Windows.Forms.Panel panel5;
    private PrimaryInterfacePackageControl gridConfiguration;
    private System.Windows.Forms.Panel panel3;
    private PrimaryInterfacePackageControl gridMasterboard;
}


partial class RtdeControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RtdeControl));
            this.gridOutputs = new System.Windows.Forms.PropertyGrid();
            this.gridInputs = new System.Windows.Forms.PropertyGrid();
            this.btnSendInputs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.barSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpeedPercent = new System.Windows.Forms.Label();
            this.tmrStopWrite = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblkVersion = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridOutputs
            // 
            this.gridOutputs.CommandsVisibleIfAvailable = false;
            this.gridOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOutputs.HelpVisible = false;
            this.gridOutputs.Location = new System.Drawing.Point(0, 24);
            this.gridOutputs.Name = "gridOutputs";
            this.gridOutputs.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.gridOutputs.Size = new System.Drawing.Size(430, 403);
            this.gridOutputs.TabIndex = 0;
            this.gridOutputs.TabStop = false;
            this.gridOutputs.ToolbarVisible = false;
            // 
            // gridInputs
            // 
            this.gridInputs.CommandsVisibleIfAvailable = false;
            this.gridInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInputs.HelpVisible = false;
            this.gridInputs.Location = new System.Drawing.Point(0, 24);
            this.gridInputs.Name = "gridInputs";
            this.gridInputs.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.gridInputs.Size = new System.Drawing.Size(407, 403);
            this.gridInputs.TabIndex = 0;
            this.gridInputs.ToolbarVisible = false;
            // 
            // btnSendInputs
            // 
            this.btnSendInputs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSendInputs.Location = new System.Drawing.Point(130, 6);
            this.btnSendInputs.Name = "btnSendInputs";
            this.btnSendInputs.Size = new System.Drawing.Size(157, 23);
            this.btnSendInputs.TabIndex = 1;
            this.btnSendInputs.Text = "Send inputs to robot";
            this.btnSendInputs.UseVisualStyleBackColor = true;
            this.btnSendInputs.Click += new System.EventHandler(this.btnSendInputs_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inputs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outputs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frequency ;";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFrequency.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtFrequency.Location = new System.Drawing.Point(202, 8);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtFrequency, "Timestamp should be among output data to compute frequency");
            // 
            // barSpeed
            // 
            this.barSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.barSpeed.Cursor = System.Windows.Forms.Cursors.Help;
            this.barSpeed.Location = new System.Drawing.Point(111, 39);
            this.barSpeed.Maximum = 120;
            this.barSpeed.Name = "barSpeed";
            this.barSpeed.Size = new System.Drawing.Size(191, 45);
            this.barSpeed.TabIndex = 4;
            this.barSpeed.TickFrequency = 10;
            this.toolTip1.SetToolTip(this.barSpeed, "speed_slider_mask and speed_slider_fraction should be among input data to use thi" +
        "s slider");
            this.barSpeed.Value = 50;
            this.barSpeed.ValueChanged += new System.EventHandler(this.barSpeed_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Speed";
            // 
            // lblSpeedPercent
            // 
            this.lblSpeedPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSpeedPercent.AutoSize = true;
            this.lblSpeedPercent.Location = new System.Drawing.Point(296, 43);
            this.lblSpeedPercent.Name = "lblSpeedPercent";
            this.lblSpeedPercent.Size = new System.Drawing.Size(27, 13);
            this.lblSpeedPercent.TabIndex = 2;
            this.lblSpeedPercent.Text = "50%";
            // 
            // tmrStopWrite
            // 
            this.tmrStopWrite.Interval = 500;
            this.tmrStopWrite.Tick += new System.EventHandler(this.tmrStopWrite_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridInputs);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridOutputs);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(845, 507);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSendInputs);
            this.panel3.Controls.Add(this.lblSpeedPercent);
            this.panel3.Controls.Add(this.barSpeed);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 78);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFrequency);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 78);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 55);
            this.panel1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPause,
            this.btnResume,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lblState,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.lblkVersion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPause
            // 
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(58, 22);
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Image = ((System.Drawing.Image)(resources.GetObject("btnResume.Image")));
            this.btnResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(69, 22);
            this.btnResume.Text = "Resume";
            this.btnResume.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "State :";
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(16, 22);
            this.lblState.Text = "...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Version :";
            // 
            // lblkVersion
            // 
            this.lblkVersion.Name = "lblkVersion";
            this.lblkVersion.Size = new System.Drawing.Size(16, 22);
            this.lblkVersion.Text = "...";
            // 
            // RtdeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "RtdeControl";
            this.Size = new System.Drawing.Size(845, 562);
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.PropertyGrid gridInputs;
    private System.Windows.Forms.PropertyGrid gridOutputs;
    private System.Windows.Forms.Button btnSendInputs;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtFrequency;
    private System.Windows.Forms.TrackBar barSpeed;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblSpeedPercent;
    private System.Windows.Forms.Timer tmrStopWrite;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton btnResume;
    private System.Windows.Forms.ToolStripButton btnPause;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripLabel lblState;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripLabel lblkVersion;
}

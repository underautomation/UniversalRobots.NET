
    partial class PrimaryInterfacePopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnClose = new Button();
        panel1 = new Panel();
        lblMessage = new Label();
        img = new PictureBox();
        txtAnswer = new TextBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)img).BeginInit();
        SuspendLayout();
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.None;
        btnClose.Location = new Point(86, 10);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(310, 34);
        btnClose.TabIndex = 0;
        btnClose.Text = "Close popup on robot";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnClose);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 125);
        panel1.Name = "panel1";
        panel1.Size = new Size(475, 53);
        panel1.TabIndex = 2;
        // 
        // lblMessage
        // 
        lblMessage.Dock = DockStyle.Fill;
        lblMessage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMessage.Location = new Point(100, 0);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(375, 102);
        lblMessage.TabIndex = 3;
        lblMessage.Text = "................";
        lblMessage.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // img
        // 
        img.BackgroundImage = UnderAutomation.UniversalRobots.Showcase.Forms.Properties.Resources.info;
        img.BackgroundImageLayout = ImageLayout.Center;
        img.Dock = DockStyle.Left;
        img.Location = new Point(0, 0);
        img.Name = "img";
        img.Size = new Size(100, 125);
        img.TabIndex = 4;
        img.TabStop = false;
        // 
        // txtAnswer
        // 
        txtAnswer.Dock = DockStyle.Bottom;
        txtAnswer.Location = new Point(100, 102);
        txtAnswer.Name = "txtAnswer";
        txtAnswer.Size = new Size(375, 23);
        txtAnswer.TabIndex = 5;
        // 
        // PrimaryInterfacePopup
        // 
        AutoScaleMode = AutoScaleMode.None;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(475, 178);
        Controls.Add(lblMessage);
        Controls.Add(txtAnswer);
        Controls.Add(img);
        Controls.Add(panel1);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PrimaryInterfacePopup";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        TopMost = true;
        Shown += PrimaryInterfacePopup_Shown;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)img).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.PictureBox img;
    private System.Windows.Forms.TextBox txtAnswer;
}

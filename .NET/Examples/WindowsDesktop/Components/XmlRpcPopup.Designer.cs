    partial class XmlRpcPopup
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
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lstArgs = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label3 = new System.Windows.Forms.Label();
            this.btnPose = new System.Windows.Forms.Button();
            this.btnNothing = new System.Windows.Forms.Button();
            this.btnArrayPoses = new System.Windows.Forms.Button();
            this.BtnString = new System.Windows.Forms.Button();
            this.btnArrayNumbers = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtArgument = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnInteger = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label10 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Black;
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel3.Location = new System.Drawing.Point(0, 265);
            this.Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(516, 4);
            this.Panel3.TabIndex = 11;
            // 
            // btnDouble
            // 
            this.btnDouble.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDouble.Location = new System.Drawing.Point(135, 36);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(115, 23);
            this.btnDouble.TabIndex = 0;
            this.btnDouble.Text = "Double : 2.5";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lstArgs
            // 
            this.lstArgs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lstArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstArgs.HideSelection = false;
            this.lstArgs.Location = new System.Drawing.Point(0, 123);
            this.lstArgs.Name = "lstArgs";
            this.lstArgs.Size = new System.Drawing.Size(516, 146);
            this.lstArgs.TabIndex = 6;
            this.lstArgs.UseCompatibleStateImageBehavior = false;
            this.lstArgs.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Type";
            this.ColumnHeader1.Width = 96;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Value";
            this.ColumnHeader2.Width = 382;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(275, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Choose the object you would like to answer to the robot :";
            // 
            // btnPose
            // 
            this.btnPose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPose.Location = new System.Drawing.Point(15, 65);
            this.btnPose.Name = "btnPose";
            this.btnPose.Size = new System.Drawing.Size(235, 23);
            this.btnPose.TabIndex = 0;
            this.btnPose.Text = "Pose : p[100,-100,120,0.2,0,-0.1]";
            this.btnPose.UseVisualStyleBackColor = true;
            this.btnPose.Click += new System.EventHandler(this.btnPose_Click);
            // 
            // btnNothing
            // 
            this.btnNothing.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNothing.Location = new System.Drawing.Point(187, 123);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(128, 23);
            this.btnNothing.TabIndex = 0;
            this.btnNothing.Text = "null";
            this.btnNothing.UseVisualStyleBackColor = true;
            this.btnNothing.Click += new System.EventHandler(this.btnNothing_Click);
            // 
            // btnArrayPoses
            // 
            this.btnArrayPoses.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnArrayPoses.Location = new System.Drawing.Point(15, 94);
            this.btnArrayPoses.Name = "btnArrayPoses";
            this.btnArrayPoses.Size = new System.Drawing.Size(235, 23);
            this.btnArrayPoses.TabIndex = 0;
            this.btnArrayPoses.Text = "Array of poses : [p[0,1,0,0,0,0], p[0,0,1,0,0,0]]";
            this.btnArrayPoses.UseVisualStyleBackColor = true;
            this.btnArrayPoses.Click += new System.EventHandler(this.btnArrayPoses_Click);
            // 
            // BtnString
            // 
            this.BtnString.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnString.Location = new System.Drawing.Point(256, 65);
            this.BtnString.Name = "BtnString";
            this.BtnString.Size = new System.Drawing.Size(235, 23);
            this.BtnString.TabIndex = 0;
            this.BtnString.Text = "String : \"Hi Robot !\"";
            this.BtnString.UseVisualStyleBackColor = true;
            this.BtnString.Click += new System.EventHandler(this.BtnString_Click);
            // 
            // btnArrayNumbers
            // 
            this.btnArrayNumbers.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnArrayNumbers.Location = new System.Drawing.Point(256, 94);
            this.btnArrayNumbers.Name = "btnArrayNumbers";
            this.btnArrayNumbers.Size = new System.Drawing.Size(235, 23);
            this.btnArrayNumbers.TabIndex = 0;
            this.btnArrayNumbers.Text = "Array of numbers : [-4, 2.3, 100]";
            this.btnArrayNumbers.UseVisualStyleBackColor = true;
            this.btnArrayNumbers.Click += new System.EventHandler(this.btnArrayNumbers_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFalse.Location = new System.Drawing.Point(376, 36);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(115, 23);
            this.btnFalse.TabIndex = 0;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTrue.Location = new System.Drawing.Point(256, 36);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(115, 23);
            this.btnTrue.TabIndex = 0;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label2.Location = new System.Drawing.Point(0, 269);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(516, 37);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Answer :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMethodName
            // 
            this.txtMethodName.AutoSize = true;
            this.txtMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtMethodName.Location = new System.Drawing.Point(91, 10);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(74, 17);
            this.txtMethodName.TabIndex = 1;
            this.txtMethodName.Text = "METHOD";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(12, 12);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(83, 13);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Method called : ";
            // 
            // txtArgument
            // 
            this.txtArgument.AutoSize = true;
            this.txtArgument.Location = new System.Drawing.Point(12, 67);
            this.txtArgument.Name = "txtArgument";
            this.txtArgument.Size = new System.Drawing.Size(162, 13);
            this.txtArgument.TabIndex = 3;
            this.txtArgument.Text = "The request has % argument(s) : ";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 36);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(66, 13);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "From robot : ";
            // 
            // txtIp
            // 
            this.txtIp.AutoSize = true;
            this.txtIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtIp.Location = new System.Drawing.Point(75, 34);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(22, 17);
            this.txtIp.TabIndex = 5;
            this.txtIp.Text = "IP";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtMethodName);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.txtArgument);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.txtIp);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 37);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(516, 86);
            this.Panel1.TabIndex = 7;
            // 
            // btnInteger
            // 
            this.btnInteger.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInteger.Location = new System.Drawing.Point(15, 36);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(115, 23);
            this.btnInteger.TabIndex = 0;
            this.btnInteger.Text = "Integer : -12";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.btnPose);
            this.Panel2.Controls.Add(this.btnNothing);
            this.Panel2.Controls.Add(this.btnArrayPoses);
            this.Panel2.Controls.Add(this.BtnString);
            this.Panel2.Controls.Add(this.btnArrayNumbers);
            this.Panel2.Controls.Add(this.btnFalse);
            this.Panel2.Controls.Add(this.btnTrue);
            this.Panel2.Controls.Add(this.btnDouble);
            this.Panel2.Controls.Add(this.btnInteger);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 306);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(516, 155);
            this.Panel2.TabIndex = 8;
            // 
            // Label10
            // 
            this.Label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label10.Location = new System.Drawing.Point(0, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(516, 37);
            this.Label10.TabIndex = 9;
            this.Label10.Text = "Request :";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XmlRpcPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 461);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.lstArgs);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label10);
            this.Name = "XmlRpcPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XML-RPC request";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

    #endregion

    internal System.Windows.Forms.Panel Panel3;
    internal System.Windows.Forms.Button btnDouble;
    private System.Windows.Forms.ListView lstArgs;
    internal System.Windows.Forms.ColumnHeader ColumnHeader1;
    internal System.Windows.Forms.ColumnHeader ColumnHeader2;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Button btnPose;
    internal System.Windows.Forms.Button btnNothing;
    internal System.Windows.Forms.Button btnArrayPoses;
    internal System.Windows.Forms.Button BtnString;
    internal System.Windows.Forms.Button btnArrayNumbers;
    internal System.Windows.Forms.Button btnFalse;
    internal System.Windows.Forms.Button btnTrue;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label txtMethodName;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.Label txtArgument;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.Label txtIp;
    internal System.Windows.Forms.Panel Panel1;
    internal System.Windows.Forms.Button btnInteger;
    internal System.Windows.Forms.Panel Panel2;
    internal System.Windows.Forms.Label Label10;
}


    partial class ToolsControl
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
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.radioRPYToRotationVector = new System.Windows.Forms.RadioButton();
            this.txtRz = new System.Windows.Forms.TextBox();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.udRz = new System.Windows.Forms.NumericUpDown();
            this.udRy = new System.Windows.Forms.NumericUpDown();
            this.udRx = new System.Windows.Forms.NumericUpDown();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.Label();
            this.GroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRx)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.RadioButton2);
            this.GroupBox7.Controls.Add(this.radioRPYToRotationVector);
            this.GroupBox7.Controls.Add(this.txtRz);
            this.GroupBox7.Controls.Add(this.txtRy);
            this.GroupBox7.Controls.Add(this.txtRx);
            this.GroupBox7.Controls.Add(this.udRz);
            this.GroupBox7.Controls.Add(this.udRy);
            this.GroupBox7.Controls.Add(this.udRx);
            this.GroupBox7.Controls.Add(this.Label6);
            this.GroupBox7.Controls.Add(this.Label7);
            this.GroupBox7.Controls.Add(this.Label5);
            this.GroupBox7.Controls.Add(this.Label4);
            this.GroupBox7.Controls.Add(this.txtOut);
            this.GroupBox7.Controls.Add(this.txtIn);
            this.GroupBox7.Location = new System.Drawing.Point(21, 21);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(439, 191);
            this.GroupBox7.TabIndex = 5;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Convert angles";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(260, 25);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(162, 17);
            this.RadioButton2.TabIndex = 7;
            this.RadioButton2.Text = "From Rotation Vector to RPY";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // radioRPYToRotationVector
            // 
            this.radioRPYToRotationVector.AutoSize = true;
            this.radioRPYToRotationVector.Checked = true;
            this.radioRPYToRotationVector.Location = new System.Drawing.Point(72, 25);
            this.radioRPYToRotationVector.Name = "radioRPYToRotationVector";
            this.radioRPYToRotationVector.Size = new System.Drawing.Size(161, 17);
            this.radioRPYToRotationVector.TabIndex = 6;
            this.radioRPYToRotationVector.TabStop = true;
            this.radioRPYToRotationVector.Text = "From RPY to Rotation vector";
            this.radioRPYToRotationVector.UseVisualStyleBackColor = true;
            this.radioRPYToRotationVector.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtRz
            // 
            this.txtRz.Location = new System.Drawing.Point(243, 145);
            this.txtRz.Name = "txtRz";
            this.txtRz.ReadOnly = true;
            this.txtRz.Size = new System.Drawing.Size(100, 20);
            this.txtRz.TabIndex = 5;
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(243, 119);
            this.txtRy.Name = "txtRy";
            this.txtRy.ReadOnly = true;
            this.txtRy.Size = new System.Drawing.Size(100, 20);
            this.txtRy.TabIndex = 4;
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(243, 93);
            this.txtRx.Name = "txtRx";
            this.txtRx.ReadOnly = true;
            this.txtRx.Size = new System.Drawing.Size(100, 20);
            this.txtRx.TabIndex = 3;
            // 
            // udRz
            // 
            this.udRz.DecimalPlaces = 3;
            this.udRz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udRz.Location = new System.Drawing.Point(72, 145);
            this.udRz.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udRz.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.udRz.Name = "udRz";
            this.udRz.Size = new System.Drawing.Size(120, 20);
            this.udRz.TabIndex = 2;
            this.udRz.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // udRy
            // 
            this.udRy.DecimalPlaces = 3;
            this.udRy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udRy.Location = new System.Drawing.Point(72, 119);
            this.udRy.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udRy.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.udRy.Name = "udRy";
            this.udRy.Size = new System.Drawing.Size(120, 20);
            this.udRy.TabIndex = 1;
            this.udRy.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // udRx
            // 
            this.udRx.DecimalPlaces = 3;
            this.udRx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.udRx.Location = new System.Drawing.Point(72, 93);
            this.udRx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.udRx.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.udRx.Name = "udRx";
            this.udRx.Size = new System.Drawing.Size(120, 20);
            this.udRx.TabIndex = 0;
            this.udRx.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(11, 147);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 13);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "RZ (rad) :";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(198, 93);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 72);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "=";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(11, 121);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "RY (rad) :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(11, 95);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "RX (rad) :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(224, 52);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(142, 38);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "Rotation Vector";
            this.txtOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIn
            // 
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(56, 52);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(147, 38);
            this.txtIn.TabIndex = 1;
            this.txtIn.Text = "RPY";
            this.txtIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox7);
            this.Name = "ToolsControl";
            this.Size = new System.Drawing.Size(741, 580);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udRz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton radioRPYToRotationVector;
        internal System.Windows.Forms.TextBox txtRz;
        internal System.Windows.Forms.TextBox txtRy;
        internal System.Windows.Forms.TextBox txtRx;
        internal System.Windows.Forms.NumericUpDown udRz;
        internal System.Windows.Forms.NumericUpDown udRy;
        internal System.Windows.Forms.NumericUpDown udRx;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label txtOut;
        internal System.Windows.Forms.Label txtIn;
    }

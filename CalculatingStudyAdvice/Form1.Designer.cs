namespace CalculatingStudyAdvice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculateAdvice = new System.Windows.Forms.Button();
            this.lbBlock4 = new System.Windows.Forms.Label();
            this.lbBlock3 = new System.Windows.Forms.Label();
            this.nBlock4 = new System.Windows.Forms.NumericUpDown();
            this.nBlock3 = new System.Windows.Forms.NumericUpDown();
            this.lbBlock2 = new System.Windows.Forms.Label();
            this.lbBlock1 = new System.Windows.Forms.Label();
            this.nBlock2 = new System.Windows.Forms.NumericUpDown();
            this.nBlock1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nBlock1);
            this.groupBox1.Controls.Add(this.nBlock2);
            this.groupBox1.Controls.Add(this.btnCalculateAdvice);
            this.groupBox1.Controls.Add(this.lbBlock4);
            this.groupBox1.Controls.Add(this.lbBlock3);
            this.groupBox1.Controls.Add(this.nBlock4);
            this.groupBox1.Controls.Add(this.nBlock3);
            this.groupBox1.Controls.Add(this.lbBlock2);
            this.groupBox1.Controls.Add(this.lbBlock1);
            this.groupBox1.Location = new System.Drawing.Point(22, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EC\'s earned";
            // 
            // btnCalculateAdvice
            // 
            this.btnCalculateAdvice.Location = new System.Drawing.Point(15, 209);
            this.btnCalculateAdvice.Name = "btnCalculateAdvice";
            this.btnCalculateAdvice.Size = new System.Drawing.Size(186, 36);
            this.btnCalculateAdvice.TabIndex = 8;
            this.btnCalculateAdvice.Text = "Calculate Advice";
            this.btnCalculateAdvice.UseVisualStyleBackColor = true;
            this.btnCalculateAdvice.Click += new System.EventHandler(this.btnCalculateAdvice_Click);
            // 
            // lbBlock4
            // 
            this.lbBlock4.AutoSize = true;
            this.lbBlock4.Location = new System.Drawing.Point(15, 166);
            this.lbBlock4.Name = "lbBlock4";
            this.lbBlock4.Size = new System.Drawing.Size(45, 15);
            this.lbBlock4.TabIndex = 7;
            this.lbBlock4.Text = "Block 4";
            // 
            // lbBlock3
            // 
            this.lbBlock3.AutoSize = true;
            this.lbBlock3.Location = new System.Drawing.Point(15, 120);
            this.lbBlock3.Name = "lbBlock3";
            this.lbBlock3.Size = new System.Drawing.Size(45, 15);
            this.lbBlock3.TabIndex = 6;
            this.lbBlock3.Text = "Block 3";
            // 
            // nBlock4
            // 
            this.nBlock4.Location = new System.Drawing.Point(81, 164);
            this.nBlock4.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nBlock4.Name = "nBlock4";
            this.nBlock4.Size = new System.Drawing.Size(120, 23);
            this.nBlock4.TabIndex = 5;
            // 
            // nBlock3
            // 
            this.nBlock3.Location = new System.Drawing.Point(81, 118);
            this.nBlock3.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nBlock3.Name = "nBlock3";
            this.nBlock3.Size = new System.Drawing.Size(120, 23);
            this.nBlock3.TabIndex = 4;
            // 
            // lbBlock2
            // 
            this.lbBlock2.AutoSize = true;
            this.lbBlock2.Location = new System.Drawing.Point(15, 79);
            this.lbBlock2.Name = "lbBlock2";
            this.lbBlock2.Size = new System.Drawing.Size(48, 15);
            this.lbBlock2.TabIndex = 2;
            this.lbBlock2.Text = "Block 2 ";
            // 
            // lbBlock1
            // 
            this.lbBlock1.AutoSize = true;
            this.lbBlock1.Location = new System.Drawing.Point(15, 39);
            this.lbBlock1.Name = "lbBlock1";
            this.lbBlock1.Size = new System.Drawing.Size(48, 15);
            this.lbBlock1.TabIndex = 0;
            this.lbBlock1.Text = "Block 1 ";
            // 
            // nBlock2
            // 
            this.nBlock2.Location = new System.Drawing.Point(81, 77);
            this.nBlock2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nBlock2.Name = "nBlock2";
            this.nBlock2.Size = new System.Drawing.Size(120, 23);
            this.nBlock2.TabIndex = 9;
            // 
            // nBlock1
            // 
            this.nBlock1.Location = new System.Drawing.Point(81, 37);
            this.nBlock1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nBlock1.Name = "nBlock1";
            this.nBlock1.Size = new System.Drawing.Size(120, 23);
            this.nBlock1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 343);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculateAdvice;
        private System.Windows.Forms.Label lbBlock4;
        private System.Windows.Forms.Label lbBlock3;
        private System.Windows.Forms.NumericUpDown nBlock4;
        private System.Windows.Forms.NumericUpDown nBlock3;
        private System.Windows.Forms.Label lbBlock2;
        private System.Windows.Forms.Label lbBlock1;
        private System.Windows.Forms.TextBox tbBlock2;
        private System.Windows.Forms.TextBox tbBlock1;
        private System.Windows.Forms.NumericUpDown nBlock1;
        private System.Windows.Forms.NumericUpDown nBlock2;
    }
}

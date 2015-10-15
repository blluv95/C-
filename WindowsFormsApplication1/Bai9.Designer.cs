namespace WindowsFormsApplication1
{
    partial class Bai9
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
            this.editText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTahoma = new System.Windows.Forms.RadioButton();
            this.rdVnVgogue = new System.Windows.Forms.RadioButton();
            this.rdVnUniverec = new System.Windows.Forms.RadioButton();
            this.rdVnTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbStrikeout = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTim = new System.Windows.Forms.RadioButton();
            this.rdBlue = new System.Windows.Forms.RadioButton();
            this.rdRed = new System.Windows.Forms.RadioButton();
            this.rdGreen = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.Location = new System.Drawing.Point(196, 30);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(219, 20);
            this.editText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTahoma);
            this.groupBox1.Controls.Add(this.rdVnVgogue);
            this.groupBox1.Controls.Add(this.rdVnUniverec);
            this.groupBox1.Controls.Add(this.rdVnTime);
            this.groupBox1.Location = new System.Drawing.Point(69, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu font";
            // 
            // rdTahoma
            // 
            this.rdTahoma.AutoSize = true;
            this.rdTahoma.Location = new System.Drawing.Point(7, 151);
            this.rdTahoma.Name = "rdTahoma";
            this.rdTahoma.Size = new System.Drawing.Size(66, 17);
            this.rdTahoma.TabIndex = 3;
            this.rdTahoma.TabStop = true;
            this.rdTahoma.Text = "TaHoma";
            this.rdTahoma.UseVisualStyleBackColor = true;
            this.rdTahoma.CheckedChanged += new System.EventHandler(this.rdTahoma_CheckedChanged);
            // 
            // rdVnVgogue
            // 
            this.rdVnVgogue.AutoSize = true;
            this.rdVnVgogue.Location = new System.Drawing.Point(7, 111);
            this.rdVnVgogue.Name = "rdVnVgogue";
            this.rdVnVgogue.Size = new System.Drawing.Size(75, 17);
            this.rdVnVgogue.TabIndex = 2;
            this.rdVnVgogue.TabStop = true;
            this.rdVnVgogue.Text = "VnVgogue";
            this.rdVnVgogue.UseVisualStyleBackColor = true;
            // 
            // rdVnUniverec
            // 
            this.rdVnUniverec.AutoSize = true;
            this.rdVnUniverec.Location = new System.Drawing.Point(7, 66);
            this.rdVnUniverec.Name = "rdVnUniverec";
            this.rdVnUniverec.Size = new System.Drawing.Size(80, 17);
            this.rdVnUniverec.TabIndex = 1;
            this.rdVnUniverec.TabStop = true;
            this.rdVnUniverec.Text = "VnUniveres";
            this.rdVnUniverec.UseVisualStyleBackColor = true;
            this.rdVnUniverec.CheckedChanged += new System.EventHandler(this.rdVnUniverec_CheckedChanged);
            // 
            // rdVnTime
            // 
            this.rdVnTime.AutoSize = true;
            this.rdVnTime.Location = new System.Drawing.Point(7, 29);
            this.rdVnTime.Name = "rdVnTime";
            this.rdVnTime.Size = new System.Drawing.Size(61, 17);
            this.rdVnTime.TabIndex = 0;
            this.rdVnTime.TabStop = true;
            this.rdVnTime.Text = "VnTime";
            this.rdVnTime.UseVisualStyleBackColor = true;
            this.rdVnTime.CheckedChanged += new System.EventHandler(this.rdVnTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUnderline);
            this.groupBox2.Controls.Add(this.cbStrikeout);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.cbBold);
            this.groupBox2.Location = new System.Drawing.Point(244, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng";
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(7, 151);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(71, 17);
            this.cbUnderline.TabIndex = 3;
            this.cbUnderline.Text = "Underline";
            this.cbUnderline.UseVisualStyleBackColor = true;
            // 
            // cbStrikeout
            // 
            this.cbStrikeout.AutoSize = true;
            this.cbStrikeout.Location = new System.Drawing.Point(7, 111);
            this.cbStrikeout.Name = "cbStrikeout";
            this.cbStrikeout.Size = new System.Drawing.Size(68, 17);
            this.cbStrikeout.TabIndex = 2;
            this.cbStrikeout.Text = "Strikeout";
            this.cbStrikeout.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Italic";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(7, 29);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(47, 17);
            this.cbBold.TabIndex = 0;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.Click += new System.EventHandler(this.cbBold_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTim);
            this.groupBox3.Controls.Add(this.rdBlue);
            this.groupBox3.Controls.Add(this.rdRed);
            this.groupBox3.Controls.Add(this.rdGreen);
            this.groupBox3.Location = new System.Drawing.Point(446, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mầu chữ";
            // 
            // rdTim
            // 
            this.rdTim.AutoSize = true;
            this.rdTim.Location = new System.Drawing.Point(7, 151);
            this.rdTim.Name = "rdTim";
            this.rdTim.Size = new System.Drawing.Size(44, 17);
            this.rdTim.TabIndex = 3;
            this.rdTim.TabStop = true;
            this.rdTim.Text = "Tím";
            this.rdTim.UseVisualStyleBackColor = true;
            // 
            // rdBlue
            // 
            this.rdBlue.AutoSize = true;
            this.rdBlue.Location = new System.Drawing.Point(7, 111);
            this.rdBlue.Name = "rdBlue";
            this.rdBlue.Size = new System.Drawing.Size(85, 17);
            this.rdBlue.TabIndex = 2;
            this.rdBlue.TabStop = true;
            this.rdBlue.Text = "Xanh Dương";
            this.rdBlue.UseVisualStyleBackColor = true;
            // 
            // rdRed
            // 
            this.rdRed.AutoSize = true;
            this.rdRed.Location = new System.Drawing.Point(7, 66);
            this.rdRed.Name = "rdRed";
            this.rdRed.Size = new System.Drawing.Size(39, 17);
            this.rdRed.TabIndex = 1;
            this.rdRed.TabStop = true;
            this.rdRed.Text = "Đỏ";
            this.rdRed.UseVisualStyleBackColor = true;
            // 
            // rdGreen
            // 
            this.rdGreen.AutoSize = true;
            this.rdGreen.Location = new System.Drawing.Point(6, 29);
            this.rdGreen.Name = "rdGreen";
            this.rdGreen.Size = new System.Drawing.Size(50, 17);
            this.rdGreen.TabIndex = 0;
            this.rdGreen.TabStop = true;
            this.rdGreen.Text = "Xanh";
            this.rdGreen.UseVisualStyleBackColor = true;
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editText);
            this.Name = "Bai9";
            this.Text = "Bai9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTahoma;
        private System.Windows.Forms.RadioButton rdVnVgogue;
        private System.Windows.Forms.RadioButton rdVnUniverec;
        private System.Windows.Forms.RadioButton rdVnTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbStrikeout;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdTim;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.RadioButton rdGreen;
    }
}
namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.edittextA = new System.Windows.Forms.TextBox();
            this.edittextB = new System.Windows.Forms.TextBox();
            this.editTextKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // edittextA
            // 
            this.edittextA.Location = new System.Drawing.Point(146, 30);
            this.edittextA.Name = "edittextA";
            this.edittextA.Size = new System.Drawing.Size(100, 20);
            this.edittextA.TabIndex = 0;
            this.edittextA.TextChanged += new System.EventHandler(this.edittextA_TextChanged);
            // 
            // edittextB
            // 
            this.edittextB.Location = new System.Drawing.Point(146, 68);
            this.edittextB.Name = "edittextB";
            this.edittextB.Size = new System.Drawing.Size(100, 20);
            this.edittextB.TabIndex = 1;
            // 
            // editTextKQ
            // 
            this.editTextKQ.Location = new System.Drawing.Point(146, 108);
            this.editTextKQ.Name = "editTextKQ";
            this.editTextKQ.Size = new System.Drawing.Size(100, 20);
            this.editTextKQ.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(59, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(17, 121);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(46, 17);
            this.rdChia.TabIndex = 3;
            this.rdChia.TabStop = true;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(17, 86);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(51, 17);
            this.rdNhan.TabIndex = 2;
            this.rdNhan.TabStop = true;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(17, 52);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(41, 17);
            this.rdTru.TabIndex = 1;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(17, 19);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(50, 17);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMin);
            this.groupBox2.Controls.Add(this.cbMax);
            this.groupBox2.Location = new System.Drawing.Point(395, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "So Sánh";
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Location = new System.Drawing.Point(37, 96);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(49, 17);
            this.cbMin.TabIndex = 1;
            this.cbMin.Text = "Min=";
            this.cbMin.UseVisualStyleBackColor = true;
            this.cbMin.CheckedChanged += new System.EventHandler(this.cbMin_CheckedChanged);
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Location = new System.Drawing.Point(37, 49);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(52, 17);
            this.cbMax.TabIndex = 0;
            this.cbMax.Text = "Max=";
            this.cbMax.UseVisualStyleBackColor = true;
            this.cbMax.CheckedChanged += new System.EventHandler(this.cbMax_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(146, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 387);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editTextKQ);
            this.Controls.Add(this.edittextB);
            this.Controls.Add(this.edittextA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edittextA;
        private System.Windows.Forms.TextBox edittextB;
        private System.Windows.Forms.TextBox editTextKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.Button btnThoat;

    }
}
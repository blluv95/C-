namespace WindowsFormsApplication1
{
    partial class Form11
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
            this.label1 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.edHoten = new System.Windows.Forms.TextBox();
            this.edDT = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThe = new System.Windows.Forms.RadioButton();
            this.rdSec = new System.Windows.Forms.RadioButton();
            this.rdTienmat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbFax = new System.Windows.Forms.CheckBox();
            this.cbDT = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(361, 31);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(55, 13);
            this.asd.TabIndex = 1;
            this.asd.Text = "Điện thoại";
            // 
            // edHoten
            // 
            this.edHoten.Location = new System.Drawing.Point(130, 31);
            this.edHoten.Name = "edHoten";
            this.edHoten.Size = new System.Drawing.Size(156, 20);
            this.edHoten.TabIndex = 2;
            // 
            // edDT
            // 
            this.edDT.Location = new System.Drawing.Point(443, 31);
            this.edDT.Name = "edDT";
            this.edDT.Size = new System.Drawing.Size(221, 20);
            this.edDT.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(59, 117);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(227, 186);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(443, 114);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 186);
            this.listBox2.TabIndex = 5;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThe);
            this.groupBox1.Controls.Add(this.rdSec);
            this.groupBox1.Controls.Add(this.rdTienmat);
            this.groupBox1.Location = new System.Drawing.Point(59, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdThe
            // 
            this.rdThe.AutoSize = true;
            this.rdThe.Location = new System.Drawing.Point(6, 101);
            this.rdThe.Name = "rdThe";
            this.rdThe.Size = new System.Drawing.Size(87, 17);
            this.rdThe.TabIndex = 2;
            this.rdThe.TabStop = true;
            this.rdThe.Text = "Thẻ tín dụng";
            this.rdThe.UseVisualStyleBackColor = true;
            // 
            // rdSec
            // 
            this.rdSec.AutoSize = true;
            this.rdSec.Location = new System.Drawing.Point(6, 67);
            this.rdSec.Name = "rdSec";
            this.rdSec.Size = new System.Drawing.Size(44, 17);
            this.rdSec.TabIndex = 1;
            this.rdSec.TabStop = true;
            this.rdSec.Text = "Sec";
            this.rdSec.UseVisualStyleBackColor = true;
            // 
            // rdTienmat
            // 
            this.rdTienmat.AutoSize = true;
            this.rdTienmat.Location = new System.Drawing.Point(6, 28);
            this.rdTienmat.Name = "rdTienmat";
            this.rdTienmat.Size = new System.Drawing.Size(66, 17);
            this.rdTienmat.TabIndex = 0;
            this.rdTienmat.TabStop = true;
            this.rdTienmat.Text = "Tiền mặt";
            this.rdTienmat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEmail);
            this.groupBox2.Controls.Add(this.cbFax);
            this.groupBox2.Controls.Add(this.cbDT);
            this.groupBox2.Location = new System.Drawing.Point(443, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(7, 105);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(51, 17);
            this.cbEmail.TabIndex = 2;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(7, 67);
            this.cbFax.Name = "cbFax";
            this.cbFax.Size = new System.Drawing.Size(43, 17);
            this.cbFax.TabIndex = 1;
            this.cbFax.Text = "Fax";
            this.cbFax.UseVisualStyleBackColor = true;
            // 
            // cbDT
            // 
            this.cbDT.AutoSize = true;
            this.cbDT.Location = new System.Drawing.Point(7, 28);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(74, 17);
            this.cbDT.TabIndex = 0;
            this.cbDT.Text = "Điện thoại";
            this.cbDT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh Sách Các Mặt Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hàng đặt mua";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(147, 492);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(122, 23);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(364, 492);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 527);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.edDT);
            this.Controls.Add(this.edHoten);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.TextBox edHoten;
        private System.Windows.Forms.TextBox edDT;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThe;
        private System.Windows.Forms.RadioButton rdSec;
        private System.Windows.Forms.RadioButton rdTienmat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbFax;
        private System.Windows.Forms.CheckBox cbDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
    }
}
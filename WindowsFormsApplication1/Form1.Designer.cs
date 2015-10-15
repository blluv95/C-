namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtDemo = new System.Windows.Forms.Label();
            this.btnKQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editTextMonth = new System.Windows.Forms.TextBox();
            this.editTextYear = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtDemo
            // 
            this.txtDemo.AccessibleDescription = "txt";
            this.txtDemo.AccessibleName = "txtDemo";
            this.txtDemo.AutoSize = true;
            this.txtDemo.Location = new System.Drawing.Point(271, 44);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(73, 13);
            this.txtDemo.TabIndex = 0;
            this.txtDemo.Text = "Nhập Tháng :";
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(274, 159);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 23);
            this.btnKQ.TabIndex = 1;
            this.btnKQ.Text = "Kết Quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Năm :";
            // 
            // editTextMonth
            // 
            this.editTextMonth.Location = new System.Drawing.Point(373, 44);
            this.editTextMonth.Name = "editTextMonth";
            this.editTextMonth.Size = new System.Drawing.Size(100, 20);
            this.editTextMonth.TabIndex = 3;
            this.toolTip1.SetToolTip(this.editTextMonth, "toolTip1");
            this.editTextMonth.TextChanged += new System.EventHandler(this.editTextMonth_TextChanged);
            // 
            // editTextYear
            // 
            this.editTextYear.Location = new System.Drawing.Point(373, 75);
            this.editTextYear.Name = "editTextYear";
            this.editTextYear.Size = new System.Drawing.Size(100, 20);
            this.editTextYear.TabIndex = 4;
            this.editTextYear.TextChanged += new System.EventHandler(this.editTextYear_TextChanged);
            // 
            // txtShow
            // 
            this.txtShow.AutoSize = true;
            this.txtShow.Enabled = false;
            this.txtShow.Location = new System.Drawing.Point(277, 117);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(0, 13);
            this.txtShow.TabIndex = 5;
            this.txtShow.Click += new System.EventHandler(this.txtShow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(409, 158);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Làm Lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.Tag = "A";
            this.toolTip1.ToolTipTitle = "This is ToolTip";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(688, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.editTextYear);
            this.Controls.Add(this.editTextMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txtDemo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtDemo;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editTextMonth;
        private System.Windows.Forms.TextBox editTextYear;
        private System.Windows.Forms.Label txtShow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}


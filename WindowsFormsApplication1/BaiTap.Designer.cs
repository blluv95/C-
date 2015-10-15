namespace WindowsFormsApplication1
{
    partial class BaiTap
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.edX = new System.Windows.Forms.TextBox();
            this.edY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new MaterialSkin.Controls.DEFAULT_BTNS.SuccessBTN();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvDistance = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nhập X:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Nhập Y:";
            // 
            // edX
            // 
            this.edX.Location = new System.Drawing.Point(138, 49);
            this.edX.Name = "edX";
            this.edX.Size = new System.Drawing.Size(68, 20);
            this.edX.TabIndex = 2;
            this.toolTip1.SetToolTip(this.edX, "Nhập x");
            // 
            // edY
            // 
            this.edY.Location = new System.Drawing.Point(138, 108);
            this.edY.Name = "edY";
            this.edY.Size = new System.Drawing.Size(68, 20);
            this.edY.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.edY);
            this.groupBox1.Controls.Add(this.edX);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tọa độ :";
            // 
            // btnThem
            // 
            this.btnThem.Depth = 0;
            this.btnThem.Location = new System.Drawing.Point(74, 279);
            this.btnThem.MinimumSize = new System.Drawing.Size(88, 36);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(144, 36);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(219, 160);
            this.listBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox);
            this.groupBox2.Location = new System.Drawing.Point(358, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 182);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tọa độ";
            // 
            // tvDistance
            // 
            this.tvDistance.AutoSize = true;
            this.tvDistance.Depth = 0;
            this.tvDistance.Font = new System.Drawing.Font("Roboto", 11F);
            this.tvDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tvDistance.Location = new System.Drawing.Point(9, 346);
            this.tvDistance.MouseState = MaterialSkin.MouseState.HOVER;
            this.tvDistance.Name = "tvDistance";
            this.tvDistance.Size = new System.Drawing.Size(171, 19);
            this.tvDistance.TabIndex = 8;
            this.tvDistance.Text = "Độ dài đường gấp khúc :";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(390, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // BaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 470);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tvDistance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaiTap";
            this.Text = "BaiTap";
            this.Load += new System.EventHandler(this.BaiTap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox edX;
        private System.Windows.Forms.TextBox edY;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.DEFAULT_BTNS.SuccessBTN btnThem;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel tvDistance;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnXoa;
    }
}
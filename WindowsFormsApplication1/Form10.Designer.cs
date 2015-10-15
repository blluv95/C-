namespace WindowsFormsApplication1
{
    partial class Form10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdUSA = new System.Windows.Forms.RadioButton();
            this.rdItaly = new System.Windows.Forms.RadioButton();
            this.rdUK = new System.Windows.Forms.RadioButton();
            this.rdTurkey = new System.Windows.Forms.RadioButton();
            this.rdSpain = new System.Windows.Forms.RadioButton();
            this.rdHungary = new System.Windows.Forms.RadioButton();
            this.rdJapan = new System.Windows.Forms.RadioButton();
            this.rdFrance = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdParis = new System.Windows.Forms.RadioButton();
            this.rdBudapest = new System.Windows.Forms.RadioButton();
            this.rdAnkara = new System.Windows.Forms.RadioButton();
            this.rdLondon = new System.Windows.Forms.RadioButton();
            this.rdMadrid = new System.Windows.Forms.RadioButton();
            this.rdRome = new System.Windows.Forms.RadioButton();
            this.rdTokyo = new System.Windows.Forms.RadioButton();
            this.rdBuenos = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdUSA);
            this.groupBox1.Controls.Add(this.rdItaly);
            this.groupBox1.Controls.Add(this.rdUK);
            this.groupBox1.Controls.Add(this.rdTurkey);
            this.groupBox1.Controls.Add(this.rdSpain);
            this.groupBox1.Controls.Add(this.rdHungary);
            this.groupBox1.Controls.Add(this.rdJapan);
            this.groupBox1.Controls.Add(this.rdFrance);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // rdUSA
            // 
            this.rdUSA.AutoSize = true;
            this.rdUSA.Location = new System.Drawing.Point(6, 312);
            this.rdUSA.Name = "rdUSA";
            this.rdUSA.Size = new System.Drawing.Size(69, 17);
            this.rdUSA.TabIndex = 7;
            this.rdUSA.TabStop = true;
            this.rdUSA.Text = "The USA";
            this.rdUSA.UseVisualStyleBackColor = true;
            this.rdUSA.CheckedChanged += new System.EventHandler(this.rdUSA_CheckedChanged);
            // 
            // rdItaly
            // 
            this.rdItaly.AutoSize = true;
            this.rdItaly.Location = new System.Drawing.Point(7, 269);
            this.rdItaly.Name = "rdItaly";
            this.rdItaly.Size = new System.Drawing.Size(44, 17);
            this.rdItaly.TabIndex = 6;
            this.rdItaly.TabStop = true;
            this.rdItaly.Text = "Italy";
            this.rdItaly.UseVisualStyleBackColor = true;
            this.rdItaly.CheckedChanged += new System.EventHandler(this.rdItaly_CheckedChanged);
            // 
            // rdUK
            // 
            this.rdUK.AutoSize = true;
            this.rdUK.Location = new System.Drawing.Point(7, 229);
            this.rdUK.Name = "rdUK";
            this.rdUK.Size = new System.Drawing.Size(62, 17);
            this.rdUK.TabIndex = 5;
            this.rdUK.TabStop = true;
            this.rdUK.Text = "The UK";
            this.rdUK.UseVisualStyleBackColor = true;
            this.rdUK.CheckedChanged += new System.EventHandler(this.rdUK_CheckedChanged);
            // 
            // rdTurkey
            // 
            this.rdTurkey.AutoSize = true;
            this.rdTurkey.Location = new System.Drawing.Point(7, 183);
            this.rdTurkey.Name = "rdTurkey";
            this.rdTurkey.Size = new System.Drawing.Size(58, 17);
            this.rdTurkey.TabIndex = 4;
            this.rdTurkey.TabStop = true;
            this.rdTurkey.Text = "Turkey";
            this.rdTurkey.UseVisualStyleBackColor = true;
            this.rdTurkey.CheckedChanged += new System.EventHandler(this.rdTurkey_CheckedChanged);
            // 
            // rdSpain
            // 
            this.rdSpain.AutoSize = true;
            this.rdSpain.Location = new System.Drawing.Point(7, 142);
            this.rdSpain.Name = "rdSpain";
            this.rdSpain.Size = new System.Drawing.Size(52, 17);
            this.rdSpain.TabIndex = 3;
            this.rdSpain.TabStop = true;
            this.rdSpain.Text = "Spain";
            this.rdSpain.UseVisualStyleBackColor = true;
            this.rdSpain.CheckedChanged += new System.EventHandler(this.rdSpain_CheckedChanged);
            // 
            // rdHungary
            // 
            this.rdHungary.AutoSize = true;
            this.rdHungary.Location = new System.Drawing.Point(7, 102);
            this.rdHungary.Name = "rdHungary";
            this.rdHungary.Size = new System.Drawing.Size(65, 17);
            this.rdHungary.TabIndex = 2;
            this.rdHungary.TabStop = true;
            this.rdHungary.Text = "Hungary";
            this.rdHungary.UseVisualStyleBackColor = true;
            this.rdHungary.CheckedChanged += new System.EventHandler(this.rdHungary_CheckedChanged);
            // 
            // rdJapan
            // 
            this.rdJapan.AutoSize = true;
            this.rdJapan.Location = new System.Drawing.Point(7, 67);
            this.rdJapan.Name = "rdJapan";
            this.rdJapan.Size = new System.Drawing.Size(54, 17);
            this.rdJapan.TabIndex = 1;
            this.rdJapan.TabStop = true;
            this.rdJapan.Text = "Japan";
            this.rdJapan.UseVisualStyleBackColor = true;
            this.rdJapan.CheckedChanged += new System.EventHandler(this.rdJapan_CheckedChanged);
            // 
            // rdFrance
            // 
            this.rdFrance.AutoSize = true;
            this.rdFrance.Location = new System.Drawing.Point(7, 29);
            this.rdFrance.Name = "rdFrance";
            this.rdFrance.Size = new System.Drawing.Size(58, 17);
            this.rdFrance.TabIndex = 0;
            this.rdFrance.TabStop = true;
            this.rdFrance.Text = "France";
            this.rdFrance.UseVisualStyleBackColor = true;
            this.rdFrance.CheckedChanged += new System.EventHandler(this.rdFrance_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdParis);
            this.groupBox2.Controls.Add(this.rdBudapest);
            this.groupBox2.Controls.Add(this.rdAnkara);
            this.groupBox2.Controls.Add(this.rdLondon);
            this.groupBox2.Controls.Add(this.rdMadrid);
            this.groupBox2.Controls.Add(this.rdRome);
            this.groupBox2.Controls.Add(this.rdTokyo);
            this.groupBox2.Controls.Add(this.rdBuenos);
            this.groupBox2.Location = new System.Drawing.Point(337, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capital";
            // 
            // rdParis
            // 
            this.rdParis.AutoSize = true;
            this.rdParis.Location = new System.Drawing.Point(16, 312);
            this.rdParis.Name = "rdParis";
            this.rdParis.Size = new System.Drawing.Size(48, 17);
            this.rdParis.TabIndex = 7;
            this.rdParis.TabStop = true;
            this.rdParis.Text = "Paris";
            this.rdParis.UseVisualStyleBackColor = true;
            this.rdParis.CheckedChanged += new System.EventHandler(this.rdParis_CheckedChanged);
            // 
            // rdBudapest
            // 
            this.rdBudapest.AutoSize = true;
            this.rdBudapest.Location = new System.Drawing.Point(16, 269);
            this.rdBudapest.Name = "rdBudapest";
            this.rdBudapest.Size = new System.Drawing.Size(70, 17);
            this.rdBudapest.TabIndex = 6;
            this.rdBudapest.TabStop = true;
            this.rdBudapest.Text = "Budapest";
            this.rdBudapest.UseVisualStyleBackColor = true;
            this.rdBudapest.CheckedChanged += new System.EventHandler(this.rdBudapest_CheckedChanged);
            // 
            // rdAnkara
            // 
            this.rdAnkara.AutoSize = true;
            this.rdAnkara.Location = new System.Drawing.Point(16, 229);
            this.rdAnkara.Name = "rdAnkara";
            this.rdAnkara.Size = new System.Drawing.Size(59, 17);
            this.rdAnkara.TabIndex = 5;
            this.rdAnkara.TabStop = true;
            this.rdAnkara.Text = "Ankara";
            this.rdAnkara.UseVisualStyleBackColor = true;
            this.rdAnkara.CheckedChanged += new System.EventHandler(this.rdAnkara_CheckedChanged);
            // 
            // rdLondon
            // 
            this.rdLondon.AutoSize = true;
            this.rdLondon.Location = new System.Drawing.Point(16, 183);
            this.rdLondon.Name = "rdLondon";
            this.rdLondon.Size = new System.Drawing.Size(61, 17);
            this.rdLondon.TabIndex = 4;
            this.rdLondon.TabStop = true;
            this.rdLondon.Text = "London";
            this.rdLondon.UseVisualStyleBackColor = true;
            this.rdLondon.CheckedChanged += new System.EventHandler(this.rdLondon_CheckedChanged);
            // 
            // rdMadrid
            // 
            this.rdMadrid.AutoSize = true;
            this.rdMadrid.Location = new System.Drawing.Point(16, 142);
            this.rdMadrid.Name = "rdMadrid";
            this.rdMadrid.Size = new System.Drawing.Size(57, 17);
            this.rdMadrid.TabIndex = 3;
            this.rdMadrid.TabStop = true;
            this.rdMadrid.Text = "Madrid";
            this.rdMadrid.UseVisualStyleBackColor = true;
            this.rdMadrid.CheckedChanged += new System.EventHandler(this.rdMadrid_CheckedChanged);
            // 
            // rdRome
            // 
            this.rdRome.AutoSize = true;
            this.rdRome.Location = new System.Drawing.Point(16, 102);
            this.rdRome.Name = "rdRome";
            this.rdRome.Size = new System.Drawing.Size(53, 17);
            this.rdRome.TabIndex = 2;
            this.rdRome.TabStop = true;
            this.rdRome.Text = "Rome";
            this.rdRome.UseVisualStyleBackColor = true;
            this.rdRome.CheckedChanged += new System.EventHandler(this.rdRome_CheckedChanged);
            // 
            // rdTokyo
            // 
            this.rdTokyo.AutoSize = true;
            this.rdTokyo.Location = new System.Drawing.Point(16, 67);
            this.rdTokyo.Name = "rdTokyo";
            this.rdTokyo.Size = new System.Drawing.Size(55, 17);
            this.rdTokyo.TabIndex = 1;
            this.rdTokyo.TabStop = true;
            this.rdTokyo.Text = "Tokyo";
            this.rdTokyo.UseVisualStyleBackColor = true;
            this.rdTokyo.CheckedChanged += new System.EventHandler(this.rdTokyo_CheckedChanged);
            // 
            // rdBuenos
            // 
            this.rdBuenos.AutoSize = true;
            this.rdBuenos.Location = new System.Drawing.Point(16, 29);
            this.rdBuenos.Name = "rdBuenos";
            this.rdBuenos.Size = new System.Drawing.Size(87, 17);
            this.rdBuenos.TabIndex = 0;
            this.rdBuenos.TabStop = true;
            this.rdBuenos.Text = "Buenos Aries";
            this.rdBuenos.UseVisualStyleBackColor = true;
            this.rdBuenos.CheckedChanged += new System.EventHandler(this.rdBuenos_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(103, 405);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 462);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdUSA;
        private System.Windows.Forms.RadioButton rdItaly;
        private System.Windows.Forms.RadioButton rdUK;
        private System.Windows.Forms.RadioButton rdTurkey;
        private System.Windows.Forms.RadioButton rdSpain;
        private System.Windows.Forms.RadioButton rdHungary;
        private System.Windows.Forms.RadioButton rdJapan;
        private System.Windows.Forms.RadioButton rdFrance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdParis;
        private System.Windows.Forms.RadioButton rdBudapest;
        private System.Windows.Forms.RadioButton rdAnkara;
        private System.Windows.Forms.RadioButton rdLondon;
        private System.Windows.Forms.RadioButton rdMadrid;
        private System.Windows.Forms.RadioButton rdRome;
        private System.Windows.Forms.RadioButton rdTokyo;
        private System.Windows.Forms.RadioButton rdBuenos;
        private System.Windows.Forms.Label label;
    }
}
namespace DEMO_V1
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
            this.lsvD = new System.Windows.Forms.ListView();
            this.lsvItemsCode = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinSup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbrMinSup = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnItemSets = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.txtPreMinSup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMinSup)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvD
            // 
            this.lsvD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvD.HideSelection = false;
            this.lsvD.Location = new System.Drawing.Point(19, 3);
            this.lsvD.Name = "lsvD";
            this.lsvD.Size = new System.Drawing.Size(811, 254);
            this.lsvD.TabIndex = 0;
            this.lsvD.UseCompatibleStateImageBehavior = false;
            // 
            // lsvItemsCode
            // 
            this.lsvItemsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvItemsCode.HideSelection = false;
            this.lsvItemsCode.Location = new System.Drawing.Point(3, 27);
            this.lsvItemsCode.Name = "lsvItemsCode";
            this.lsvItemsCode.Size = new System.Drawing.Size(314, 184);
            this.lsvItemsCode.TabIndex = 0;
            this.lsvItemsCode.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvItemsCode);
            this.panel1.Location = new System.Drawing.Point(791, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 240);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa item:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvD);
            this.panel2.Location = new System.Drawing.Point(146, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 260);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BẢNG GIAO TÁC (TẬP D)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(341, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÌM LUẬT THEO THUẬT TOÁN APRIORI TID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "MinSup:";
            // 
            // txtMinSup
            // 
            this.txtMinSup.Enabled = false;
            this.txtMinSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinSup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinSup.Location = new System.Drawing.Point(187, 14);
            this.txtMinSup.Name = "txtMinSup";
            this.txtMinSup.ReadOnly = true;
            this.txtMinSup.Size = new System.Drawing.Size(43, 26);
            this.txtMinSup.TabIndex = 4;
            this.txtMinSup.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "%";
            // 
            // tbrMinSup
            // 
            this.tbrMinSup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbrMinSup.Location = new System.Drawing.Point(20, 86);
            this.tbrMinSup.Maximum = 100;
            this.tbrMinSup.Minimum = 1;
            this.tbrMinSup.Name = "tbrMinSup";
            this.tbrMinSup.Size = new System.Drawing.Size(518, 45);
            this.tbrMinSup.TabIndex = 5;
            this.tbrMinSup.Value = 25;
            this.tbrMinSup.ValueChanged += new System.EventHandler(this.tbrMinSup_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "1%";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnItemSets);
            this.panel3.Controls.Add(this.btnD);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbrMinSup);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtMinSup);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(33, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 230);
            this.panel3.TabIndex = 6;
            // 
            // btnItemSets
            // 
            this.btnItemSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSets.Location = new System.Drawing.Point(270, 132);
            this.btnItemSets.Name = "btnItemSets";
            this.btnItemSets.Size = new System.Drawing.Size(222, 28);
            this.btnItemSets.TabIndex = 6;
            this.btnItemSets.Text = "TÌM ITEMSETS";
            this.btnItemSets.UseVisualStyleBackColor = true;
            this.btnItemSets.Click += new System.EventHandler(this.btnItemSets_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(42, 132);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(222, 28);
            this.btnD.TabIndex = 6;
            this.btnD.Text = "TẬP D THÕA MinSup";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // txtPreMinSup
            // 
            this.txtPreMinSup.Enabled = false;
            this.txtPreMinSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreMinSup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPreMinSup.Location = new System.Drawing.Point(914, 55);
            this.txtPreMinSup.Name = "txtPreMinSup";
            this.txtPreMinSup.ReadOnly = true;
            this.txtPreMinSup.Size = new System.Drawing.Size(43, 26);
            this.txtPreMinSup.TabIndex = 4;
            this.txtPreMinSup.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(954, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(842, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "MinSup:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 614);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreMinSup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrMinSup)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvD;
        private System.Windows.Forms.ListView lsvItemsCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinSup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbrMinSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnItemSets;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox txtPreMinSup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


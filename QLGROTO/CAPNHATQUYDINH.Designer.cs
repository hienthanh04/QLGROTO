namespace QLGROTO
{
    partial class CAPNHATQUYDINH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAPNHATQUYDINH));
            panel1 = new Panel();
            label1 = new Label();
            maxxenumeric = new NumericUpDown();
            thoatbtn = new Button();
            capnhatbtn = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            hieuxenumeric = new NumericUpDown();
            vtptnumeric = new NumericUpDown();
            tiencongnumeric = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxxenumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hieuxenumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vtptnumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tiencongnumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 45);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT QUY ĐỊNH";
            label1.Click += label1_Click;
            // 
            // maxxenumeric
            // 
            maxxenumeric.BackColor = SystemColors.HighlightText;
            maxxenumeric.Location = new Point(538, 132);
            maxxenumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            maxxenumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxxenumeric.Name = "maxxenumeric";
            maxxenumeric.Size = new Size(111, 27);
            maxxenumeric.TabIndex = 0;
            maxxenumeric.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(732, 340);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 5;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // capnhatbtn
            // 
            capnhatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            capnhatbtn.BackColor = Color.FromArgb(0, 192, 0);
            capnhatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capnhatbtn.ForeColor = Color.White;
            capnhatbtn.Location = new Point(603, 340);
            capnhatbtn.Name = "capnhatbtn";
            capnhatbtn.Size = new Size(123, 45);
            capnhatbtn.TabIndex = 4;
            capnhatbtn.Text = "Cập nhật";
            capnhatbtn.UseVisualStyleBackColor = false;
            capnhatbtn.Click += capnhatbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(203, 132);
            label3.Name = "label3";
            label3.Size = new Size(313, 28);
            label3.TabIndex = 59;
            label3.Text = "Số lượng xe sửa tối đa trong ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(203, 174);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 60;
            label4.Text = "Số lượng hiệu xe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(203, 219);
            label5.Name = "label5";
            label5.Size = new Size(217, 28);
            label5.TabIndex = 61;
            label5.Text = "Số loại vật tư phụ tùng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(203, 262);
            label6.Name = "label6";
            label6.Size = new Size(163, 28);
            label6.TabIndex = 62;
            label6.Text = "Số loại tiền công:";
            // 
            // hieuxenumeric
            // 
            hieuxenumeric.BackColor = SystemColors.HighlightText;
            hieuxenumeric.Location = new Point(538, 175);
            hieuxenumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hieuxenumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            hieuxenumeric.Name = "hieuxenumeric";
            hieuxenumeric.Size = new Size(111, 27);
            hieuxenumeric.TabIndex = 1;
            hieuxenumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // vtptnumeric
            // 
            vtptnumeric.BackColor = SystemColors.HighlightText;
            vtptnumeric.Location = new Point(538, 220);
            vtptnumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            vtptnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            vtptnumeric.Name = "vtptnumeric";
            vtptnumeric.Size = new Size(111, 27);
            vtptnumeric.TabIndex = 2;
            vtptnumeric.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // tiencongnumeric
            // 
            tiencongnumeric.BackColor = SystemColors.HighlightText;
            tiencongnumeric.Location = new Point(538, 263);
            tiencongnumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            tiencongnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tiencongnumeric.Name = "tiencongnumeric";
            tiencongnumeric.Size = new Size(111, 27);
            tiencongnumeric.TabIndex = 3;
            tiencongnumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // CAPNHATQUYDINH
            // 
            AcceptButton = capnhatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(867, 397);
            Controls.Add(tiencongnumeric);
            Controls.Add(vtptnumeric);
            Controls.Add(hieuxenumeric);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(capnhatbtn);
            Controls.Add(thoatbtn);
            Controls.Add(maxxenumeric);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CAPNHATQUYDINH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật số xe sửa chữa tối đa trong ngày";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxxenumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)hieuxenumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)vtptnumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)tiencongnumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NumericUpDown maxxenumeric;
        private Button thoatbtn;
        private Button capnhatbtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown hieuxenumeric;
        private NumericUpDown vtptnumeric;
        private NumericUpDown tiencongnumeric;
    }
}
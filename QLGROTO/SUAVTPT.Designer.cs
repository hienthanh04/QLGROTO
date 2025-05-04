namespace QLGROTO
{
    partial class SUAVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUAVTPT));
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            dgtxtbox = new TextBox();
            tenvtpttxtbox = new TextBox();
            mavtpttxtbox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            capnhatbtn = new Button();
            thoatbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(82, 132);
            label5.Name = "label5";
            label5.Size = new Size(100, 31);
            label5.TabIndex = 57;
            label5.Text = "Đơn giá:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(71, 101);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 59;
            label7.Text = "Tên VTPT:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(73, 71);
            label8.Name = "label8";
            label8.Size = new Size(109, 31);
            label8.TabIndex = 60;
            label8.Text = "Mã VTPT:";
            // 
            // dgtxtbox
            // 
            dgtxtbox.Anchor = AnchorStyles.Top;
            dgtxtbox.BackColor = SystemColors.HighlightText;
            dgtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgtxtbox.Location = new Point(188, 134);
            dgtxtbox.Multiline = true;
            dgtxtbox.Name = "dgtxtbox";
            dgtxtbox.ScrollBars = ScrollBars.Horizontal;
            dgtxtbox.Size = new Size(360, 25);
            dgtxtbox.TabIndex = 51;
            dgtxtbox.TextChanged += dgtxtbox_TextChanged;
            // 
            // tenvtpttxtbox
            // 
            tenvtpttxtbox.Anchor = AnchorStyles.Top;
            tenvtpttxtbox.BackColor = SystemColors.HighlightText;
            tenvtpttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tenvtpttxtbox.Location = new Point(188, 103);
            tenvtpttxtbox.Multiline = true;
            tenvtpttxtbox.Name = "tenvtpttxtbox";
            tenvtpttxtbox.ScrollBars = ScrollBars.Horizontal;
            tenvtpttxtbox.Size = new Size(360, 25);
            tenvtpttxtbox.TabIndex = 54;
            // 
            // mavtpttxtbox
            // 
            mavtpttxtbox.Anchor = AnchorStyles.Top;
            mavtpttxtbox.BackColor = Color.Gainsboro;
            mavtpttxtbox.Enabled = false;
            mavtpttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mavtpttxtbox.Location = new Point(188, 73);
            mavtpttxtbox.Multiline = true;
            mavtpttxtbox.Name = "mavtpttxtbox";
            mavtpttxtbox.ReadOnly = true;
            mavtpttxtbox.ScrollBars = ScrollBars.Horizontal;
            mavtpttxtbox.Size = new Size(360, 25);
            mavtpttxtbox.TabIndex = 55;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 68);
            panel1.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(585, 45);
            label1.TabIndex = 0;
            label1.Text = "SỬA THÔNG TIN VẬT TƯ PHỤ TÙNG";
            // 
            // capnhatbtn
            // 
            capnhatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            capnhatbtn.BackColor = Color.FromArgb(0, 192, 0);
            capnhatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            capnhatbtn.ForeColor = Color.White;
            capnhatbtn.Location = new Point(345, 165);
            capnhatbtn.Name = "capnhatbtn";
            capnhatbtn.Size = new Size(123, 45);
            capnhatbtn.TabIndex = 65;
            capnhatbtn.Text = "Cập nhật";
            capnhatbtn.UseVisualStyleBackColor = false;
            capnhatbtn.Click += suabtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(474, 165);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 65;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // SUAVTPT
            // 
            AcceptButton = capnhatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(605, 211);
            Controls.Add(thoatbtn);
            Controls.Add(capnhatbtn);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dgtxtbox);
            Controls.Add(tenvtpttxtbox);
            Controls.Add(mavtpttxtbox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SUAVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật vật tư phụ tùng";
            Load += SUAVTPT_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox dgtxtbox;
        private TextBox tenvtpttxtbox;
        private TextBox mavtpttxtbox;
        private Panel panel1;
        private Label label1;
        private Button capnhatbtn;
        private Button thoatbtn;
    }
}
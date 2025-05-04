namespace QLGROTO
{
    partial class TIEPNHANXE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TIEPNHANXE));
            PhieuSuaChua_Title = new Label();
            biensotxtbox = new TextBox();
            TenChuXe = new Label();
            panel1 = new Panel();
            tentxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            diachitxtbox = new TextBox();
            dthtxtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            thoatbtn = new Button();
            tiepnhanbtn = new Button();
            ngaydtpicker = new DateTimePicker();
            label7 = new Label();
            emailtxtbox = new TextBox();
            hieuxecbbox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PhieuSuaChua_Title
            // 
            PhieuSuaChua_Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhieuSuaChua_Title.AutoSize = true;
            PhieuSuaChua_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhieuSuaChua_Title.ForeColor = Color.White;
            PhieuSuaChua_Title.Location = new Point(193, 10);
            PhieuSuaChua_Title.Name = "PhieuSuaChua_Title";
            PhieuSuaChua_Title.Size = new Size(322, 45);
            PhieuSuaChua_Title.TabIndex = 0;
            PhieuSuaChua_Title.Text = "TIẾP NHẬN XE SỬA";
            PhieuSuaChua_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // biensotxtbox
            // 
            biensotxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            biensotxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            biensotxtbox.Location = new Point(226, 104);
            biensotxtbox.Multiline = true;
            biensotxtbox.Name = "biensotxtbox";
            biensotxtbox.ScrollBars = ScrollBars.Horizontal;
            biensotxtbox.Size = new Size(362, 29);
            biensotxtbox.TabIndex = 1;
            // 
            // TenChuXe
            // 
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TenChuXe.Location = new Point(94, 137);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(126, 31);
            TenChuXe.TabIndex = 2;
            TenChuXe.Text = "Tên chủ xe:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(PhieuSuaChua_Title);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 66);
            panel1.TabIndex = 3;
            // 
            // tentxtbox
            // 
            tentxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tentxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tentxtbox.Location = new Point(226, 139);
            tentxtbox.Multiline = true;
            tentxtbox.Name = "tentxtbox";
            tentxtbox.ScrollBars = ScrollBars.Horizontal;
            tentxtbox.Size = new Size(362, 29);
            tentxtbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 102);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 2;
            label1.Text = "Biển số:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 172);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 2;
            label2.Text = "Hiệu xe:";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(226, 208);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(362, 29);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += TenChuXe_Box_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 206);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // diachitxtbox
            // 
            diachitxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            diachitxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            diachitxtbox.Location = new Point(226, 208);
            diachitxtbox.Multiline = true;
            diachitxtbox.Name = "diachitxtbox";
            diachitxtbox.ScrollBars = ScrollBars.Horizontal;
            diachitxtbox.Size = new Size(362, 29);
            diachitxtbox.TabIndex = 4;
            // 
            // dthtxtbox
            // 
            dthtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dthtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dthtxtbox.Location = new Point(226, 243);
            dthtxtbox.Multiline = true;
            dthtxtbox.Name = "dthtxtbox";
            dthtxtbox.ScrollBars = ScrollBars.Horizontal;
            dthtxtbox.Size = new Size(362, 29);
            dthtxtbox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(125, 206);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 2;
            label4.Text = "Hiệu xe:";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(96, 241);
            label5.Name = "label5";
            label5.Size = new Size(124, 31);
            label5.TabIndex = 2;
            label5.Text = "Điện thoại:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(44, 67);
            label6.Name = "label6";
            label6.Size = new Size(176, 31);
            label6.TabIndex = 2;
            label6.Text = "Ngày tiếp nhận:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(562, 318);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 8;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += huybtn_Click;
            // 
            // tiepnhanbtn
            // 
            tiepnhanbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tiepnhanbtn.BackColor = Color.FromArgb(0, 192, 0);
            tiepnhanbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tiepnhanbtn.ForeColor = Color.White;
            tiepnhanbtn.ImageAlign = ContentAlignment.MiddleLeft;
            tiepnhanbtn.Location = new Point(433, 318);
            tiepnhanbtn.Name = "tiepnhanbtn";
            tiepnhanbtn.Size = new Size(123, 45);
            tiepnhanbtn.TabIndex = 7;
            tiepnhanbtn.Text = "Tiếp nhận";
            tiepnhanbtn.UseVisualStyleBackColor = false;
            tiepnhanbtn.Click += xacnhanbtn_Click;
            // 
            // ngaydtpicker
            // 
            ngaydtpicker.Enabled = false;
            ngaydtpicker.Location = new Point(226, 71);
            ngaydtpicker.Name = "ngaydtpicker";
            ngaydtpicker.Size = new Size(362, 27);
            ngaydtpicker.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(145, 278);
            label7.Name = "label7";
            label7.Size = new Size(75, 31);
            label7.TabIndex = 7;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailtxtbox
            // 
            emailtxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxtbox.Location = new Point(226, 278);
            emailtxtbox.Multiline = true;
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.ScrollBars = ScrollBars.Horizontal;
            emailtxtbox.Size = new Size(362, 29);
            emailtxtbox.TabIndex = 6;
            // 
            // hieuxecbbox
            // 
            hieuxecbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            hieuxecbbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            hieuxecbbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hieuxecbbox.FormattingEnabled = true;
            hieuxecbbox.Location = new Point(226, 174);
            hieuxecbbox.Name = "hieuxecbbox";
            hieuxecbbox.Size = new Size(362, 28);
            hieuxecbbox.TabIndex = 3;
            hieuxecbbox.SelectedIndexChanged += hieuxecbbox_SelectedIndexChanged;
            // 
            // TIEPNHANXE
            // 
            AcceptButton = tiepnhanbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = thoatbtn;
            ClientSize = new Size(697, 375);
            Controls.Add(hieuxecbbox);
            Controls.Add(ngaydtpicker);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(emailtxtbox);
            Controls.Add(tiepnhanbtn);
            Controls.Add(thoatbtn);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TenChuXe);
            Controls.Add(dthtxtbox);
            Controls.Add(diachitxtbox);
            Controls.Add(textBox3);
            Controls.Add(tentxtbox);
            Controls.Add(biensotxtbox);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TIEPNHANXE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiếp nhận xe sửa";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label PhieuSuaChua_Title;
        private System.Windows.Forms.TextBox biensotxtbox;
        private System.Windows.Forms.Label TenChuXe;
        private System.Windows.Forms.Panel panel1;
        private TextBox tentxtbox;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox diachitxtbox;
        private TextBox dthtxtbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button thoatbtn;
        private Button tiepnhanbtn;
        private DateTimePicker ngaydtpicker;
        private Label label7;
        private TextBox emailtxtbox;
        private ComboBox hieuxecbbox;
    }
}


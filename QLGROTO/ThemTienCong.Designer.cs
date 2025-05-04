namespace QLGROTO
{
    partial class ThemTienCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTienCong));
            thembtn = new Button();
            thoatbtn = new Button();
            label7 = new Label();
            label8 = new Label();
            TenChuXe = new Label();
            tctxtbox = new TextBox();
            matctxtbox = new TextBox();
            ndtxtbox = new TextBox();
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // thembtn
            // 
            thembtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thembtn.BackColor = Color.FromArgb(0, 192, 0);
            thembtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thembtn.ForeColor = Color.White;
            thembtn.Location = new Point(369, 156);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(123, 45);
            thembtn.TabIndex = 68;
            thembtn.Text = "Thêm";
            thembtn.UseVisualStyleBackColor = false;
            thembtn.Click += thembtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(498, 156);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 69;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(111, 92);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 65;
            label7.Text = "Tiền công:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 63);
            label8.Name = "label8";
            label8.Size = new Size(197, 31);
            label8.TabIndex = 66;
            label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            TenChuXe.Anchor = AnchorStyles.Top;
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TenChuXe.Location = new Point(115, 123);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(115, 31);
            TenChuXe.TabIndex = 67;
            TenChuXe.Text = "Nội dung:";
            // 
            // tctxtbox
            // 
            tctxtbox.Anchor = AnchorStyles.Top;
            tctxtbox.BackColor = SystemColors.HighlightText;
            tctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tctxtbox.Location = new Point(235, 95);
            tctxtbox.Multiline = true;
            tctxtbox.Name = "tctxtbox";
            tctxtbox.ScrollBars = ScrollBars.Horizontal;
            tctxtbox.Size = new Size(361, 25);
            tctxtbox.TabIndex = 62;
            tctxtbox.TextChanged += tctxtbox_TextChanged;
            // 
            // matctxtbox
            // 
            matctxtbox.Anchor = AnchorStyles.Top;
            matctxtbox.BackColor = SystemColors.HighlightText;
            matctxtbox.Enabled = false;
            matctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            matctxtbox.Location = new Point(235, 65);
            matctxtbox.Multiline = true;
            matctxtbox.Name = "matctxtbox";
            matctxtbox.ScrollBars = ScrollBars.Horizontal;
            matctxtbox.Size = new Size(361, 25);
            matctxtbox.TabIndex = 63;
            // 
            // ndtxtbox
            // 
            ndtxtbox.Anchor = AnchorStyles.Top;
            ndtxtbox.BackColor = SystemColors.HighlightText;
            ndtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ndtxtbox.Location = new Point(235, 125);
            ndtxtbox.Multiline = true;
            ndtxtbox.Name = "ndtxtbox";
            ndtxtbox.ScrollBars = ScrollBars.Horizontal;
            ndtxtbox.Size = new Size(361, 25);
            ndtxtbox.TabIndex = 64;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 60);
            panel1.TabIndex = 70;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(139, 9);
            VatTuPhuTung_Title.Margin = new Padding(5, 0, 5, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(382, 45);
            VatTuPhuTung_Title.TabIndex = 71;
            VatTuPhuTung_Title.Text = "THÊM LOẠI TIỀN CÔNG";
            // 
            // ThemTienCong
            // 
            AcceptButton = thembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(633, 201);
            Controls.Add(panel1);
            Controls.Add(thembtn);
            Controls.Add(thoatbtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(TenChuXe);
            Controls.Add(tctxtbox);
            Controls.Add(matctxtbox);
            Controls.Add(ndtxtbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThemTienCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm loại tiền công";
            Load += ThemTienCong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button thembtn;
        private Button thoatbtn;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox tctxtbox;
        private TextBox matctxtbox;
        private TextBox ndtxtbox;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
    }
}
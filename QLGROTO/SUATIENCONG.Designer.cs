namespace QLGROTO
{
    partial class SUATIENCONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUATIENCONG));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            label7 = new Label();
            label8 = new Label();
            TenChuXe = new Label();
            tctxtbox = new TextBox();
            matctxtbox = new TextBox();
            ndtxtbox = new TextBox();
            thoatbtn = new Button();
            capnhatbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 58);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(94, 8);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(454, 45);
            VatTuPhuTung_Title.TabIndex = 3;
            VatTuPhuTung_Title.Text = "CẬP NHẬT LOẠI TIỀN CÔNG";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(107, 92);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 58;
            label7.Text = "Tiền công:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 62);
            label8.Name = "label8";
            label8.Size = new Size(197, 31);
            label8.TabIndex = 59;
            label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            TenChuXe.Anchor = AnchorStyles.Top;
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TenChuXe.Location = new Point(111, 122);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(115, 31);
            TenChuXe.TabIndex = 60;
            TenChuXe.Text = "Nội dung:";
            // 
            // tctxtbox
            // 
            tctxtbox.Anchor = AnchorStyles.Top;
            tctxtbox.BackColor = SystemColors.HighlightText;
            tctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tctxtbox.Location = new Point(232, 94);
            tctxtbox.Multiline = true;
            tctxtbox.Name = "tctxtbox";
            tctxtbox.ScrollBars = ScrollBars.Horizontal;
            tctxtbox.Size = new Size(360, 25);
            tctxtbox.TabIndex = 54;
            tctxtbox.TextChanged += tctxtbox_TextChanged;
            // 
            // matctxtbox
            // 
            matctxtbox.Anchor = AnchorStyles.Top;
            matctxtbox.BackColor = Color.Gainsboro;
            matctxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            matctxtbox.Location = new Point(232, 64);
            matctxtbox.Multiline = true;
            matctxtbox.Name = "matctxtbox";
            matctxtbox.ReadOnly = true;
            matctxtbox.ScrollBars = ScrollBars.Horizontal;
            matctxtbox.Size = new Size(360, 25);
            matctxtbox.TabIndex = 55;
            // 
            // ndtxtbox
            // 
            ndtxtbox.Anchor = AnchorStyles.Top;
            ndtxtbox.BackColor = SystemColors.HighlightText;
            ndtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ndtxtbox.Location = new Point(232, 124);
            ndtxtbox.Multiline = true;
            ndtxtbox.Name = "ndtxtbox";
            ndtxtbox.ScrollBars = ScrollBars.Horizontal;
            ndtxtbox.Size = new Size(360, 25);
            ndtxtbox.TabIndex = 56;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(494, 155);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 61;
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
            capnhatbtn.Location = new Point(365, 155);
            capnhatbtn.Name = "capnhatbtn";
            capnhatbtn.Size = new Size(123, 45);
            capnhatbtn.TabIndex = 61;
            capnhatbtn.Text = "Cập nhật";
            capnhatbtn.UseVisualStyleBackColor = false;
            capnhatbtn.Click += suabtn_Click;
            // 
            // SUATIENCONG
            // 
            AcceptButton = capnhatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(629, 202);
            Controls.Add(capnhatbtn);
            Controls.Add(thoatbtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(TenChuXe);
            Controls.Add(tctxtbox);
            Controls.Add(matctxtbox);
            Controls.Add(ndtxtbox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SUATIENCONG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cập nhật loại tiền công";
            Load += ChangeWageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private TextBox tctxtbox;
        private TextBox matctxtbox;
        private TextBox ndtxtbox;
        private Button thoatbtn;
        private Button capnhatbtn;
    }
}
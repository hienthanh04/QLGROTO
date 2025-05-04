namespace QLGROTO
{
    partial class THEMVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THEMVTPT));
            thembtn = new Button();
            thoatbtn = new Button();
            label7 = new Label();
            label8 = new Label();
            tenvttxtbox = new TextBox();
            mavttxtbox = new TextBox();
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
            thembtn.Location = new Point(437, 188);
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
            thoatbtn.Location = new Point(566, 188);
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
            label7.Location = new Point(73, 136);
            label7.Name = "label7";
            label7.Size = new Size(219, 31);
            label7.TabIndex = 65;
            label7.Text = "Tên vật tư phụ tùng:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(75, 105);
            label8.Name = "label8";
            label8.Size = new Size(217, 31);
            label8.TabIndex = 66;
            label8.Text = "Mã vật tư phụ tùng:";
            // 
            // tenvttxtbox
            // 
            tenvttxtbox.Anchor = AnchorStyles.Top;
            tenvttxtbox.BackColor = SystemColors.HighlightText;
            tenvttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tenvttxtbox.Location = new Point(318, 142);
            tenvttxtbox.Multiline = true;
            tenvttxtbox.Name = "tenvttxtbox";
            tenvttxtbox.ScrollBars = ScrollBars.Horizontal;
            tenvttxtbox.Size = new Size(307, 25);
            tenvttxtbox.TabIndex = 62;
            // 
            // mavttxtbox
            // 
            mavttxtbox.Anchor = AnchorStyles.Top;
            mavttxtbox.BackColor = SystemColors.HighlightText;
            mavttxtbox.Enabled = false;
            mavttxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mavttxtbox.Location = new Point(318, 111);
            mavttxtbox.Multiline = true;
            mavttxtbox.Name = "mavttxtbox";
            mavttxtbox.ScrollBars = ScrollBars.Horizontal;
            mavttxtbox.Size = new Size(307, 25);
            mavttxtbox.TabIndex = 63;
            mavttxtbox.TextChanged += mavttxtbox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 60);
            panel1.TabIndex = 70;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(151, 9);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(420, 45);
            VatTuPhuTung_Title.TabIndex = 71;
            VatTuPhuTung_Title.Text = "THÊM VẬT TƯ PHỤ TÙNG";
            // 
            // THEMVTPT
            // 
            AcceptButton = thembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(701, 245);
            Controls.Add(panel1);
            Controls.Add(thembtn);
            Controls.Add(thoatbtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(tenvttxtbox);
            Controls.Add(mavttxtbox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "THEMVTPT";
            Text = "Thêm vật tư phụ tùng";
            Load += THEMVTPT_Load;
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
        private TextBox tenvttxtbox;
        private TextBox mavttxtbox;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
    }
}
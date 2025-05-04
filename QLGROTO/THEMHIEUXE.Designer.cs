namespace QLGROTO
{
    partial class THEMHIEUXE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THEMHIEUXE));
            panel1 = new Panel();
            label1 = new Label();
            thembtn = new Button();
            thoatbtn = new Button();
            label8 = new Label();
            themtxtbox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(146, 10);
            label1.Name = "label1";
            label1.Size = new Size(249, 45);
            label1.TabIndex = 2;
            label1.Text = "THÊM HIỆU XE";
            // 
            // thembtn
            // 
            thembtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thembtn.BackColor = Color.FromArgb(0, 192, 0);
            thembtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thembtn.ForeColor = Color.White;
            thembtn.Location = new Point(277, 143);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(123, 45);
            thembtn.TabIndex = 62;
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
            thoatbtn.Location = new Point(406, 143);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 63;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(35, 96);
            label8.Name = "label8";
            label8.Size = new Size(95, 31);
            label8.TabIndex = 68;
            label8.Text = "Hiệu xe:";
            // 
            // themtxtbox
            // 
            themtxtbox.Anchor = AnchorStyles.Top;
            themtxtbox.BackColor = SystemColors.HighlightText;
            themtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            themtxtbox.Location = new Point(136, 98);
            themtxtbox.Multiline = true;
            themtxtbox.Name = "themtxtbox";
            themtxtbox.ScrollBars = ScrollBars.Horizontal;
            themtxtbox.Size = new Size(360, 25);
            themtxtbox.TabIndex = 67;
            // 
            // THEMHIEUXE
            // 
            AcceptButton = thembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(541, 200);
            Controls.Add(label8);
            Controls.Add(themtxtbox);
            Controls.Add(thembtn);
            Controls.Add(thoatbtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "THEMHIEUXE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm hiệu xe";
            Load += ThemHieuXe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button thembtn;
        private Button thoatbtn;
        private Label label8;
        private TextBox themtxtbox;
    }
}
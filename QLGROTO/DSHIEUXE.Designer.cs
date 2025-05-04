namespace QLGROTO
{
    partial class DSHIEUXE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSHIEUXE));
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            timhieuxetxtbox = new TextBox();
            label1 = new Label();
            hieuxedtgrid = new DataGridView();
            HieuXe = new DataGridViewTextBoxColumn();
            xoahieuxebtn = new Button();
            themhieuxebtn = new Button();
            thoatbtn = new Button();
            timkiembtn = new Button();
            xuatbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hieuxedtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 64);
            panel1.TabIndex = 0;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(225, 9);
            VatTuPhuTung_Title.Margin = new Padding(4, 0, 4, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(350, 45);
            VatTuPhuTung_Title.TabIndex = 4;
            VatTuPhuTung_Title.Text = "DANH SÁCH HIỆU XE";
            // 
            // timhieuxetxtbox
            // 
            timhieuxetxtbox.Anchor = AnchorStyles.Top;
            timhieuxetxtbox.BackColor = SystemColors.HighlightText;
            timhieuxetxtbox.Location = new Point(230, 68);
            timhieuxetxtbox.Name = "timhieuxetxtbox";
            timhieuxetxtbox.Size = new Size(371, 27);
            timhieuxetxtbox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(120, 67);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 13;
            label1.Text = "Tìm kiếm:";
            // 
            // hieuxedtgrid
            // 
            hieuxedtgrid.AllowUserToAddRows = false;
            hieuxedtgrid.AllowUserToDeleteRows = false;
            hieuxedtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hieuxedtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hieuxedtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hieuxedtgrid.Columns.AddRange(new DataGridViewColumn[] { HieuXe });
            hieuxedtgrid.Location = new Point(12, 101);
            hieuxedtgrid.Name = "hieuxedtgrid";
            hieuxedtgrid.ReadOnly = true;
            hieuxedtgrid.RowHeadersWidth = 51;
            hieuxedtgrid.RowTemplate.Height = 29;
            hieuxedtgrid.Size = new Size(776, 344);
            hieuxedtgrid.TabIndex = 2;
            hieuxedtgrid.TabStop = false;
            // 
            // HieuXe
            // 
            HieuXe.DataPropertyName = "HieuXe";
            HieuXe.HeaderText = "Hiệu xe";
            HieuXe.MinimumWidth = 6;
            HieuXe.Name = "HieuXe";
            HieuXe.ReadOnly = true;
            // 
            // xoahieuxebtn
            // 
            xoahieuxebtn.Anchor = AnchorStyles.Bottom;
            xoahieuxebtn.BackColor = Color.FromArgb(192, 0, 0);
            xoahieuxebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xoahieuxebtn.ForeColor = Color.White;
            xoahieuxebtn.ImageAlign = ContentAlignment.MiddleLeft;
            xoahieuxebtn.Location = new Point(263, 451);
            xoahieuxebtn.Name = "xoahieuxebtn";
            xoahieuxebtn.Size = new Size(239, 65);
            xoahieuxebtn.TabIndex = 3;
            xoahieuxebtn.Text = "Xóa hiệu xe";
            xoahieuxebtn.UseVisualStyleBackColor = false;
            xoahieuxebtn.Click += xoahieuxebtn_Click;
            // 
            // themhieuxebtn
            // 
            themhieuxebtn.Anchor = AnchorStyles.Bottom;
            themhieuxebtn.BackColor = Color.FromArgb(0, 192, 0);
            themhieuxebtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            themhieuxebtn.ForeColor = Color.White;
            themhieuxebtn.ImageAlign = ContentAlignment.MiddleLeft;
            themhieuxebtn.Location = new Point(12, 451);
            themhieuxebtn.Name = "themhieuxebtn";
            themhieuxebtn.Size = new Size(226, 65);
            themhieuxebtn.TabIndex = 2;
            themhieuxebtn.Text = "Thêm hiệu xe";
            themhieuxebtn.UseVisualStyleBackColor = false;
            themhieuxebtn.Click += themhieuxebtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(665, 522);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 5;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button1_Click;
            // 
            // timkiembtn
            // 
            timkiembtn.Anchor = AnchorStyles.Top;
            timkiembtn.BackColor = SystemColors.Info;
            timkiembtn.Image = Properties.Resources.search_6699087_640__1_;
            timkiembtn.Location = new Point(607, 68);
            timkiembtn.Name = "timkiembtn";
            timkiembtn.Size = new Size(79, 27);
            timkiembtn.TabIndex = 1;
            timkiembtn.UseVisualStyleBackColor = false;
            timkiembtn.Click += timkiembtn_Click;
            // 
            // xuatbtn
            // 
            xuatbtn.Anchor = AnchorStyles.Bottom;
            xuatbtn.BackColor = SystemColors.Control;
            xuatbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            xuatbtn.ForeColor = SystemColors.ActiveCaptionText;
            xuatbtn.ImageAlign = ContentAlignment.MiddleLeft;
            xuatbtn.Location = new Point(540, 451);
            xuatbtn.Name = "xuatbtn";
            xuatbtn.Size = new Size(248, 65);
            xuatbtn.TabIndex = 4;
            xuatbtn.Text = "Xuất file danh sách";
            xuatbtn.UseVisualStyleBackColor = false;
            xuatbtn.Click += xuatbtn_Click;
            // 
            // DSHIEUXE
            // 
            AcceptButton = timkiembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(800, 579);
            Controls.Add(xuatbtn);
            Controls.Add(timkiembtn);
            Controls.Add(thoatbtn);
            Controls.Add(xoahieuxebtn);
            Controls.Add(themhieuxebtn);
            Controls.Add(hieuxedtgrid);
            Controls.Add(timhieuxetxtbox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DSHIEUXE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hiệu xe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hieuxedtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private TextBox timhieuxetxtbox;
        private Label label1;
        private DataGridView hieuxedtgrid;
        private Button xoahieuxebtn;
        private Button themhieuxebtn;
        private Button thoatbtn;
        private DataGridViewTextBoxColumn HieuXe;
        private Button timkiembtn;
        private Button xuatbtn;
    }
}
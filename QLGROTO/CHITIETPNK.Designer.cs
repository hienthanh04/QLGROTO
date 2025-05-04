namespace QLGROTO
{
    partial class CHITIETPNK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHITIETPNK));
            panel1 = new Panel();
            label1 = new Label();
            pnkvtptdtgrid = new DataGridView();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            thoatbtn = new Button();
            label2 = new Label();
            label3 = new Label();
            ngaynhapdtpicker = new DateTimePicker();
            mpntxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnkvtptdtgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(606, 45);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // pnkvtptdtgrid
            // 
            pnkvtptdtgrid.AllowUserToAddRows = false;
            pnkvtptdtgrid.AllowUserToDeleteRows = false;
            pnkvtptdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnkvtptdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pnkvtptdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pnkvtptdtgrid.Columns.AddRange(new DataGridViewColumn[] { MaVTPT, TenVTPT, SoLuong, GiaNhap });
            pnkvtptdtgrid.Location = new Point(14, 112);
            pnkvtptdtgrid.Name = "pnkvtptdtgrid";
            pnkvtptdtgrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            pnkvtptdtgrid.RowHeadersWidth = 51;
            pnkvtptdtgrid.RowTemplate.Height = 29;
            pnkvtptdtgrid.ScrollBars = ScrollBars.Vertical;
            pnkvtptdtgrid.Size = new Size(1152, 488);
            pnkvtptdtgrid.TabIndex = 3;
            pnkvtptdtgrid.TabStop = false;
            pnkvtptdtgrid.CellContentClick += pnkvtptdtgrid_CellContentClick;
            // 
            // MaVTPT
            // 
            MaVTPT.DataPropertyName = "MaVTPT";
            MaVTPT.HeaderText = "Mã VTPT";
            MaVTPT.MinimumWidth = 6;
            MaVTPT.Name = "MaVTPT";
            // 
            // TenVTPT
            // 
            TenVTPT.DataPropertyName = "TenVTPT";
            TenVTPT.HeaderText = "Tên VTPT";
            TenVTPT.MinimumWidth = 6;
            TenVTPT.Name = "TenVTPT";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            GiaNhap.HeaderText = "Đơn giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1043, 606);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 1;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 79);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã phiếu nhập:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(607, 75);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 3;
            label3.Text = "Ngày nhập:";
            // 
            // ngaynhapdtpicker
            // 
            ngaynhapdtpicker.Anchor = AnchorStyles.Top;
            ngaynhapdtpicker.Enabled = false;
            ngaynhapdtpicker.Location = new Point(725, 77);
            ngaynhapdtpicker.Name = "ngaynhapdtpicker";
            ngaynhapdtpicker.Size = new Size(250, 27);
            ngaynhapdtpicker.TabIndex = 5;
            // 
            // mpntxtbox
            // 
            mpntxtbox.Anchor = AnchorStyles.Top;
            mpntxtbox.BackColor = Color.Gainsboro;
            mpntxtbox.Enabled = false;
            mpntxtbox.Location = new Point(331, 79);
            mpntxtbox.Name = "mpntxtbox";
            mpntxtbox.ReadOnly = true;
            mpntxtbox.Size = new Size(220, 27);
            mpntxtbox.TabIndex = 6;
            // 
            // CHITIETPNK
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1178, 656);
            Controls.Add(mpntxtbox);
            Controls.Add(ngaynhapdtpicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(thoatbtn);
            Controls.Add(pnkvtptdtgrid);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CHITIETPNK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập vật tư phụ tùng";
            Load += CHITIETPNK_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnkvtptdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView pnkvtptdtgrid;
        private Button thoatbtn;
        private Label label2;
        private Label label3;
        private DateTimePicker ngaynhapdtpicker;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private TextBox mpntxtbox;
    }
}
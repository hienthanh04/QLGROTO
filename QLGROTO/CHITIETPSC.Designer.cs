namespace QLGROTO
{
    partial class CHITIETPSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHITIETPSC));
            ngaydtpicker = new DateTimePicker();
            biensotxtbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            ttttxtbox = new TextBox();
            thoatbtn = new Button();
            pscdtgrid = new DataGridView();
            NoiDung = new DataGridViewTextBoxColumn();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TienCong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label5 = new Label();
            masctxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).BeginInit();
            SuspendLayout();
            // 
            // ngaydtpicker
            // 
            ngaydtpicker.Anchor = AnchorStyles.Top;
            ngaydtpicker.Enabled = false;
            ngaydtpicker.Location = new Point(1001, 67);
            ngaydtpicker.Name = "ngaydtpicker";
            ngaydtpicker.Size = new Size(250, 27);
            ngaydtpicker.TabIndex = 9;
            // 
            // biensotxtbox
            // 
            biensotxtbox.Anchor = AnchorStyles.Top;
            biensotxtbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            biensotxtbox.BackColor = Color.Gainsboro;
            biensotxtbox.Enabled = false;
            biensotxtbox.Location = new Point(609, 69);
            biensotxtbox.Name = "biensotxtbox";
            biensotxtbox.Size = new Size(220, 27);
            biensotxtbox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(850, 68);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 6;
            label3.Text = "Ngày sửa chữa:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(501, 68);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 7;
            label2.Text = "Biển số xe:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(526, 10);
            label1.Name = "label1";
            label1.Size = new Size(298, 45);
            label1.TabIndex = 10;
            label1.Text = "PHIẾU SỬA CHỮA";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1346, 62);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(491, 550);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 7;
            label4.Text = "Tổng thành tiền:";
            // 
            // ttttxtbox
            // 
            ttttxtbox.Anchor = AnchorStyles.Top;
            ttttxtbox.BackColor = Color.Gainsboro;
            ttttxtbox.Enabled = false;
            ttttxtbox.Location = new Point(651, 550);
            ttttxtbox.Name = "ttttxtbox";
            ttttxtbox.ReadOnly = true;
            ttttxtbox.ShortcutsEnabled = false;
            ttttxtbox.Size = new Size(220, 27);
            ttttxtbox.TabIndex = 8;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1212, 541);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 0;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // pscdtgrid
            // 
            pscdtgrid.AllowUserToAddRows = false;
            pscdtgrid.AllowUserToDeleteRows = false;
            pscdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pscdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pscdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pscdtgrid.Columns.AddRange(new DataGridViewColumn[] { NoiDung, MaVTPT, TenVTPT, SoLuong, DonGia, TienCong, ThanhTien });
            pscdtgrid.Location = new Point(12, 102);
            pscdtgrid.Name = "pscdtgrid";
            pscdtgrid.RowHeadersWidth = 51;
            pscdtgrid.RowTemplate.Height = 29;
            pscdtgrid.Size = new Size(1323, 439);
            pscdtgrid.TabIndex = 0;
            pscdtgrid.TabStop = false;
            pscdtgrid.CellContentClick += pscdtgrid_CellContentClick;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
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
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // TienCong
            // 
            TienCong.DataPropertyName = "TienCong";
            TienCong.HeaderText = "Tiền công";
            TienCong.MinimumWidth = 6;
            TienCong.Name = "TienCong";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 65);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 7;
            label5.Text = "Mã phiếu sửa chữa:";
            // 
            // masctxtbox
            // 
            masctxtbox.Anchor = AnchorStyles.Top;
            masctxtbox.BackColor = Color.Gainsboro;
            masctxtbox.Enabled = false;
            masctxtbox.Location = new Point(251, 69);
            masctxtbox.Name = "masctxtbox";
            masctxtbox.Size = new Size(220, 27);
            masctxtbox.TabIndex = 8;
            // 
            // CHITIETPSC
            // 
            AcceptButton = thoatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1347, 591);
            Controls.Add(pscdtgrid);
            Controls.Add(thoatbtn);
            Controls.Add(panel1);
            Controls.Add(ngaydtpicker);
            Controls.Add(ttttxtbox);
            Controls.Add(masctxtbox);
            Controls.Add(biensotxtbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CHITIETPSC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu sửa chữa";
            Load += CHITIETPSC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ngaydtpicker;
        private TextBox biensotxtbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox ttttxtbox;
        private Button thoatbtn;
        private DataGridView pscdtgrid;
        private Label label5;
        private TextBox masctxtbox;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TienCong;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}
namespace QLGROTO
{
    partial class PHIEUSUACHUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHIEUSUACHUA));
            ngaynhapdtpicker = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            thoatbtn = new Button();
            lapphieubtn = new Button();
            label5 = new Label();
            mapsctxtbox = new TextBox();
            panel2 = new Panel();
            slnumeric = new NumericUpDown();
            thembtn = new Button();
            thanhtientxtbox = new TextBox();
            button6 = new Button();
            tonkhotxtbox = new TextBox();
            dgtxtbox = new TextBox();
            tctxtbox = new TextBox();
            ptcbbox = new ComboBox();
            ndcbbox = new ComboBox();
            label12 = new Label();
            label8 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            pscdtgrid = new DataGridView();
            NoiDung = new DataGridViewTextBoxColumn();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TienCong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            ttttxtbox = new TextBox();
            label11 = new Label();
            biensocbbox = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slnumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).BeginInit();
            SuspendLayout();
            // 
            // ngaynhapdtpicker
            // 
            ngaynhapdtpicker.Anchor = AnchorStyles.Top;
            ngaynhapdtpicker.CalendarForeColor = Color.Gainsboro;
            ngaynhapdtpicker.Enabled = false;
            ngaynhapdtpicker.Location = new Point(940, 67);
            ngaynhapdtpicker.Name = "ngaynhapdtpicker";
            ngaynhapdtpicker.Size = new Size(250, 27);
            ngaynhapdtpicker.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(822, 65);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 6;
            label3.Text = "Ngày nhập:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(485, 65);
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
            label1.Location = new Point(553, 10);
            label1.Name = "label1";
            label1.Size = new Size(298, 45);
            label1.TabIndex = 10;
            label1.Text = "PHIẾU SỬA CHỮA";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 63);
            panel1.TabIndex = 11;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1251, 692);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 13;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += huybtn_Click;
            // 
            // lapphieubtn
            // 
            lapphieubtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lapphieubtn.BackColor = Color.FromArgb(0, 192, 0);
            lapphieubtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lapphieubtn.ForeColor = Color.White;
            lapphieubtn.Location = new Point(1122, 692);
            lapphieubtn.Name = "lapphieubtn";
            lapphieubtn.Size = new Size(123, 45);
            lapphieubtn.TabIndex = 6;
            lapphieubtn.Text = "Lập phiếu";
            lapphieubtn.UseVisualStyleBackColor = false;
            lapphieubtn.Click += lapphieubtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(198, 65);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 7;
            label5.Text = "Mã phiếu:";
            // 
            // mapsctxtbox
            // 
            mapsctxtbox.Anchor = AnchorStyles.Top;
            mapsctxtbox.BackColor = Color.Gainsboro;
            mapsctxtbox.Enabled = false;
            mapsctxtbox.Location = new Point(298, 66);
            mapsctxtbox.Name = "mapsctxtbox";
            mapsctxtbox.ReadOnly = true;
            mapsctxtbox.Size = new Size(166, 27);
            mapsctxtbox.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(slnumeric);
            panel2.Controls.Add(thembtn);
            panel2.Controls.Add(thanhtientxtbox);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(tonkhotxtbox);
            panel2.Controls.Add(dgtxtbox);
            panel2.Controls.Add(tctxtbox);
            panel2.Controls.Add(ptcbbox);
            panel2.Controls.Add(ndcbbox);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1362, 155);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // slnumeric
            // 
            slnumeric.Anchor = AnchorStyles.Top;
            slnumeric.Location = new Point(1099, 62);
            slnumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            slnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            slnumeric.Name = "slnumeric";
            slnumeric.Size = new Size(245, 27);
            slnumeric.TabIndex = 3;
            slnumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            slnumeric.ValueChanged += slnumeric_ValueChanged;
            // 
            // thembtn
            // 
            thembtn.Anchor = AnchorStyles.Top;
            thembtn.Location = new Point(1150, 106);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(94, 29);
            thembtn.TabIndex = 4;
            thembtn.Text = "Thêm";
            thembtn.UseVisualStyleBackColor = true;
            thembtn.Click += button3_Click;
            // 
            // thanhtientxtbox
            // 
            thanhtientxtbox.Anchor = AnchorStyles.Top;
            thanhtientxtbox.BackColor = Color.Gainsboro;
            thanhtientxtbox.Enabled = false;
            thanhtientxtbox.Location = new Point(130, 106);
            thanhtientxtbox.Name = "thanhtientxtbox";
            thanhtientxtbox.Size = new Size(423, 27);
            thanhtientxtbox.TabIndex = 3;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.Location = new Point(1250, 106);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "Xóa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tonkhotxtbox
            // 
            tonkhotxtbox.Anchor = AnchorStyles.Top;
            tonkhotxtbox.BackColor = Color.Gainsboro;
            tonkhotxtbox.Enabled = false;
            tonkhotxtbox.Location = new Point(678, 106);
            tonkhotxtbox.Name = "tonkhotxtbox";
            tonkhotxtbox.Size = new Size(271, 27);
            tonkhotxtbox.TabIndex = 3;
            // 
            // dgtxtbox
            // 
            dgtxtbox.Anchor = AnchorStyles.Top;
            dgtxtbox.BackColor = Color.Gainsboro;
            dgtxtbox.Enabled = false;
            dgtxtbox.Location = new Point(677, 61);
            dgtxtbox.Name = "dgtxtbox";
            dgtxtbox.Size = new Size(271, 27);
            dgtxtbox.TabIndex = 3;
            // 
            // tctxtbox
            // 
            tctxtbox.Anchor = AnchorStyles.Top;
            tctxtbox.BackColor = Color.Gainsboro;
            tctxtbox.Enabled = false;
            tctxtbox.Location = new Point(1099, 18);
            tctxtbox.Name = "tctxtbox";
            tctxtbox.Size = new Size(245, 27);
            tctxtbox.TabIndex = 2;
            // 
            // ptcbbox
            // 
            ptcbbox.Anchor = AnchorStyles.Top;
            ptcbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ptcbbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            ptcbbox.FormattingEnabled = true;
            ptcbbox.Location = new Point(130, 61);
            ptcbbox.Name = "ptcbbox";
            ptcbbox.Size = new Size(423, 28);
            ptcbbox.TabIndex = 2;
            ptcbbox.SelectedIndexChanged += ptcbbox_SelectedIndexChanged;
            // 
            // ndcbbox
            // 
            ndcbbox.Anchor = AnchorStyles.Top;
            ndcbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ndcbbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            ndcbbox.FormattingEnabled = true;
            ndcbbox.Location = new Point(130, 18);
            ndcbbox.Name = "ndcbbox";
            ndcbbox.Size = new Size(818, 28);
            ndcbbox.TabIndex = 1;
            ndcbbox.SelectedIndexChanged += ndcbbox_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(581, 102);
            label12.Name = "label12";
            label12.Size = new Size(87, 28);
            label12.TabIndex = 0;
            label12.Text = "Tồn kho:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(580, 57);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 0;
            label8.Text = "Đơn giá:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(13, 102);
            label10.Name = "label10";
            label10.Size = new Size(107, 28);
            label10.TabIndex = 0;
            label10.Text = "Thành tiền:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 57);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 0;
            label6.Text = "Phụ tùng:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(997, 57);
            label9.Name = "label9";
            label9.Size = new Size(96, 28);
            label9.TabIndex = 0;
            label9.Text = "Số lượng:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(992, 14);
            label7.Name = "label7";
            label7.Size = new Size(101, 28);
            label7.TabIndex = 0;
            label7.Text = "Tiền công:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 14);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 0;
            label4.Text = "Nội dung:";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(915, 679);
            button4.Name = "button4";
            button4.Size = new Size(9, 8);
            button4.TabIndex = 15;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(711, 749);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 16;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // pscdtgrid
            // 
            pscdtgrid.AllowUserToAddRows = false;
            pscdtgrid.AllowUserToDeleteRows = false;
            pscdtgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pscdtgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pscdtgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pscdtgrid.Columns.AddRange(new DataGridViewColumn[] { NoiDung, MaVTPT, TenVTPT, SoLuong, DonGia, TienCong, ThanhTien });
            pscdtgrid.Location = new Point(12, 264);
            pscdtgrid.Name = "pscdtgrid";
            pscdtgrid.RowHeadersWidth = 51;
            pscdtgrid.RowTemplate.Height = 29;
            pscdtgrid.Size = new Size(1362, 408);
            pscdtgrid.TabIndex = 17;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            // 
            // MaVTPT
            // 
            MaVTPT.HeaderText = "Mã VTPT";
            MaVTPT.MinimumWidth = 6;
            MaVTPT.Name = "MaVTPT";
            // 
            // TenVTPT
            // 
            TenVTPT.HeaderText = "Tên VTPT";
            TenVTPT.MinimumWidth = 6;
            TenVTPT.Name = "TenVTPT";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // TienCong
            // 
            TienCong.HeaderText = "Tiền công";
            TienCong.MinimumWidth = 6;
            TienCong.Name = "TienCong";
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // ttttxtbox
            // 
            ttttxtbox.Anchor = AnchorStyles.Bottom;
            ttttxtbox.BackColor = Color.Gainsboro;
            ttttxtbox.Enabled = false;
            ttttxtbox.Location = new Point(592, 679);
            ttttxtbox.Name = "ttttxtbox";
            ttttxtbox.Size = new Size(397, 27);
            ttttxtbox.TabIndex = 6;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(432, 675);
            label11.Name = "label11";
            label11.Size = new Size(154, 28);
            label11.TabIndex = 5;
            label11.Text = "Tổng thành tiền:";
            // 
            // biensocbbox
            // 
            biensocbbox.Anchor = AnchorStyles.Top;
            biensocbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            biensocbbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            biensocbbox.BackColor = SystemColors.HighlightText;
            biensocbbox.FormattingEnabled = true;
            biensocbbox.Location = new Point(593, 69);
            biensocbbox.Name = "biensocbbox";
            biensocbbox.Size = new Size(223, 28);
            biensocbbox.TabIndex = 0;
            // 
            // PHIEUSUACHUA
            // 
            AcceptButton = lapphieubtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1386, 749);
            Controls.Add(biensocbbox);
            Controls.Add(ttttxtbox);
            Controls.Add(label11);
            Controls.Add(pscdtgrid);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(lapphieubtn);
            Controls.Add(thoatbtn);
            Controls.Add(panel1);
            Controls.Add(ngaynhapdtpicker);
            Controls.Add(mapsctxtbox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PHIEUSUACHUA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu sửa chữa";
            Load += PHIEUSUACHUA_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slnumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pscdtgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ngaynhapdtpicker;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button thoatbtn;
        private Button lapphieubtn;
        private Label label5;
        private TextBox mapsctxtbox;
        private Panel panel2;
        private ComboBox ndcbbox;
        private Label label6;
        private Label label4;
        private Button thembtn;
        private TextBox thanhtientxtbox;
        private TextBox dgtxtbox;
        private TextBox tctxtbox;
        private ComboBox ptcbbox;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label7;
        private Button button4;
        private Button button5;
        private DataGridView pscdtgrid;
        private Button button6;
        private TextBox ttttxtbox;
        private Label label11;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TienCong;
        private DataGridViewTextBoxColumn ThanhTien;
        private ComboBox biensocbbox;
        private NumericUpDown slnumeric;
        private TextBox tonkhotxtbox;
        private Label label12;
    }
}
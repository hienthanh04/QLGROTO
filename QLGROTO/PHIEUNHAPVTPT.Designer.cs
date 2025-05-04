namespace QLGROTO
{
    partial class PHIEUNHAPVTPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHIEUNHAPVTPT));
            panel1 = new Panel();
            label1 = new Label();
            ctnkgrid = new DataGridView();
            MaVTPT = new DataGridViewTextBoxColumn();
            TenVTPT = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            lpbtn = new Button();
            thoatbtn = new Button();
            label2 = new Label();
            mapntxtbox = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            xoabtn = new Button();
            tenvtcbbox = new ComboBox();
            slnum = new NumericUpDown();
            thembtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            dgtxtbox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ctnkgrid).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slnum).BeginInit();
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
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(606, 45);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP KHO VẬT TƯ PHỤ TÙNG";
            // 
            // ctnkgrid
            // 
            ctnkgrid.AllowUserToAddRows = false;
            ctnkgrid.AllowUserToDeleteRows = false;
            ctnkgrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ctnkgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ctnkgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ctnkgrid.Columns.AddRange(new DataGridViewColumn[] { MaVTPT, TenVTPT, SoLuong, GiaNhap });
            ctnkgrid.Location = new Point(14, 215);
            ctnkgrid.Name = "ctnkgrid";
            ctnkgrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ctnkgrid.RowHeadersWidth = 51;
            ctnkgrid.RowTemplate.Height = 29;
            ctnkgrid.ScrollBars = ScrollBars.Vertical;
            ctnkgrid.Size = new Size(1152, 378);
            ctnkgrid.TabIndex = 5;
            ctnkgrid.CellContentClick += ctnkgrid_CellContentClick;
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
            // lpbtn
            // 
            lpbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lpbtn.BackColor = Color.FromArgb(0, 192, 0);
            lpbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lpbtn.ForeColor = Color.White;
            lpbtn.Location = new Point(914, 599);
            lpbtn.Name = "lpbtn";
            lpbtn.Size = new Size(123, 45);
            lpbtn.TabIndex = 5;
            lpbtn.Text = "Lập phiếu";
            lpbtn.UseVisualStyleBackColor = false;
            lpbtn.Click += lpbtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(1043, 599);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 6;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += huybtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 76);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã phiếu nhập:";
            // 
            // mapntxtbox
            // 
            mapntxtbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            mapntxtbox.BackColor = Color.Gainsboro;
            mapntxtbox.Enabled = false;
            mapntxtbox.Location = new Point(326, 80);
            mapntxtbox.Name = "mapntxtbox";
            mapntxtbox.ReadOnly = true;
            mapntxtbox.Size = new Size(220, 27);
            mapntxtbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(593, 76);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 3;
            label3.Text = "Ngày nhập:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(711, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(xoabtn);
            panel2.Controls.Add(tenvtcbbox);
            panel2.Controls.Add(slnum);
            panel2.Controls.Add(thembtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dgtxtbox);
            panel2.Location = new Point(14, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(1152, 94);
            panel2.TabIndex = 6;
            // 
            // xoabtn
            // 
            xoabtn.Anchor = AnchorStyles.Top;
            xoabtn.Location = new Point(1043, 51);
            xoabtn.Name = "xoabtn";
            xoabtn.Size = new Size(94, 29);
            xoabtn.TabIndex = 4;
            xoabtn.Text = "Xóa";
            xoabtn.UseVisualStyleBackColor = true;
            xoabtn.Click += xoabtn_Click;
            // 
            // tenvtcbbox
            // 
            tenvtcbbox.Anchor = AnchorStyles.Top;
            tenvtcbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tenvtcbbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            tenvtcbbox.BackColor = SystemColors.HighlightText;
            tenvtcbbox.FormattingEnabled = true;
            tenvtcbbox.Location = new Point(174, 12);
            tenvtcbbox.Name = "tenvtcbbox";
            tenvtcbbox.Size = new Size(360, 28);
            tenvtcbbox.TabIndex = 0;
            // 
            // slnum
            // 
            slnum.Anchor = AnchorStyles.Top;
            slnum.BackColor = SystemColors.HighlightText;
            slnum.Location = new Point(847, 30);
            slnum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            slnum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            slnum.Name = "slnum";
            slnum.Size = new Size(150, 27);
            slnum.TabIndex = 2;
            slnum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // thembtn
            // 
            thembtn.Anchor = AnchorStyles.Top;
            thembtn.Location = new Point(1043, 13);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(94, 29);
            thembtn.TabIndex = 3;
            thembtn.Text = "Thêm";
            thembtn.UseVisualStyleBackColor = true;
            thembtn.Click += thembtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 44);
            label5.Name = "label5";
            label5.Size = new Size(158, 31);
            label5.TabIndex = 65;
            label5.Text = "Đơn giá nhập:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(730, 30);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 66;
            label4.Text = "Số lượng:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 13);
            label7.Name = "label7";
            label7.Size = new Size(111, 31);
            label7.TabIndex = 67;
            label7.Text = "Tên VTPT:";
            // 
            // dgtxtbox
            // 
            dgtxtbox.Anchor = AnchorStyles.Top;
            dgtxtbox.BackColor = SystemColors.HighlightText;
            dgtxtbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgtxtbox.Location = new Point(174, 46);
            dgtxtbox.Multiline = true;
            dgtxtbox.Name = "dgtxtbox";
            dgtxtbox.ScrollBars = ScrollBars.Horizontal;
            dgtxtbox.Size = new Size(360, 25);
            dgtxtbox.TabIndex = 1;
            dgtxtbox.TextChanged += dgtxtbox_TextChanged;
            // 
            // PHIEUNHAPVTPT
            // 
            AcceptButton = lpbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(1178, 656);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(mapntxtbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(thoatbtn);
            Controls.Add(lpbtn);
            Controls.Add(ctnkgrid);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PHIEUNHAPVTPT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập vật tư phụ tùng";
            Load += AccessoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ctnkgrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView ctnkgrid;
        private Button lpbtn;
        private Button thoatbtn;
        private Label label2;
        private TextBox mapntxtbox;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox dgtxtbox;
        private NumericUpDown slnum;
        private Button thembtn;
        private ComboBox tenvtcbbox;
        private DataGridViewTextBoxColumn MaVTPT;
        private DataGridViewTextBoxColumn TenVTPT;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private Button xoabtn;
    }
}
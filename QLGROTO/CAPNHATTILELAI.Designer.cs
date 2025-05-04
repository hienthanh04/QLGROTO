namespace QLGROTO
{
    partial class CAPNHATTILELAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAPNHATTILELAI));
            tilenumeric = new NumericUpDown();
            thoatbtn = new Button();
            capnhatbtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tilenumeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tilenumeric
            // 
            tilenumeric.BackColor = SystemColors.HighlightText;
            tilenumeric.DecimalPlaces = 2;
            tilenumeric.Location = new Point(244, 101);
            tilenumeric.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            tilenumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tilenumeric.Name = "tilenumeric";
            tilenumeric.Size = new Size(150, 27);
            tilenumeric.TabIndex = 0;
            tilenumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            thoatbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Location = new Point(488, 151);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(123, 45);
            thoatbtn.TabIndex = 2;
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
            capnhatbtn.Location = new Point(359, 151);
            capnhatbtn.Name = "capnhatbtn";
            capnhatbtn.Size = new Size(123, 45);
            capnhatbtn.TabIndex = 1;
            capnhatbtn.Text = "Cập nhật";
            capnhatbtn.UseVisualStyleBackColor = false;
            capnhatbtn.Click += capnhatbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 2;
            label1.Text = "TỈ LỆ LÃI";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 54);
            panel1.TabIndex = 3;
            // 
            // CAPNHATTILELAI
            // 
            AcceptButton = capnhatbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(623, 208);
            Controls.Add(panel1);
            Controls.Add(capnhatbtn);
            Controls.Add(thoatbtn);
            Controls.Add(tilenumeric);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CAPNHATTILELAI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Cập nhật tỉ lệ lãi";
            Load += CAPNHATTILELAI_Load;
            ((System.ComponentModel.ISupportInitialize)tilenumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown tilenumeric;
        private Button thoatbtn;
        private Button capnhatbtn;
        private Label label1;
        private Panel panel1;
    }
}
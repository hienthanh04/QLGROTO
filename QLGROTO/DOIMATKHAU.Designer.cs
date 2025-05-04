namespace QLGROTO
{
    partial class DOIMATKHAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DOIMATKHAU));
            panel2 = new Panel();
            doibtn = new Button();
            thoatbtn = new Button();
            nhaplaitxtbox = new TextBox();
            mkmtxtbox = new TextBox();
            mkctxtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(doibtn);
            panel2.Controls.Add(thoatbtn);
            panel2.Controls.Add(nhaplaitxtbox);
            panel2.Controls.Add(mkmtxtbox);
            panel2.Controls.Add(mkctxtbox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // doibtn
            // 
            doibtn.BackColor = Color.FromArgb(0, 192, 0);
            resources.ApplyResources(doibtn, "doibtn");
            doibtn.ForeColor = Color.White;
            doibtn.Name = "doibtn";
            doibtn.UseVisualStyleBackColor = false;
            doibtn.Click += chgbtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.BackColor = Color.FromArgb(192, 0, 0);
            resources.ApplyResources(thoatbtn, "thoatbtn");
            thoatbtn.ForeColor = Color.White;
            thoatbtn.Name = "thoatbtn";
            thoatbtn.UseVisualStyleBackColor = false;
            thoatbtn.Click += escbtn_Click;
            // 
            // nhaplaitxtbox
            // 
            nhaplaitxtbox.BackColor = SystemColors.HighlightText;
            resources.ApplyResources(nhaplaitxtbox, "nhaplaitxtbox");
            nhaplaitxtbox.Name = "nhaplaitxtbox";
            nhaplaitxtbox.UseSystemPasswordChar = true;
            // 
            // mkmtxtbox
            // 
            mkmtxtbox.BackColor = SystemColors.HighlightText;
            resources.ApplyResources(mkmtxtbox, "mkmtxtbox");
            mkmtxtbox.Name = "mkmtxtbox";
            mkmtxtbox.UseSystemPasswordChar = true;
            // 
            // mkctxtbox
            // 
            mkctxtbox.BackColor = SystemColors.HighlightText;
            resources.ApplyResources(mkctxtbox, "mkctxtbox");
            mkctxtbox.Name = "mkctxtbox";
            mkctxtbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.FlatStyle = FlatStyle.System;
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // DOIMATKHAU
            // 
            AcceptButton = doibtn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DOIMATKHAU";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox mkmtxtbox;
        private TextBox mkctxtbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nhaplaitxtbox;
        private Button doibtn;
        private Button thoatbtn;
    }
}
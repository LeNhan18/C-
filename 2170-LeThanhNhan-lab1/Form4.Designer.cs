namespace _2170_LeThanhNhan_lab1
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sinh Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm TB";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(158, 48);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(299, 20);
            this.txtMaSV.TabIndex = 4;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(158, 97);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(299, 20);
            this.txtTenSV.TabIndex = 5;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Quản Trị Kinh Doanh\t",
            "Ngôn Ngữ Anh"});
            this.cmbKhoa.Location = new System.Drawing.Point(158, 148);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(296, 21);
            this.cmbKhoa.TabIndex = 6;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(158, 200);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(291, 20);
            this.txtDiem.TabIndex = 7;
            // 
            // btn
            // 
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(149, 267);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn.Size = new System.Drawing.Size(130, 64);
            this.btn.TabIndex = 8;
            this.btn.Text = "Thêm";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(319, 267);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(130, 64);
            this.guna2CircleButton1.TabIndex = 9;
            this.guna2CircleButton1.Text = "Thóat";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 405);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtDiem;
        private Guna.UI2.WinForms.Guna2CircleButton btn;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}
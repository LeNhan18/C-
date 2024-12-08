namespace LAB3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtmsnv = new TextBox();
            txtName = new TextBox();
            txtLuong = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "MSNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 106);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "TÊN NV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 177);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "LƯƠNG";
            // 
            // txtmsnv
            // 
            txtmsnv.Location = new Point(112, 43);
            txtmsnv.Name = "txtmsnv";
            txtmsnv.Size = new Size(190, 23);
            txtmsnv.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 4;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(112, 174);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(190, 23);
            txtLuong.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(55, 221);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 6;
            button1.Text = "Đồng ý";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 221);
            button2.Name = "button2";
            button2.Size = new Size(83, 29);
            button2.TabIndex = 7;
            button2.Text = "Hủy Bỏ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 274);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLuong);
            Controls.Add(txtName);
            Controls.Add(txtmsnv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtmsnv;
        private TextBox txtName;
        private TextBox txtLuong;
        private Button button1;
        private Button button2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form2 : Form
    {
        public NhanVien nhanVien { get; set; }
        public Form2(NhanVien a = null)
        {
            InitializeComponent();

            // Hiển thị dữ liệu nếu chỉnh sửa
            if (a != null)
            {
                txtmsnv.Text = a.msnv;
                txtName.Text = a.hoten;
                txtLuong.Text = a.luong.ToString();
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmsnv.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo");
                return;
            }
            nhanVien = new NhanVien()
            {
                msnv = txtmsnv.Text,
                hoten = txtName.Text,
                luong = decimal.Parse(txtLuong.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


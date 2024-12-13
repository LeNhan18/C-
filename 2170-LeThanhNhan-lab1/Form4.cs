using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2170_LeThanhNhan_lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public delegate void addSinhVien(Student s);
        public addSinhVien OnAddStudent;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbKhoa.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtDiem.Text, out int diemTB) || diemTB < 0 || diemTB > 10)
                {
                    MessageBox.Show("Điểm trung bình phải là số từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Student newStudent = new Student(
                   txtMaSV.Text,
                   txtTenSV.Text,
                   cmbKhoa.SelectedItem.ToString(),
                   int.Parse(txtDiem.Text)
      );

                OnAddStudent?.Invoke(newStudent);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

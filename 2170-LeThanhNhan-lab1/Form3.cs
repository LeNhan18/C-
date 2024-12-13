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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form4 formAdd = new Form4();
            formAdd.OnAddStudent = new Form4.addSinhVien(AddSinhVien);

            formAdd.ShowDialog();

        }
        private void AddSinhVien(Student s)
        {
            dgv1.Rows.Add(dgv1.Rows.Count + 1, s.studentId, s.fullName, s.faculty, s.averageScore);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                if (row.Cells[2] != null && row.Cells[2].Value != null)
                {
                    string studentName = row.Cells[2].Value.ToString().ToLower();
                    if (studentName.Contains(keyword))
                    {

                        row.Cells[0].Style.BackColor = Color.Blue;
                        row.Cells[0].Style.ForeColor = Color.White;

                    }
                    else
                    {
                        row.Cells[0].Style.BackColor = dgv1.DefaultCellStyle.BackColor;
                        row.Cells[0].Style.ForeColor = dgv1.DefaultCellStyle.ForeColor;

                    }
                }
            }
        }
    }
}

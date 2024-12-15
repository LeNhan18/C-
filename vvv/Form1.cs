using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vvv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    // Nạp dữ liệu khi khởi chạy form
        }
        Model1 db = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<KHOA> listFalcultys = context.KHOAs.ToList(); //lấy các khoa
                List<STUDENT> listStudent = context.STUDENTs.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<KHOA> listFalcultys)
        {
            this.comboBox1.DataSource = listFalcultys;
            comboBox1.DisplayMember = "KHOANAME";  // Chỉ định cột hiển thị
            comboBox1.ValueMember = "KHOAID";
        }
        private void BindGrid(List<STUDENT> listStudent)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.STUDENTID;
                dataGridView1.Rows[index].Cells[1].Value = item.FULLNAME;
                dataGridView1.Rows[index].Cells[2].Value = item.KHOA.KHOANAME;
                dataGridView1.Rows[index].Cells[3].Value = item.AVERAGESCORE;
            }
        }
        private void LoadData()
        {
            try
            {
                Model1 context = new Model1();
                List<KHOA> listFalcultys = context.KHOAs.ToList(); //lấy các khoa
                List<STUDENT> listStudent = context.STUDENTs.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_ID.Text = selectedRow.Cells[0].Value.ToString();
                txt_FullName.Text = selectedRow.Cells[1].Value.ToString();
                comboBox1.Text = selectedRow.Cells[2].Value.ToString();
                txt_Diem.Text = selectedRow.Cells[3].Value.ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<STUDENT> studentList = db.STUDENTs.ToList();
                if (studentList.Any(s => s.STUDENTID == txt_ID.Text))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var newStudent = new STUDENT

                {
                    STUDENTID = txt_ID.Text,
                    FULLNAME = txt_FullName.Text,
                    KHOAID = int.Parse(comboBox1.SelectedValue.ToString()),
                    AVERAGESCORE = float.Parse(txt_Diem.Text),
                };

                db.STUDENTs.Add(newStudent);
                db.SaveChanges();

                BindGrid(db.STUDENTs.ToList());
                MessageBox.Show("Thêm sinh viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<STUDENT> students = db.STUDENTs.ToList();
                var student = students.FirstOrDefault(s => s.STUDENTID == txt_ID.Text);
                if (student != null)
                {
                    if (students.Any(s => s.STUDENTID == txt_ID.Text && s.STUDENTID != student.STUDENTID))
                    {
                        MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập một mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    student.FULLNAME = txt_FullName.Text;
                    student.KHOAID = int.Parse(comboBox1.SelectedValue.ToString());
                    student.AVERAGESCORE = double.Parse(txt_Diem.Text);
                    // Cập nhật sinh viên lưu vào CSDL
                    db.SaveChanges();
                    // Hiển thị lại danh sách sinh viên

                    BindGrid(db.STUDENTs.ToList());
                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 db = new Model1();
                List<STUDENT> studentList = db.STUDENTs.ToList();

                // Tìm kiếm sinh viên có tồn tại trong CSDL hay không
                var student = studentList.FirstOrDefault(s => s.STUDENTID == txt_ID.Text);

                if (student != null)
                {
                    // Xóa sinh viên khỏi CSDL
                    db.STUDENTs.Remove(student);
                    db.SaveChanges();

                    BindGrid(db.STUDENTs.ToList());

                    MessageBox.Show("Sinh viên đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

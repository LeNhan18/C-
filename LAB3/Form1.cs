using System.ComponentModel;

namespace LAB3
{
    public partial class Form1 : Form
    {

        private BindingList<NhanVien> list;
        public Form1()
        {
            InitializeComponent();
            list = new BindingList<NhanVien>();

            dgv1.DataSource = list;


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                list.Add(frm.nhanVien); // Thêm vào danh sách
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1.CurrentRow == null) return;

            // Lấy nhân viên được chọn
            NhanVien selectedEmployee = (NhanVien)dgv1.CurrentRow.DataBoundItem;

            // Mở Form chỉnh sửa
            Form2 frm2 = new Form2(selectedEmployee);
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật thông tin nhân viên
                selectedEmployee.msnv = frm2.nhanVien.msnv;
                selectedEmployee.hoten = frm2.nhanVien.hoten;
                selectedEmployee.luong = frm2.nhanVien.luong;

                dgv1.Refresh(); // Làm mới DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.CurrentRow == null) return;

            // Xóa nhân viên khỏi danh sách
            NhanVien selectedEmployee = (NhanVien)dgv1.CurrentRow.DataBoundItem;
            list.Remove(selectedEmployee);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát chương trình!","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}

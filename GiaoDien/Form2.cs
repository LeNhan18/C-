using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txt_l.Text) || string.IsNullOrEmpty(txt_f.Text) || string.IsNullOrEmpty(txt_p.Text)))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            { 
                DialogResult i = MessageBox.Show("Bạn có muốn thêm không", "tt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (i == DialogResult.Yes)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = txt_l.Text;
                    item.SubItems.Add(txt_f.Text);
                    item.SubItems.Add(txt_p.Text);
                    listView1.Items.Add(item);
                    txt_l.Clear();
                    txt_f.Clear();
                    txt_p.Clear();
                    txt_l.Focus();
                    MessageBox.Show("Thêm  Thành Công");
                }
           
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult i = MessageBox.Show("Bạn có muốn xóa không ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (i == DialogResult.OK)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    MessageBox.Show("Xóa Thành Công");
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát không", "dd", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Lấy dữ liệu từ các cột
                txt_l.Text = selectedItem.SubItems[0].Text;
                txt_f.Text = selectedItem.SubItems[1].Text;
                txt_p.Text = selectedItem.SubItems[2].Text;

                // Xóa mục đang chọn để cập nhật lại
                listView1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_l_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


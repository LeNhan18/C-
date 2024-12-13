using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2170_LeThanhNhan_lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadForm();
            loadSize();
            rtb1.Font = new Font("Tahoma", 14, FontStyle.Regular);
            cmb1.SelectedIndexChanged += new EventHandler(cmb1_Click);
            cmb2.SelectedIndexChanged += new EventHandler(cmb2_Click);
        }
        private void loadForm()
        {
            foreach (FontFamily f in new InstalledFontCollection().Families)
            {
                cmb1.Items.Add(f.Name);
            }
            cmb1.SelectedItem = "Tahoma";
        }
        private void loadSize()
        {
            int[] s = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cmb2.ComboBox.DataSource = s;
            cmb2.SelectedItem = 14;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            rtb1.Font = new Font("Tahona", 14, FontStyle.Regular);
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    rtb1.SaveFile(filePath);
                    MessageBox.Show("Văn bản đã được lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                rtb1.ForeColor = fontDialog.Color;
                rtb1.Font = fontDialog.Font;
            }
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtb1.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtb1.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Tệp tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tệp tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont != null)
            {
                FontStyle style = rtb1.SelectionFont.Style;
                if (rtb1.SelectionFont.Bold)
                {
                    style &= ~FontStyle.Bold;
                }
                else
                {

                    style |= FontStyle.Bold;
                }
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, style);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont != null)
            {
                FontStyle style = rtb1.SelectionFont.Style;
                if (rtb1.SelectionFont.Italic)
                {
                    style &= ~FontStyle.Italic;
                }
                else
                {

                    style |= FontStyle.Italic;
                }
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, style);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectionFont != null)
            {
                FontStyle style = rtb1.SelectionFont.Style;
                if (rtb1.SelectionFont.Underline)
                {
                    style &= ~FontStyle.Underline;
                }
                else
                {

                    style |= FontStyle.Underline;
                }
                rtb1.SelectionFont = new Font(rtb1.SelectionFont, style);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            rtb1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }
        private string filePath;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    rtb1.SaveFile(filePath);
                    MessageBox.Show("Văn bản đã được lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void cmb1_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (cmb1.SelectedItem != null)
            {
                string selectedFont = cmb1.SelectedItem.ToString();
                float currentSize = rtb1.Font.Size;
                rtb1.Font = new Font(selectedFont, currentSize);
                f.Font = rtb1.Font;
            }
        }

        private void cmb2_Click(object sender, EventArgs e)
        {
            if (cmb2.SelectedItem != null)
            {
                int selectedSize;
                if (int.TryParse(cmb2.SelectedItem.ToString(), out selectedSize))
                {
                    string currentFont = rtb1.Font.FontFamily.Name;
                    rtb1.Font = new Font(currentFont, selectedSize);
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

using DO_AN.table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class FormDanhSachThuVien : Form
    {
        public FormDanhSachThuVien()
        {
            InitializeComponent();
        }

        dbData data_sql = new dbData();

        bool data_click = true;
        bool them_click = false;
        bool sua_click = false;
        void setbutton(bool check)
        {
            textBoxIDBook.Enabled = check;
            textBoxNameSach.Enabled = check;
            textBoxNameTacGia.Enabled = check;
            comboBoxTheLoai.Enabled = check;
            textBoxNXB.Enabled = check;
            textBoxYearXB.Enabled = check;
            textBoxISBN.Enabled = check;
            comboBoxNgonNgu.Enabled = check;
            textBoxSLTrang.Enabled = check;
            textBoxGia.Enabled = check;
            textBoxMoTa.Enabled = check;
            textBoxViTri.Enabled = check;

            buttonLuu.Enabled = check;
            buttonHuy.Enabled = check;
            buttonXoa.Enabled = check;
            buttonSua.Enabled = !check;
            buttonThem.Enabled = !check;
        }
        void loadData()
        {
            var data = from u in data_sql.Book select u;

            dataGridView1.DataSource = data.ToList();
        }
        private void FormDanhSachThuVien_Load(object sender, EventArgs e)
        {

            loadData();
            setbutton(false);

            //=====================
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void selectdata_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_click == true)
            {
                int i = dataGridView1.CurrentRow.Index;
                textBoxIDBook.Text = dataGridView1.Rows[i].Cells["IDBook"].Value.ToString();
                textBoxNameSach.Text = dataGridView1.Rows[i].Cells["NameBook"].Value.ToString();
                textBoxNameTacGia.Text = dataGridView1.Rows[i].Cells["IDTacGia"].Value.ToString();
                comboBoxTheLoai.Text = dataGridView1.Rows[i].Cells["IDTheLoai"].Value.ToString();
                textBoxNXB.Text = dataGridView1.Rows[i].Cells["IDNhaXB"].Value.ToString();
                textBoxYearXB.Text = dataGridView1.Rows[i].Cells["NamXB"].Value.ToString();
                textBoxISBN.Text = dataGridView1.Rows[i].Cells["ISBN"].Value.ToString();
                comboBoxNgonNgu.Text = dataGridView1.Rows[i].Cells["NgonNgu"].Value.ToString();
                textBoxSLTrang.Text = dataGridView1.Rows[i].Cells["SoTrang"].Value.ToString();
                textBoxGia.Text = dataGridView1.Rows[i].Cells["Gia"].Value.ToString();
                textBoxMoTa.Text = dataGridView1.Rows[i].Cells["MoTa"].Value.ToString();
                textBoxViTri.Text = dataGridView1.Rows[i].Cells["IDKeSach"].Value.ToString();
            }
            else
            {
                return;
            }

        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            setbutton(true);
            //text
            textBoxIDBook.Text = "";
            textBoxNameSach.Text = "";
            textBoxNameTacGia.Text = "";
            comboBoxTheLoai.Text = "";
            textBoxNXB.Text = "";
            textBoxYearXB.Text = "";
            textBoxISBN.Text = "";
            comboBoxNgonNgu.Text = "";
            textBoxSLTrang.Text = "";
            textBoxGia.Text = "";
            textBoxMoTa.Text = "";
            textBoxViTri.Text = "";

            data_click = false;
            them_click = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

            if (them_click == true)
            {
                tblBook newbook = new tblBook
                {
                    IDBook = int.TryParse(textBoxIDBook.Text, out int id) ? id : 0,
                    NameBook = textBoxNameSach.Text.Trim(),
                    IDTacGia = int.TryParse(textBoxNameTacGia.Text, out int idtg) ? idtg : 0,
                    IDTheLoai = int.TryParse(comboBoxTheLoai.Text, out int idtl) ? idtl : 0,
                    IDNhaXB = int.TryParse(textBoxNXB.Text, out int idnxb) ? idnxb : 0,
                    NamXB = int.TryParse(textBoxYearXB.Text, out int nam) ? nam : DateTime.Now.Year,
                    ISBN = textBoxISBN.Text.Trim(),
                    NgonNgu = comboBoxNgonNgu.Text.Trim(),
                    SoTrang = int.TryParse(textBoxSLTrang.Text, out int pages) ? pages : 0,
                    Gia = decimal.TryParse(textBoxGia.Text, out decimal gia) ? gia : 0,
                    MoTa = textBoxMoTa.Text.Trim(),
                    IDKeSach = int.TryParse(textBoxViTri.Text, out int idks) ? idks : 0
                };
                data_sql.Book.Add(newbook);
                data_sql.SaveChanges();
                loadData();
            }
            if (sua_click == true)
            {
                int IDSach = int.Parse(textBoxIDBook.Text);
                var sua = data_sql.Book.SingleOrDefault(u => u.IDBook == IDSach);
                if (sua != null)
                {
                    sua.NameBook = textBoxNameSach.Text.Trim();
                    sua.IDTacGia = int.Parse(textBoxNameTacGia.Text.Trim());
                    sua.IDTheLoai = int.Parse(comboBoxTheLoai.Text.Trim());
                    sua.IDNhaXB = int.Parse(textBoxNXB.Text.Trim());
                    sua.NamXB = int.Parse(textBoxYearXB.Text.Trim());
                    sua.ISBN = textBoxISBN.Text.Trim();
                    sua.NgonNgu = comboBoxNgonNgu.Text.Trim();
                    sua.SoTrang = int.Parse(textBoxSLTrang.Text.Trim());
                    sua.Gia = decimal.Parse(textBoxGia.Text.Trim());
                    sua.MoTa = textBoxMoTa.Text.Trim();
                    sua.IDKeSach = int.Parse(textBoxViTri.Text.Trim());
                    data_sql.SaveChanges();

                    loadData();
                }

            }
            setbutton(false);

            them_click = false;
            sua_click = false;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            setbutton(false);
            //data
            data_click = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string NameSach = textBoxNameSach.Text;
            int IDSach = int.Parse(textBoxIDBook.Text);
            var xoa = data_sql.Book.SingleOrDefault(u => u.IDBook == IDSach);

            MessageBox.Show("Xác nhận xóa", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa != null)
            {
                data_sql.Book.Remove(xoa);
                data_sql.SaveChanges();
                loadData();

            }

            textBoxIDBook.Text = "";
            textBoxNameSach.Text = "";
            textBoxNameTacGia.Text = "";
            comboBoxTheLoai.Text = "";
            textBoxNXB.Text = "";
            textBoxYearXB.Text = "";
            textBoxISBN.Text = "";
            comboBoxNgonNgu.Text = "";
            textBoxSLTrang.Text = "";
            textBoxGia.Text = "";
            textBoxMoTa.Text = "";
            textBoxViTri.Text = "";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            setbutton(true);

            sua_click = true;
        }
    }
}

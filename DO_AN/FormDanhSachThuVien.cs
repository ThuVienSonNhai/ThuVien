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
        dbData sql = new dbData();

        bool data_click = true;
        bool them_click = false;
        bool sua_click = false;
        void loadData()
        {
            var data = from u in sql.Book select u;
            dataGridView1.DataSource = data.ToList();
        }
        private void FormDanhSachThuVien_Load(object sender, EventArgs e)
        {
            textBoxIDBook.Enabled = false;
            textBoxNameSach.Enabled = false;
            textBoxNameTacGia.Enabled = false;
            comboBoxTheLoai.Enabled = false;
            textBoxNXB.Enabled = false;
            textBoxYearXB.Enabled = false;
            textBoxISBN.Enabled = false;
            comboBoxNgonNgu.Enabled = false;
            textBoxSLTrang.Enabled = false;
            textBoxGia.Enabled = false;
            textBoxMoTa.Enabled = false;
            textBoxViTri.Enabled = false;
            buttonLuu.Enabled = false;
            buttonHuy.Enabled = false;
            buttonXoa.Enabled = false;

            loadData();
            //=====================
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void selectdata_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(data_click == true){
                int i = dataGridView1.CurrentRow.Index;
                textBoxIDBook.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBoxNameSach.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBoxNameTacGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                comboBoxTheLoai.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBoxNXB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBoxYearXB.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBoxISBN.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                comboBoxNgonNgu.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                textBoxSLTrang.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                textBoxGia.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                textBoxMoTa.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                textBoxViTri.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            }
            else
            {
                return;
            }

        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            textBoxNameSach.Enabled = true;
            textBoxNameTacGia.Enabled = true;
            comboBoxTheLoai.Enabled = true;
            textBoxNXB.Enabled = true;
            textBoxYearXB.Enabled = true;
            textBoxISBN.Enabled = true;
            comboBoxNgonNgu.Enabled = true;
            textBoxSLTrang.Enabled = true;
            textBoxGia.Enabled = true;
            textBoxMoTa.Enabled = true;
            textBoxViTri.Enabled = true;
            //button
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = true;
            buttonLuu.Enabled = true;
            //text
            textBoxIDBook.Text =         "";
            textBoxNameSach.Text =       "";
            textBoxNameTacGia.Text =     "";
            comboBoxTheLoai.Text =       "";
            textBoxNXB.Text =            "";
            textBoxYearXB.Text =         "";
            textBoxISBN.Text =           "";
            comboBoxNgonNgu.Text =       "";
            textBoxSLTrang.Text =        "";
            textBoxGia.Text =            "";
            textBoxMoTa.Text =           "";
            textBoxViTri.Text =          "";

            data_click = false;
            them_click = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            

            them_click = false;
            sua_click = false;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxIDBook.Enabled = false;
            textBoxNameSach.Enabled = false;
            textBoxNameTacGia.Enabled = false;
            comboBoxTheLoai.Enabled = false;
            textBoxNXB.Enabled = false;
            textBoxYearXB.Enabled = false;
            textBoxISBN.Enabled = false;
            comboBoxNgonNgu.Enabled = false;
            textBoxSLTrang.Enabled = false;
            textBoxGia.Enabled = false;
            textBoxMoTa.Enabled = false;
            textBoxViTri.Enabled = false;
            //button
            buttonSua.Enabled = true;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonLuu.Enabled = false;
            buttonHuy.Enabled = false;
            //data
            data_click = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string NameSach = textBoxNameSach.Text;
            int IDSach = int.Parse(textBoxIDBook.Text);
            MessageBox.Show("Xác nhận xóa", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            textBoxNameSach.Enabled = true;
            textBoxNameTacGia.Enabled = true;
            comboBoxTheLoai.Enabled = true;
            textBoxNXB.Enabled = true;
            textBoxYearXB.Enabled = true;
            textBoxISBN.Enabled = true;
            comboBoxNgonNgu.Enabled = true;
            textBoxSLTrang.Enabled = true;
            textBoxGia.Enabled = true;
            textBoxMoTa.Enabled = true;
            textBoxViTri.Enabled = true;
            //textbox
            buttonSua.Enabled = false;
            buttonXoa.Enabled = true;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = true;
            buttonLuu.Enabled = true;

            sua_click = true;
        }
    }
}

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
        SQL_CRUD sql = new SQL_CRUD();

        private void FormDanhSachThuVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.GetData("SELECT * FROM tblBook");
        }

        private void selectdata_cellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}

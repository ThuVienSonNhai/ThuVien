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
        }
    }
}

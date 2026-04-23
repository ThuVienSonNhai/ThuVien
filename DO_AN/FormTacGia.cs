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
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
        }

        SQL_CRUD sql = new SQL_CRUD();


        private void buttonThem_Click(object sender, EventArgs e)
        {
            //btn
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = true;
            buttonLuu.Enabled = true;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            //btn
            buttonSua.Enabled = false;
            buttonXoa.Enabled = true;
            buttonThem.Enabled = false;
            buttonHuy.Enabled = true;
            buttonLuu.Enabled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            //btn
            buttonSua.Enabled = true;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonLuu.Enabled = false;
            buttonHuy.Enabled = false;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            //btn
            buttonSua.Enabled = true;
            buttonXoa.Enabled = false;
            buttonThem.Enabled = true;
            buttonLuu.Enabled = false;
            buttonHuy.Enabled = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void FormTacGia_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.GetData("SELECT * FROM tblTacGia");
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}

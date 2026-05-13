using DO_AN.tblTable;
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
    public partial class FormTheLoai : Form
    {
        public FormTheLoai()
        {
            InitializeComponent();
        }

        sql_crud db = new sql_crud();

        bool data_click = true;
        bool them_click = false;
        bool sua_click = false;
        void setbutton(bool check)
        {
            textBoxIDTheloai.Enabled = false;
            textBoxTenTheloai.Enabled = check;
            textBoxMoTa.Enabled = check;

            buttonLuu.Enabled = check;
            buttonHuy.Enabled = check;
            buttonXoa.Enabled = check;
            buttonSua.Enabled = !check;
            buttonThem.Enabled = !check;
        }
        void loadData()
        {
            var data = from tl in db.TheLoai select tl;
            dataGridView1.DataSource = data.ToList();
        }
        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            loadData();
            setbutton(false);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            setbutton(true);
            textBoxIDTheloai.Text = "";
            textBoxTenTheloai.Text = "";
            textBoxMoTa.Text = "";

            data_click = false;
            them_click = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            setbutton(true);
            sua_click = true;
            data_click = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (them_click)
            {
                tblTheLoai newTL = new tblTheLoai
                {
                    NameTheLoai = textBoxTenTheloai.Text.Trim(),
                    MoTa = textBoxMoTa.Text.Trim()
                };
                db.TheLoai.Add(newTL);
                db.SaveChanges();
            }
            else if (sua_click)
            {
                int id = int.Parse(textBoxIDTheloai.Text);
                var sua = db.TheLoai.SingleOrDefault(tl => tl.IDTheLoai == id);
                if (sua != null)
                {
                    sua.NameTheLoai = textBoxTenTheloai.Text.Trim();
                    sua.MoTa = textBoxMoTa.Text.Trim();
                    db.SaveChanges();
                }
            }

            loadData();
            setbutton(false);
            them_click = false;
            sua_click = false;
            data_click = true;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            setbutton(false);
            data_click = true;
            them_click = false;
            sua_click = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxIDTheloai.Text);
            var xoa = db.TheLoai.SingleOrDefault(tl => tl.IDTheLoai == id);
            if (xoa != null)
            {
                db.TheLoai.Remove(xoa);
                db.SaveChanges();
                loadData();
                MessageBox.Show("xóa thành công!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_click)
            {
                int i = dataGridView1.CurrentRow.Index;
                textBoxIDTheloai.Text = dataGridView1.Rows[i].Cells["IDTheLoai"].Value.ToString();
                textBoxTenTheloai.Text = dataGridView1.Rows[i].Cells["NameTheLoai"].Value.ToString();
                textBoxMoTa.Text = dataGridView1.Rows[i].Cells["MoTa"].Value?.ToString();
            }
        }
    }
}

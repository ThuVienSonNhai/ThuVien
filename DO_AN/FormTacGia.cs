using DO_AN.DAO;
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

        sql_crud db = new sql_crud();


        bool data_click = true;
        bool them_click = false;
        bool sua_click = false;
        void setbutton(bool check)
        {
            textBoxMaTacGia.Enabled = check;
            textBoxTenTacGia.Enabled = check;
            textBoxNgaySinh.Enabled = check; 
            comboBoxQuocGia.Enabled = check;
            textBoxTieuSu.Enabled = check;

            textBoxNgayThem.Enabled = false;
            textBoxNgaySua.Enabled = false;

            buttonLuu.Enabled = check;
            buttonHuy.Enabled = check;
            buttonXoa.Enabled = check;
            buttonSua.Enabled = !check;
            buttonThem.Enabled = !check;
        }
        void loadData()
        {
            var data = from t in db.TacGia select t;
            dataGridView1.DataSource = data.ToList();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            setbutton(true);
            textBoxMaTacGia.Text = "";
          textBoxTenTacGia  .Text = "";
            textBoxNgaySinh.Text = "";
          comboBoxQuocGia   .Text = "";
          textBoxTieuSu     .Text = "";
            textBoxNgayThem.Text = "";
          textBoxNgaySua.Text = "";



            data_click = false;
            them_click = true;

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            setbutton(true);
            textBoxMaTacGia.Enabled = false; 
            sua_click = true;
            data_click = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (them_click)
            {
                tblTacGia tg = new tblTacGia
                {
                    IDTacGia = int.Parse(textBoxMaTacGia.Text.Trim()),
                    NameTacGia = textBoxTenTacGia.Text.Trim(),
                    NamSinh = DateTime.Parse(textBoxNgaySinh.Text.Trim()),
                    QuocGia = comboBoxQuocGia.Text.Trim(),
                    TieuSu = textBoxTieuSu.Text.Trim(),
                    NgayThem = DateTime.Now,
                    NgaySua = DateTime.Now
                };
                db.TacGia.Add(tg);
            }
            else if (sua_click)
            {
                int id = int.Parse(textBoxMaTacGia.Text);
                var sua = db.TacGia.SingleOrDefault(t => t.IDTacGia == id);
                if (sua != null)
                {
                    sua.NameTacGia = textBoxTenTacGia.Text.Trim();
                    sua.NamSinh = DateTime.Parse(textBoxNgaySinh.Text.Trim());
                    sua.QuocGia = comboBoxQuocGia.Text.Trim();
                    sua.TieuSu = textBoxTieuSu.Text.Trim();
                    sua.NgaySua = DateTime.Now; 
                }
            }

            db.SaveChanges();
            loadData();
            setbutton(false);
            them_click = false;
            sua_click = false;
            data_click = true;
            MessageBox.Show("Đã lưu dữ liệu thành công!");
        
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
            int id = int.Parse(textBoxMaTacGia.Text);
            var xoa = db.TacGia.SingleOrDefault(t => t.IDTacGia == id);
            if (xoa != null)
            {
                db.TacGia.Remove(xoa);
                db.SaveChanges();
                loadData();
                MessageBox.Show("Đã xóa!");
            }
        }

        private void FormTacGia_Load_1(object sender, EventArgs e)
        {
            loadData();
            setbutton(false);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_click)
            {
                int i = dataGridView1.CurrentRow.Index;
                textBoxMaTacGia .Text = dataGridView1.Rows[i].Cells["IDTacGia"].Value.ToString();
                textBoxTenTacGia.Text = dataGridView1.Rows[i].Cells["NameTacGia"].Value.ToString();
                textBoxNgaySinh .Text = dataGridView1.Rows[i].Cells["NamSinh"].Value.ToString();
                comboBoxQuocGia .Text = dataGridView1.Rows[i].Cells["QuocGia"].Value.ToString();
                textBoxTieuSu   .Text = dataGridView1.Rows[i].Cells["TieuSu"].Value.ToString();
                textBoxNgayThem .Text = dataGridView1.Rows[i].Cells["NgayThem"].Value.ToString();
                textBoxNgaySua  .Text = dataGridView1.Rows[i].Cells["NgaySua"].Value.ToString();
            }
        }
    }
}

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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        sql_crud data_sql = new sql_crud();

        bool data_click = true;
        bool them_click = false;
        bool sua_click = false;
        void setbutton(bool check)
        {
            textBoxIDKH.Enabled = false;

            textBoxTenKH.Enabled = check;
            textBoxGT.Enabled = check;
            textBoxNamSinh.Enabled = check;
            textBoxSDT.Enabled = check;
            textBoxEmail.Enabled = check;
            textBoxDiaChi.Enabled = check;
            textBoxNgayDK.Enabled = check;
            textBoxNgayHH.Enabled = check;

            buttonLuu.Enabled = check;
            buttonHuy.Enabled = check;
            buttonXoa.Enabled = check;
            buttonSua.Enabled = !check;
            buttonThem.Enabled = !check;
        }
        void loadData()
        {
            var data = from kh in data_sql.KhachHang select kh;
            dataGridView1.DataSource = data.ToList();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
            setbutton(false);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            setbutton(true);
            textBoxIDKH.Text = "";
            textBoxTenKH.Text = "";
            textBoxGT.Text = "";
            textBoxNamSinh.Text = "";
            textBoxSDT.Text = "";
            textBoxEmail.Text = "";
            textBoxDiaChi.Text = "";
            textBoxNgayDK.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxNgayHH.Text = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");

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
            bool gioiTinh = (textBoxGT.Text.ToLower() == "nam" || textBoxGT.Text == "1");
            if (them_click)
            {
                var kh = new tblKhachHang
                {
                    HoTen = textBoxTenKH.Text.Trim(),
                    GioiTinh = gioiTinh,
                    NgaySinh = DateTime.Parse(textBoxNamSinh.Text.Trim()),
                    SDT = textBoxSDT.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    DiaChi = textBoxDiaChi.Text.Trim(),
                    NgayDangKy = DateTime.Parse(textBoxNgayDK.Text.Trim()),
                    NgayHetHan = DateTime.Parse(textBoxNgayHH.Text.Trim())
                };
                data_sql.KhachHang.Add(kh);
            }
            else if (sua_click)
            {
                int id = int.Parse(textBoxIDKH.Text);
                var sua = data_sql.KhachHang.SingleOrDefault(k => k.IDKhachHang == id);
                if (sua != null)
                {
                    sua.HoTen = textBoxTenKH.Text.Trim();
                    sua.GioiTinh = gioiTinh;
                    sua.NgaySinh = DateTime.Parse(textBoxNamSinh.Text.Trim());
                    sua.SDT = textBoxSDT.Text.Trim();
                    sua.Email = textBoxEmail.Text.Trim();
                    sua.DiaChi = textBoxDiaChi.Text.Trim();
                    sua.NgayDangKy = DateTime.Parse(textBoxNgayDK.Text.Trim());
                    sua.NgayHetHan = DateTime.Parse(textBoxNgayHH.Text.Trim());
                }
            }

            data_sql.SaveChanges();
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
            int id = int.Parse(textBoxIDKH.Text);
            var xoa = data_sql.KhachHang.SingleOrDefault(k => k.IDKhachHang == id);
            if (xoa != null)
            {
                data_sql.KhachHang.Remove(xoa);
                data_sql.SaveChanges();
                loadData();
                MessageBox.Show("Xoa Thanh cong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_click)
            {
                int i = dataGridView1.CurrentRow.Index;
                textBoxIDKH.Text = dataGridView1.Rows[i].Cells["IDKhachHang"].Value.ToString();
                textBoxTenKH.Text = dataGridView1.Rows[i].Cells["HoTen"].Value.ToString();
                bool gt = (bool)dataGridView1.Rows[i].Cells["GioiTinh"].Value;
                textBoxGT.Text = gt ? "Nam" : "Nữ";
                textBoxNamSinh.Text = DateTime.Parse(dataGridView1.Rows[i].Cells["NgaySinh"].Value.ToString()).ToString("dd/MM/yyyy");
                textBoxSDT.Text = dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                textBoxEmail.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
                textBoxDiaChi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                textBoxNgayDK.Text = DateTime.Parse(dataGridView1.Rows[i].Cells["NgayDangKy"].Value.ToString()).ToString("dd/MM/yyyy");
                textBoxNgayHH.Text = DateTime.Parse(dataGridView1.Rows[i].Cells["NgayHetHan"].Value.ToString()).ToString("dd/MM/yyyy");
            }
        }
    }
}

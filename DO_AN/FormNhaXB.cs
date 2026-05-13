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
    public partial class FormNhaXB : Form
    {
        dbData db = new dbData();
        bool AddNew = false;

        public FormNhaXB()
        {
            InitializeComponent();
        }

        private void setControl(bool check)
        {
            txtIDNXB.Enabled = false;
            txtNameNXB.Enabled = check;
            txtSDT.Enabled = check;
            txtEmail.Enabled = check;
            txtDiaChi.Enabled = check;
            btnSave.Enabled = check;
            btnCancel.Enabled = check;
            btnAdd.Enabled = !check;
            btnEdit.Enabled = !check;
            btnDelete.Enabled = !check;
            dgvNhaXuatBans.Enabled = !check;
        }
        private void LoadGridData()
        {
            var data = from nxb in db.NhaXuatBan
                       select nxb;
            dgvNhaXuatBans.DataSource = data.ToList();
            setControl(false);
        }
        private void FormNhaXB_Load(object sender, EventArgs e)
        {
            dgvNhaXuatBans.AutoGenerateColumns = false;
            dgvNhaXuatBans.AllowUserToAddRows = false;
            LoadGridData();
        }

        private void dgvNhaXuatBans_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0) return;

            txtIDNXB.Text = dgvNhaXuatBans.Rows[i].Cells["IDNXB"].Value.ToString();
            txtNameNXB.Text = dgvNhaXuatBans.Rows[i].Cells["NameNXB"].Value.ToString();
            txtSDT.Text = dgvNhaXuatBans.Rows[i].Cells["SDT"].Value.ToString();
            txtEmail.Text = dgvNhaXuatBans.Rows[i].Cells["Email"].Value.ToString();
            txtDiaChi.Text = dgvNhaXuatBans.Rows[i].Cells["DiaChi"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNew = true;
            setControl(true);
            txtIDNXB.Clear();
            txtNameNXB.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtNameNXB.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNew = false;
            setControl(true);
            txtNameNXB.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameNXB.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhà xuất bản không được để trống!", "Thông báo");
                txtNameNXB.Focus();
                return;
            }

            if (AddNew)
            {
                tblNhaXuatBan newNXB = new tblNhaXuatBan
                {
                    NameNXB = txtNameNXB.Text.Trim(),
                    SDT = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };

                db.NhaXuatBan.Add(newNXB);
                db.SaveChanges();
                LoadGridData();
            }
            else
            {
                int id = int.Parse(txtIDNXB.Text);
                tblNhaXuatBan nxbUpdate = db.NhaXuatBan.SingleOrDefault(n => n.IDNXB == id);

                if (nxbUpdate != null)
                {
                    nxbUpdate.NameNXB = txtNameNXB.Text.Trim();
                    nxbUpdate.SDT = txtSDT.Text.Trim();
                    nxbUpdate.Email = txtEmail.Text.Trim();
                    nxbUpdate.DiaChi = txtDiaChi.Text.Trim();

                    db.SaveChanges();
                    LoadGridData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setControl(false);
            if (dgvNhaXuatBans.CurrentRow != null)
            {
                int rowIndex = dgvNhaXuatBans.CurrentRow.Index;
                int colIndex = dgvNhaXuatBans.CurrentCell.ColumnIndex;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(colIndex, rowIndex);
                dgvNhaXuatBans_CellEnter(dgvNhaXuatBans, args);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNhaXuatBans.CurrentRow == null) return;

            if (MessageBox.Show("Bạn muốn xóa nhà xuất bản này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                int id = (int)dgvNhaXuatBans.CurrentRow.Cells["IDNXB"].Value;
                var nxbDelete = db.NhaXuatBan.SingleOrDefault(n => n.IDNXB == id);

                if (nxbDelete != null)
                {
                    db.NhaXuatBan.Remove(nxbDelete);
                    db.SaveChanges();
                    LoadGridData();
                }
            }
        }
    }
}

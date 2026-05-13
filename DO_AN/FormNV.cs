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
    public partial class FormNV : Form
    {
        dbData db = new dbData();
        bool AddNew = false;

        public FormNV()
        {
            InitializeComponent();
        }

        private void setControl(bool check)
        {
            txtIDNhanvien.Enabled = false;
            txtFullName.Enabled = check;
            txtGender.Enabled = check;
            dtpBirthDate.Enabled = check;
            txtPhone.Enabled = check;
            txtEmail.Enabled = check;
            txtPosition.Enabled = check;
            dtpHireDate.Enabled = check;
            btnSave.Enabled = check;
            btnCancel.Enabled = check;
            btnAdd.Enabled = !check;
            btnEdit.Enabled = !check;
            btnDelete.Enabled = !check;
            dgvStaff.Enabled = !check;
        }

        private void LoadGridData()
        {
            var data = from s in db.NhanVien
                       select s;
            dgvStaff.DataSource = data.ToList();
            setControl(false);
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.AllowUserToAddRows = false;
            LoadGridData();
        }

        private void dgvStaff_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0) return;

            txtIDNhanvien.Text = dgvStaff.Rows[i].Cells["IDNhanvien"].Value.ToString();
            txtFullName.Text = dgvStaff.Rows[i].Cells["FullName"].Value.ToString();
            txtGender.Text = Convert.ToBoolean(dgvStaff.Rows[i].Cells["Gender"].Value) ? "Nam" : "Nữ";
            dtpBirthDate.Value = Convert.ToDateTime(dgvStaff.Rows[i].Cells["BirthDate"].Value);
            txtPhone.Text = dgvStaff.Rows[i].Cells["Phone"].Value.ToString();
            txtEmail.Text = dgvStaff.Rows[i].Cells["Email"].Value.ToString();
            txtPosition.Text = dgvStaff.Rows[i].Cells["Position"].Value.ToString();
            dtpHireDate.Value = Convert.ToDateTime(dgvStaff.Rows[i].Cells["HireDate"].Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNew = true;
            setControl(true);
            txtIDNhanvien.Clear();
            txtFullName.Clear();
            txtGender.Clear();
            dtpBirthDate.Value = DateTime.Now;
            txtPhone.Clear();
            txtEmail.Clear();
            txtPosition.Clear();
            dtpHireDate.Value = DateTime.Now;
            txtFullName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNew = false;
            setControl(true);
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                txtFullName.Focus();
                return;
            }

            string genderText = txtGender.Text.Trim().ToLower();
            if (genderText != "nam" && genderText != "nữ")
            {
                MessageBox.Show("Giới tính chỉ được nhập 'Nam' hoặc 'Nữ'!", "Thông báo");
                txtGender.Focus();
                return;
            }
            bool genderValue = genderText == "nam";

            if (AddNew)
            {
                tblNhanVien newStaff = new tblNhanVien
                {
                    FullName = txtFullName.Text.Trim(),
                    Gender = genderValue,
                    BirthDate = dtpBirthDate.Value,
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Position = txtPosition.Text.Trim(),
                    HireDate = dtpHireDate.Value
                };

                db.NhanVien.Add(newStaff);
                db.SaveChanges();
                LoadGridData();
            }
            else
            {
                int id = int.Parse(txtIDNhanvien.Text);
                tblNhanVien staffUpdate = db.NhanVien.SingleOrDefault(s => s.IDNhanvien == id);

                if (staffUpdate != null)
                {
                    staffUpdate.FullName = txtFullName.Text.Trim();
                    staffUpdate.Gender = genderValue;
                    staffUpdate.BirthDate = dtpBirthDate.Value;
                    staffUpdate.Phone = txtPhone.Text.Trim();
                    staffUpdate.Email = txtEmail.Text.Trim();
                    staffUpdate.Position = txtPosition.Text.Trim();
                    staffUpdate.HireDate = dtpHireDate.Value;

                    db.SaveChanges();
                    LoadGridData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setControl(false);
            if (dgvStaff.CurrentRow != null)
            {
                int rowIndex = dgvStaff.CurrentRow.Index;
                int colIndex = dgvStaff.CurrentCell.ColumnIndex;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(colIndex, rowIndex);
                dgvStaff_CellEnter(dgvStaff, args);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            if (MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                int id = (int)dgvStaff.CurrentRow.Cells["StaffID"].Value;
                var staffDelete = db.NhanVien.SingleOrDefault(s => s.IDNhanvien == id);

                if (staffDelete != null)
                {
                    db.NhanVien.Remove(staffDelete);
                    db.SaveChanges();
                    LoadGridData();
                }
            }
        }
    }
}


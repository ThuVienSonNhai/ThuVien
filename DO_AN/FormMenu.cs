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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            
        }

        private void quanlychothue_click(object sender, EventArgs e)
        {
            
        }

        private Form fnext = null;
        public void openForm(Form next)
        {
            if(fnext != null)
            {
                fnext.Close();
            }
            fnext = next;
            next.TopLevel = false;
            next.Dock = DockStyle.Fill;
            panelBody.Controls.Add(fnext);
            panelBody.Tag = next;
            next.BringToFront();
            next.Show();
        }
        private void danhsachthuvien_click(object sender, EventArgs e)
        {
            openForm( new FormDanhSachThuVien());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormKhachHang());
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormTacGia());
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormTheLoai());
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormDanhSachThuVien());
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

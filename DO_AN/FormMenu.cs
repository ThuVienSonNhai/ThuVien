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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if(panelHeThong1.Visible == false)
            {
                panelHeThong1.Visible = true;
                panelHeThong2.Visible = true;
                panelHeThong3.Visible = true;

            }
            else
            {
                panelHeThong1.Visible = false;
                panelHeThong2.Visible = false;
                panelHeThong3.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHeThong1.      Visible = false;
            panelHeThong2.      Visible = false;
            panelHeThong3.      Visible = false;
            panel10.            Visible = false;
            panel9.             Visible = false;
            panel8.             Visible = false;
            panel4.             Visible = false;
            panel6.             Visible = false;
            panel11.            Visible = false;
            panel12.            Visible = false;
            panel13.            Visible = false;
            panel15.            Visible = false;
            panel16.            Visible = false;
            panelHeThong1.BackColor = Color.LightGray;
            panelHeThong2.BackColor = Color.LightGray;
            panelHeThong3.BackColor = Color.LightGray;
            panel10.BackColor = Color.      LightGray;
            panel9.BackColor = Color.       LightGray;
            panel8.BackColor = Color.       LightGray;
            panel4.BackColor = Color.       LightGray;
            panel6.BackColor = Color.       LightGray;
            panel11.BackColor = Color.      LightGray;
            panel12.BackColor = Color.      LightGray;
            panel13.BackColor = Color.      LightGray;
            panel15.BackColor = Color.      LightGray;
            panel16.BackColor = Color.      LightGray;
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            if(panel10.Visible == false)
            {
                panel10.Visible = true;
                panel9.Visible = true;
                panel8.Visible = true;
                panel4.Visible = true;
            }
            else
            {
                panel10.Visible = false;
                panel9.Visible = false;
                panel8.Visible = false;
                panel4.Visible = false;
            }
        }

        private void quanlychothue_click(object sender, EventArgs e)
        {
            if (panel6.Visible == false)
            {
                panel6.Visible = true;
                panel11.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
            }
            else
            {
                panel6.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
            }
        }

        private void timkiem_click(object sender, EventArgs e)
        {
            if(panel16.Visible == false)
            {
                panel16.Visible = true;
                panel15.Visible = true;
            }
            else
            {
                panel15.Visible = false;
                panel16.Visible = false;
            }
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
    }
}

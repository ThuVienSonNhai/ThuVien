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
            if(paneldn.Visible == false)
            {
                paneldn.Visible = true;
                paneldx.Visible = true;
                panelmk.Visible = true;

            }
            else
            {
                paneldn.Visible = false;
                paneldx.Visible = false;
                panelmk.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paneldn.      Visible = false;
            paneldx.      Visible = false;
            panelmk.      Visible = false;
            panelthuvien.            Visible = false;
            paneltacgia.             Visible = false;
            paneltheloai.             Visible = false;
            panelnxb.             Visible = false;
            panelkhachhang.             Visible = false;
            panelbansao.            Visible = false;
            panelphieumuon.            Visible = false;
            panelctmuon.Visible = false;
            paneltksach.            Visible = false;
            panelkesach.Visible = false;
            panelnhanvien.Visible = false;
            paneltkdocgia.Visible = false;
            paneltkmuon.Visible = false;
            paneldn.BackColor = Color.LightGray;
            paneldx.BackColor = Color.LightGray;
            panelmk.BackColor = Color.LightGray;
            panelthuvien.BackColor = Color.      LightGray;
            paneltacgia.BackColor = Color.       LightGray;
            paneltheloai.BackColor = Color.       LightGray;
            panelnxb.BackColor = Color.       LightGray;
            panelkhachhang.BackColor = Color.       LightGray;
            panelbansao.BackColor = Color.      LightGray;
            panelchomuon.BackColor = Color.      LightGray;
            panelphieumuon.BackColor = Color.      LightGray;
            panelthongke.BackColor = Color.      LightGray;
            paneltksach.BackColor = Color.      LightGray;
            panelctmuon.BackColor = Color.LightGray;
            panelkesach.BackColor = Color.LightGray;
            panelnhanvien.BackColor = Color.LightGray;
            paneltkdocgia.BackColor = Color.LightGray;
            paneltkmuon.BackColor = Color.LightGray;
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            if(paneltacgia.Visible == false)
            {
                paneltacgia.Visible = true;
                paneltheloai.Visible = true;
                panelnxb.Visible = true;
                panelnhanvien.Visible = true;
                panelkesach.Visible = true;
                panelkhachhang.Visible = true;
            }
            else
            {
                paneltacgia.Visible = false;
                paneltheloai.Visible = false;
                panelnxb.Visible = false;
                panelnhanvien.Visible = false;
                panelkesach.Visible = false;
                panelkhachhang.Visible = false;
            }
        }

        private void quanlychothue_click(object sender, EventArgs e)
        {
            if (panelkhachhang.Visible == false)
            {
                panelkhachhang.Visible = true;
                panelbansao.Visible = true;
                panelchomuon.Visible = true;
                panelphieumuon.Visible = true;
            }
            else
            {
                panelkhachhang.Visible = false;
                panelbansao.Visible = false;
                panelchomuon.Visible = false;
                panelphieumuon.Visible = false;
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

        private void tacgia_click(object sender, EventArgs e)
        {
            openForm(new FormTacGia());
        }

        private void quanlysach_click(object sender, EventArgs e)
        {
            if(panelthuvien.Visible == false)
            {
                panelthuvien.Visible = true;
                panelbansao.Visible = true;
            }
            else
            {
                panelthuvien.Visible = false;
                panelbansao.Visible = false;
            }
        }

        private void quanlychomuon_click(object sender, EventArgs e)
        {
            if(panelphieumuon.Visible == false)
            {
                panelphieumuon.Visible = true;
                panelctmuon.Visible = true;
            }
            else
            {
                panelphieumuon.Visible = false;
                panelctmuon.Visible = false;
            }
        }

        private void thongke_click(object sender, EventArgs e)
        {
            if (paneltksach.Visible == false)
            {
                paneltksach.Visible = true;
                paneltkdocgia.Visible = true;
                paneltkmuon.Visible = true;
            }
            else
            {
                paneltksach.Visible = false;
                paneltkdocgia.Visible = false;
                paneltkmuon.Visible = false;
            }
        }
    }
}

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

        dbData db = new dbData();
        void loadData()
        {
            var data = from u in db.TacGia
                       select u;
            dataGridView1.DataSource = data.ToList();
        }
        private void FormTacGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

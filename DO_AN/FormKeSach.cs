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
    public partial class FormKeSach : Form
    {
        public FormKeSach()
        {
            InitializeComponent();
        }

        SQL_CRUD sql = new SQL_CRUD();
    }
}

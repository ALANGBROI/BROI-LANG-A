using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysv
{
    public partial class frmtacgia : Form
    {
        public frmtacgia()
        {
            InitializeComponent();
        }

        private void lblcopyright_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblqn_Click(object sender, EventArgs e)
        {

        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmquanlysv frm = new Frmquanlysv();
            frm.Show();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdoimatkhau frm = new frmdoimatkhau();
            frm.Show();

        }
    }
}

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
    public partial class Frmquanlysv : Form
    {
        
        public Frmquanlysv()
        {
            InitializeComponent();
        }

        private void khuC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void p11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmthongtinSV frm = new FrmthongtinSV();
            frm.Show();
        }

        private void Frmquanlysv_Load(object sender, EventArgs e)
        {

           
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmlogin frm = new Frmlogin();
            frm.Show();

        }

        private void khuNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmhopdongc1_1 Frm = new Frmhopdongc1_1();
            Frm.Show();
        }

        private void khuNhàC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  this.Hide();
           // Frmbangc1 Frm = new Frmbangc1();
           // Frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmtimkiem frm = new Frmtimkiem();
            frm.Show();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmthongtinSV frm = new FrmthongtinSV();
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmphong frm = new Frmphong();
            frm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtacgia frm = new frmtacgia();
            frm.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vềTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Thông tin cá nhân người viết phần mềm bao gồm việc đổi mật khẩu
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdoimatkhau fr = new frmdoimatkhau();
            fr.Show();
        }
    }
}

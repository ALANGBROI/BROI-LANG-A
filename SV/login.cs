using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Quanlysv
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data source= .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
            SqlDataAdapter da = new SqlDataAdapter("select count (*) From Login where USENAME = '" + txtname.Text + "'  and PASSWORD = '" + txtpassword.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Frmquanlysv frm = new Frmquanlysv();
                frm.Show();
            }
            else
            {
                MessageBox.Show(" Please check you use nam and password", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("You sure you want to exit", "Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

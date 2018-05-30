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
    public partial class Frmtimkiem : Form
    {

        public Frmtimkiem()
        {
            InitializeComponent();
        }

        private void Frmtimkiem_Load(object sender, EventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            //tạo chuỗi kết nối đến cơ sở dữ liệu 
            SqlConnection cn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
            if (txtnhapthongtin.Text == "")
            {
                txtnhapthongtin.Text = "Vui lòng nhập thông tin cần tìm?";
            }
            else if (chktheoten.Checked == true)
            {
                // thiết lập chuỗi truy cập dữ liệu với tên giống từ khóa nhập vào
                String sqlQry = "SELECT * FROM [dbo].[Sinhvien] where Sinhvien.HoTenSV like '%" + txtnhapthongtin.Text + "%'";
                SqlCommand cmd = new SqlCommand(sqlQry, cn);
                //SqlCommand cd =new SqlCommand ("select * from hopdong where HoTenSV like + N'" + txtnhapthongtin.Text + "'", cn);              
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //SqlDataAdapter dr = new SqlDataAdapter(cd);
                //tạo đối tượng ds chứa dữ liệu 
                DataSet ds = new DataSet();
                //DataSet d = new DataSet();
                //đưa tất cả dữ liệu bảng SV vào đối tượng ds
                da.Fill(ds, "Sinhvien");
                //dr.Fill(d, "hopdong");
                DataTable dt = new DataTable();
               // DataTable dl = new DataTable();
                
                dt = ds.Tables["Sinhvien"];
               // dl = d.Tables["hopdong"];
                dataGridView1.DataSource = dt;
              //  dataGridView2.DataSource = dl;
            }
            else if (chktheoma.Checked == true)
            {
                
                SqlCommand cmd = new SqlCommand("select * from Sinhvien where MaSV like '%" + txtnhapthongtin.Text + "%'", cn);
              //  SqlCommand cd = new SqlCommand("select *from hopdong where MaSV like + N'" + txtnhapthongtin.Text + "'", cn);                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               // SqlDataAdapter dr = new SqlDataAdapter(cd);
                //tạo đối tượng dữ liệu 
                DataSet ds = new DataSet();
               // DataSet d = new DataSet();
                da.Fill(ds, "Sinhvien");
              //  dr.Fill(ds, "hopdong");
                DataTable dt = new DataTable();
            //    DataTable dl = new DataTable();
                dt = ds.Tables["Sinhvien"];
            //    dl = d.Tables["hopdong"];
                dataGridView1.DataSource = dt;
             //   dataGridView2.DataSource = dl;


            }
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmquanlysv frm = new Frmquanlysv();
            frm.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes) 
            Application.Exit();
        }
    }
}


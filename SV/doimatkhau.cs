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
    public partial class frmdoimatkhau : Form
    {
       
        SqlConnection cn = new SqlConnection(@"Data source= .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        //SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        public frmdoimatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
            }
            else if (txtmatkhaumoi.Text == "")
            {

                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
            }
                else if(txtxacnhan.Text=="")
            {
                    MessageBox.Show("Bạn chưa xác nhận mật khẩu mới");
                }


            else
            {
                String passWord = txtmatkhaucu.Text;
                if (passWord != "")
                {
                    //SqlConnection cn = new SqlConnection(@"Data source= .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
                    SqlDataAdapter da = new SqlDataAdapter("select count (*) From Login where  PASSWORD = '" + passWord + "'", cn);
                    //  DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        // this.BindingContext[ds, "Login"].EndCurrentEdit();
                        //Kiểm tra mật khẩu mới có đúng không
                        if (txtmatkhaumoi.Text == txtxacnhan.Text && txtmatkhaumoi.Text != txtmatkhaucu.Text)
                        {
                            cn.Open();
                            cmd.Connection = cn;
                            cmd.CommandType = CommandType.Text;

                            String sqlUpdate = "UPDATE [dbo].[Login] SET [PASSWORD] = '" + txtmatkhaumoi.Text + "' WHERE [PASSWORD] = '" + txtmatkhaucu.Text + " ' ";
                            cmd.CommandText = sqlUpdate;

                            if (cmd.ExecuteNonQuery() == 1)
                                MessageBox.Show("Bạn đã đổi mật khẩu thành công");//
                            //Cái này thực chất là mình chưa biết cách gửi câu lệnh lệnh lên thôi.
                        }
                    }
                    else MessageBox.Show("Mật cũ khẩu ko đúng");
                    //MessageBox.Show(passWord);
                }
            }
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmquanlysv fr = new Frmquanlysv();
            fr.Show();
        }

        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


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
    public partial class Frmphong : Form
    {
        //tạo kết nối
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-D5NCM3E\SQLEXPRESS;Initial Catalog=Quanlysinhvien;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        //tạo đối tượng ds chứa dữ liệu 
        DataSet ds = new DataSet();
        SqlCommandBuilder cb;
        BindingSource bd = new BindingSource();
        DataTable dt = new DataTable();
        public Frmphong()
        {
            InitializeComponent();
        }

        private void Frmphong_Load(object sender, EventArgs e)
        {
            cbokhunha.Items.Add("C1");
            cbokhunha.Items.Add("C2");
            cbokhunha.Items.Add("C3");
            cbokhunha.Items.Add("C4");
            cbokhunha.Items.Add("C5");
            cn.Open();
            // câu truy vấn lấy tất cả dữ liệu trong bảng sv
            cmd = new SqlCommand("select * from Phong", cn);
            da = new SqlDataAdapter(cmd);
            //đưa tất cả dữ liệu vào bảng 
            da.Fill(ds, "Phong");
            dt = ds.Tables["Phong"];
            dataGridView1.DataSource = dt;

            //các bước điều khiển 
            BuocCacDieukhien();
            cb = new SqlCommandBuilder(da);
        }
        private void BuocCacDieukhien()
        {
          //  dataGridView1.DataSource = ds;
           // dataGridView1.DataMember = "Phong";
            txtphong.DataBindings.Add("Text", ds, "Phong.Phong");
            txtkhunha.DataBindings.Add("Text", ds, "Phong.Khunha");
            txtsoluong.DataBindings.Add("Text", ds, "Phong.Soluong");
            txttinhtrang.DataBindings.Add("Text", ds, "Phong.Tinhtrang");
            cbokhunha.DataBindings.Add("Text", ds, "Phong.Khunha");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds,"Phong"].AddNew();


        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds,"Phong"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    da.Update(ds,"Phong");
                    MessageBox.Show("Bạn đã lưu thành công");
                }
                catch (Exception ll)
                {
                    MessageBox.Show(ll.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {

                MessageBox.Show("Bạn chưa chọn thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    foreach (DataGridViewRow dgRow in dataGridView1.SelectedRows)
                        dataGridView1.Rows.Remove (dgRow);
                bd.EndEdit();
                da.Update(dt);
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
            DialogResult h = MessageBox.Show("Bạn chắc muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                Application.Exit();


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Phong set Khunha=@Khunha,Soluong = @Soluong, Trangthaiphong = @Trangthaiphong where Phong = @Phong";
                cmd.Parameters.Add("@Khunha", SqlDbType.NChar).Value = txtkhunha.Text;
                cmd.Parameters.Add("@Soluong", SqlDbType.NChar).Value = txtsoluong.Text;
                cmd.Parameters.Add("@Trangthaiphong", SqlDbType.NChar).Value = txttinhtrang.Text;
                cmd.Parameters.Add("@Phong", SqlDbType.NChar).Value = txtphong.Text;

            }
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Phong"].Position = 0;
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Phong"].Position--;
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Phong"].Position++;
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            int
                vitricuoi = this.BindingContext[ds, "Phong"].Count - 1;
            this.BindingContext[ds, "Phong"].Position = vitricuoi;

        }

        private void lblphong_Click(object sender, EventArgs e)
        {

        }
    }
}


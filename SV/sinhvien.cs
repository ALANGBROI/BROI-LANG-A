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
    public partial class FrmthongtinSV : Form
    {
        // tạo chuỗi kết nối đến cở sở dữ liệu 
        SqlConnection cn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
        SqlCommand cmd = new SqlCommand();
        //SqlCommand cmdgioitinh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
       // SqlDataAdapter dagioitinh = new SqlDataAdapter();
        // Tạo đối tượng ds chứa dữ liệu 
        DataSet ds = new DataSet();
       // DataSet dsgioitinh = new DataSet();
        SqlCommandBuilder cb;
        BindingSource bd = new BindingSource();
        DataTable dt = new DataTable();
       // DataTable dtgioitinh = new DataTable();
        public FrmthongtinSV()
        {
            InitializeComponent();
        }

        private void Frmphong1_Load(object sender, EventArgs e)
        {
            grpthongtinsinhvien.Visible = false;
            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");
            cn.Open();
            // câu truy vấn lấy tất cả dữ liệu của bảng sinh viên trong phong
            cmd = new SqlCommand("select * from Sinhvien", cn);
            // truy vấn tất cả dữ liệu trong bảng gioitinh
           // cmdgioitinh = new SqlCommand("select * from Gioitinh", cn);
            da = new SqlDataAdapter(cmd);
            //dagioitinh = new SqlDataAdapter(cmdgioitinh);
            // Đưa tất cả dữ liệu bảng học sinh vào đối tượng 
            da.Fill(ds, "Sinhvien");
           // dt = ds.Tables["Sinhvien"];
            //dagioitinh.Fill(dsgioitinh, "Gioitinh");
            //dagioitinh.Fill(dtgioitinh);
            dataGridView1.DataSource = dt;
            // cac buoc thuc hien 
            BuocCacDieuKhien();
            cb = new SqlCommandBuilder(da);
        }
        // ham thuc hien hien thi dữ liệu từ bảng hoc sinh 
        private void BuocCacDieuKhien()
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Sinhvien";
            txtmasv.DataBindings.Add("Text", ds, "Sinhvien.MaSV");
            txthoten.DataBindings.Add("Text", ds, "Sinhvien.HotenSV");
            txtngaysinh.DataBindings.Add("Text", ds, "Sinhvien.Ngaysinh");
            txtcmnd.DataBindings.Add("Text", ds, "Sinhvien.SoCM");
            txtgioitinh.DataBindings.Add("Text", ds, "Sinhvien.Gioitinh");
            txtlop.DataBindings.Add("Text", ds, "Sinhvien.Lop");
            txtkhoa.DataBindings.Add("Text", ds, "Sinhvien.Khoa");
            txtsodt.DataBindings.Add("Text", ds, "Sinhvien.SoĐT");
            txtdiachi.DataBindings.Add("Text", ds, "Sinhvien.Điachi");
           //txtkhunha_phong.DataBindings.Add("Text",ds,"Sinhvien.Khunha_Phong");
            // đưa tất cả dữ liệu gioitinh cobogioitinh
            //cbogioitinh.DataSource = dtgioitinh;
            cbogioitinh.DataBindings.Add("Text", ds, "Sinhvien.Gioitinh");



            




        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmquanlysv frm = new Frmquanlysv();
            frm.Show();
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Sinhvien"].Position = 0;
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Sinhvien"].Position--;
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Sinhvien"].Position++;
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            int Vitrimautincuoicung = this.BindingContext[ds, "Sinhvien"].Count - 1;
            this.BindingContext[ds, "Sinhvien"].Position = Vitrimautincuoicung;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grpthongtinsinhvien.Visible = true;
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Sinhvien set MaSV = @MaSV,HotenSV = @HotenSV,Ngaysinh = @Ngaysinh,SoCM = @SoCM,Gioitinh= @Gioitinh,Lop = @Lop,Khoa = @Khoa,SoĐT = @SoĐT,Điachi = @Điachi  where MaSV = MaSV";
                cmd.Parameters.Add("@MaSV", SqlDbType.NChar).Value = txtmasv.Text;
                cmd.Parameters.Add("@HotenSV", SqlDbType.NVarChar).Value = txthoten.Text;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.SmallDateTime).Value = txtngaysinh.Text;
                cmd.Parameters.Add("@SoCM", SqlDbType.NVarChar).Value = txtcmnd.Text;
                cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = txtgioitinh.Text;
                cmd.Parameters.Add("@Lop", SqlDbType.NChar).Value = txtlop.Text;
                cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = txtkhoa.Text;
                cmd.Parameters.Add("@SoĐT", SqlDbType.NChar).Value = txtsodt.Text;
                cmd.Parameters.Add("@Điachi", SqlDbType.NVarChar).Value = txtdiachi.Text;
               // cmd.Parameters.Add("@Khunha_Phong", SqlDbType.NChar).Value = txtkhunha_phong.Text;
                //cbogioitinh.DataSource = DataSet;
                
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            grpthongtinsinhvien.Visible = true;
            this.BindingContext[ds, "Sinh"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    da.Update(ds, "Sinhvien");
                    MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ll)
                {
                    MessageBox.Show(ll.Message);

                }

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Sinhvien"].AddNew();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn thông tin xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    foreach (DataGridViewRow dgRow in dataGridView1.SelectedRows)
                        dataGridView1.Rows.Remove(dgRow);
                bd.EndEdit();
                da.Update(dt);

            }
        }

        private void btnphuchoi_Click(object sender, EventArgs e)
        {
            grpthongtinsinhvien.Visible = true;
            this.BindingContext[ds, "Sinhvien"].AddNew();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
                this.Close();
        }

        private void cbogioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void lblmaSV_Click(object sender, EventArgs e)
        {

        }

        private void lblhotenSV_Click(object sender, EventArgs e)
        {

        }

        private void lblngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void lblCM_Click(object sender, EventArgs e)
        {

        }

        private void lblgioitinh_Click(object sender, EventArgs e)
        {

        }

        private void lblop_Click(object sender, EventArgs e)
        {

        }

        private void lblkhoa_Click(object sender, EventArgs e)
        {

        }

        private void lblsodt_Click(object sender, EventArgs e)
        {

        }

        private void lbldiachia_Click(object sender, EventArgs e)
        {

        }

        private void cbogioitinh_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

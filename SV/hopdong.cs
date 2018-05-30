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
    public partial class Frmhopdongc1_1 : Form
    {

        // tạo chuỗi kết nối đến cở sở dữ liệu 
        SqlConnection cn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Quanlysinhvien; Trusted_Connection = yes");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmdmasv = new SqlCommand();
        SqlCommand cmdphong = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter damasv = new SqlDataAdapter();
        SqlDataAdapter daphong = new SqlDataAdapter();
        //SqlDataAdapter damasv = new SqlDataAdapter();
        // Tạo đối tượng ds chứa dữ liệu 
        DataSet ds = new DataSet();
        DataSet dsmasv = new DataSet();
        DataSet dsphong = new DataSet();
        //DataSet dsmasv = new DataSet();
        SqlCommandBuilder cb;
        BindingSource bd = new BindingSource();
        DataTable dt = new DataTable();
        DataTable dtmasv = new DataTable();
        DataTable dtphong = new DataTable();
        //DataTable dsmasv = new DataTable();
        public Frmhopdongc1_1()
        {
            InitializeComponent();
        }

        private void Frmhopdongc1_1_Load(object sender, EventArgs e)
        {
            grpthongtin.Visible = false;
            cbokhunha.Items.Add("C1");
            cbokhunha.Items.Add("C2");
            cbokhunha.Items.Add("C3");
            cbokhunha.Items.Add("C4");
            cbokhunha.Items.Add("C5");

            cn.Open();
            // câu truy vấn lấy tất cả dữ liệu của bảng sinh viên trong phong
            cmd = new SqlCommand("select * from hopdong", cn);
            cmdmasv = new SqlCommand("select * from Sinhvien", cn);
            cmdphong = new SqlCommand("select * from Phong", cn);
            da = new SqlDataAdapter(cmd);
            damasv = new SqlDataAdapter(cmdmasv);
            daphong = new SqlDataAdapter(cmdphong);
            // Đưa tất cả dữ liệu bảng học sinh vào đối tượng 
            da.Fill(ds, "hopdong");
            damasv.Fill(dsmasv, "Sinhvien");
            dt = ds.Tables["hopdong"];
            dtmasv = dsmasv.Tables["Sinhvien"];
            daphong.Fill(dsphong, "Phong");
            dtphong = dsphong.Tables["Phong"];
            dataGridView1.DataSource = dt;
            
            
            // các bước điểu khiển
            BuocCacDieuKhien();
            cb = new SqlCommandBuilder(da);

        }
        //hàm thực hiện hiển thị dữ liệu 
        private void BuocCacDieuKhien()
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "hopdong";
            txt_masv.DataBindings.Add("Text", ds, "hopdong.MaSV");
            txt_khunha.DataBindings.Add("Text",ds,"hopdong.Khunha");
            txt_mahd.DataBindings.Add("Text", ds, "hopdong.MaHD");
            txt_phong.DataBindings.Add("Text", ds, "hopdong.Phong");
            txt_ngaybatdau.DataBindings.Add("Text", ds, "hopdong.Ngaybatdau");
            txt_ngayketthuc.DataBindings.Add("Text", ds, "hopdong.Ngayketthuc");
            cbokhunha.DataBindings.Add("Text", ds, "hopdong.Khunha");
            cbomasv.DataSource = dtmasv;
            cbomasv.ValueMember = "MaSV";
            cbophong.DataSource = dtphong;
            cbophong.ValueMember = "Phong";
            cbomasv.DataBindings.Add("Text", ds, "hopdong.MaSV");
            cbophong.DataBindings.Add("Text", ds, "hopdong.Phong");
            
        }




        private void grpthongtin_Enter(object sender, EventArgs e)
        {

        }

        private void btn_dau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "hopdong"].Position = 0;

        }

        private void btn_truoc_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "hopdong"].Position--;
        }

        private void btn_sau_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "hopdong"].Position++;
        }

        private void btn_cuoi_Click(object sender, EventArgs e)
        {
            int vitricuoi = this.BindingContext[ds, "hopdong"].Count - 1;
            this.BindingContext[ds, "hopdong"].Position = vitricuoi;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            grpthongtin.Visible = true;
            this.BindingContext[ds, "hopdong"].AddNew();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            grpthongtin.Visible = true;
            this.BindingContext[ds, "hopdong"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    da.Update(ds, "hopdong");
                    MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ll)
                {
                    MessageBox.Show(ll.Message);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn sửa chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grpthongtin.Visible = true;
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update hopdong set MaSV = @MaSV,Ngaybatdau = @Ngaybatdau,Ngayketthuc = @Ngayketthuc,Khunha = @Khunha,Phong= @Phong,MaHD=@MaHD where MaSV = MaSV";
                cmd.Parameters.Add("@MaSV", SqlDbType.NChar).Value = txt_masv.Text;
                cmd.Parameters.Add("@Ngaybatdau", SqlDbType.NVarChar).Value = txt_ngaybatdau.Text;
                cmd.Parameters.Add("@Ngayketthuc", SqlDbType.SmallDateTime).Value = txt_ngayketthuc.Text;
                //cmd.Parameters.Add("@Gioitinh", SqlDbType.NChar).Value = txt_gioitinh.Text;
               // cmd.Parameters.Add("@SoCM", SqlDbType.NVarChar).Value = txt_cmnd.Text;
               // cmd.Parameters.Add("@Lop", SqlDbType.NChar).Value = txt_lop.Text;
              //  cmd.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = txt_khoa.Text;
                //cmd.Parameters.Add("@SoĐT", SqlDbType.NChar).Value = txt_sodt.Text;
               // cmd.Parameters.Add("@Điachi", SqlDbType.NVarChar).Value = txt_diachi.Text;
                cmd.Parameters.Add("@Khunha", SqlDbType.NChar).Value = txt_khunha.Text;
                cmd.Parameters.Add("@Phong", SqlDbType.NChar).Value = txt_phong.Text;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = txt_mahd.Text;
                //cmd.CommandText = "update Sinhvien set MaSV = @MaSV,HotenSV = @HotenSV,Ngaysinh = @Ngaysinh,SoCM = @SoCM,Gioitinh= @Gioitinh,Lop = @Lop,Khoa = @Khoa,SoĐT = @SoĐT,Điachi = @Điachi  where MaSV = MaSV";
                

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
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

        private void btntrolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmquanlysv frm = new Frmquanlysv();
            frm.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc chắc muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)            
                this.Close();

        }
    }
}

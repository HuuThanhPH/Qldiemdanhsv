using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemDanhSinhVien
{
    public partial class ThongKe_TheoMaSV : Form
    {
        DBConnect db = new DBConnect();

        DataTable table = new DataTable();

        public void HienMaMH()
        {
            string chuoitv = "select * from MONHOC";
            DataTable dt = db.getDataTable(chuoitv);
            cboMaMonHoc.DataSource = dt;
            cboMaMonHoc.DisplayMember = "TenMH";
            cboMaMonHoc.ValueMember = "MAMH";
        }
        public void HienMaSV()
        {
            string chuoitv = "select * from SINHVIEN";
            DataTable dt = db.getDataTable(chuoitv);
            cboMaSinhVien.DataSource = dt;
            cboMaSinhVien.DisplayMember = "MaSV";
            cboMaSinhVien.ValueMember = "MaSV";
            
        }

        public ThongKe_TheoMaSV()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            txt_masv.Enabled = false;
            txt_hoten.Enabled = false;
            txt_ngaysinh.Enabled = false;
            txt_gioitinh.Enabled = false;
            txt_tenmonhoc.Enabled = false;
            txt_tengv.Enabled = false;
            txt_sobuoivang.Enabled = false;
            txt_comat.Enabled = false;

            HienMaMH();
            HienMaSV();
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            string chuoitv = "select MaSV, TenSV, NgaySinh, GioiTinh, TenMH, TenGV from SinhVien, MonHoc, GiangVien where MaSV = '" + cboMaSinhVien.SelectedValue + "' and MaMH = '" + cboMaMonHoc.SelectedValue + "' and MonHoc.MaGV = GiangVien.MaGV";
            DataTable dt = db.getDataTable(chuoitv);

            if (dt.Rows.Count > 0)
            {
                txt_masv.Text = dt.Rows[0]["MaSV"].ToString();
                txt_hoten.Text = dt.Rows[0]["TenSV"].ToString();
                txt_ngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                txt_gioitinh.Text = dt.Rows[0]["GioiTinh"].ToString();
                txt_tenmonhoc.Text = dt.Rows[0]["TenMH"].ToString();
                txt_tengv.Text = dt.Rows[0]["TenGV"].ToString();
            }

            string chuoitv1 = "SELECT COUNT(*) AS SoBuoiCoMat FROM DiemDanh WHERE MaSV = '" + cboMaSinhVien.SelectedValue + "' AND MaMH = '"+cboMaMonHoc.SelectedValue+"' AND TrangThai = N'Có mặt'";
            DataTable dt1 = db.getDataTable(chuoitv1);

            if (dt1.Rows.Count > 0)
            {
                txt_comat.Text = dt1.Rows[0]["SoBuoiCoMat"].ToString();
            }

            string chuoitv2 = "SELECT COUNT(*) AS SoBuoiVangMat FROM DiemDanh WHERE MaSV = '" + cboMaSinhVien.SelectedValue + "' AND MaMH = '" + cboMaMonHoc.SelectedValue + "' AND TrangThai = N'Vắng mặt'";
            DataTable dt2 = db.getDataTable(chuoitv2);

            if (dt2.Rows.Count > 0)
            {
                txt_sobuoivang.Text = dt2.Rows[0]["SoBuoiVangMat"].ToString();
            }
        }

        
    }
}

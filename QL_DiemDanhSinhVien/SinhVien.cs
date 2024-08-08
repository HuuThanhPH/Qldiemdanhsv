using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemDanhSinhVien
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        public void HienThiDSSV()
        {
            string chuoitruyvan = "select * from SinhVien";
            DataTable dt = db.getDataTable(chuoitruyvan);

            //Them khoa chinh
            DataColumn[] key = new DataColumn[1];
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;

            //liên kết gridview
            dgvSV.DataSource = dt;
        }

        public void HienThiMaLop()
        {
            string chuoitruyvan = "select * from Lop";
            DataTable dt = db.getDataTable(chuoitruyvan);

            cboMaLop.DataSource = dt;
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";
            
        }

        private bool kiemtratontai(string ma)
        {
            string chuoitruyvan = "select count(*) from SinhVien where MaSV = '" + txtMaSV.Text + "'";

            int kq = (int)db.getScalar(chuoitruyvan);
            if (kq == 0)
                return true;
            return false;

        }
        void LKDL(DataTable dt)
        {
            // Xóa bindings cũ
            txtMaSV.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            radNam.DataBindings.Clear();
            radNu.DataBindings.Clear();
            cboMaLop.DataBindings.Clear();

            // Bind dữ liệu
            txtMaSV.DataBindings.Add("Text", dt, "MaSV");
            txtHoTen.DataBindings.Add("Text", dt, "TenSV");
            dtpNgaySinh.DataBindings.Add("Text", dt, "NgaySinh");
            cboMaLop.DataBindings.Add("SelectedValue", dt, "MaLop");
        }
        private void SinhVien_Load(object sender, EventArgs e)
        {
           
            txtMaSV.Focus();
            HienThiDSSV();
            HienThiMaLop();
            DataTable dt = (DataTable)dgvSV.DataSource;
            LKDL(dt);
            dgvSV.ReadOnly = true;
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtratontai(txtMaSV.Text))
            {
                DataTable dt = (DataTable)dgvSV.DataSource;
                DataRow dr = dt.NewRow();

                dr["MaSV"] = txtMaSV.Text;
                dr["TenSV"] = txtHoTen.Text;
                dr["NgaySinh"] = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                if (radNam.Checked)
                {
                    dr["GioiTinh"] = radNam.Text;
                }
                else
                {
                    dr["GioiTinh"] = radNu.Text;
                }
                dr["MaLop"] = cboMaLop.SelectedValue;
                dt.Rows.Add(dr);

                string chuoitruyvan = "select * from SinhVien";
                int kq = db.updateDataTable(dt, chuoitruyvan);

                if (kq != 0)
                    MessageBox.Show("Thêm thành công !!!");
                else
                    MessageBox.Show("Thêm thất bại !!!");
            }
            else
                MessageBox.Show("Mã sinh viên đã tồn tại !!!");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvSV.DataSource;
            DataRow dr = dt.Rows.Find(txtMaSV.Text);
            //thực hiên xóa
            if (dr != null)
            {
                dr.Delete();

                string chuoitruyvan = "select * from SinhVien";
                int kq = db.updateDataTable(dt, chuoitruyvan);

                if (kq != 0)
                    MessageBox.Show("Xóa thành công !!!");
                else
                    MessageBox.Show("Xóa thất bại !!!");
            }
            else
                MessageBox.Show("Không tìm được sinh viên!!!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kiemtratontai(txtMaSV.Text))
            {
                DataTable dt = (DataTable)dgvSV.DataSource;
                DataRow dr = dt.Rows.Find(txtMaSV.Text);

                //thực hiện cập nhật
                if (dr != null)
                {
                    dr["TenSV"] = txtHoTen.Text;
                    dr["NgaySinh"] = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                    if (radNam.Checked)
                    {
                        dr["GioiTinh"] = radNam.Text;
                    }
                    else
                    {
                        dr["GioiTinh"] = radNu.Text;
                    }
                    dr["MaLop"] = cboMaLop.SelectedValue;
                    //cập nhật csdl
                    string chuoitruyvan = "select * from SinhVien";
                    int kq = db.updateDataTable(dt, chuoitruyvan);

                    if (kq != 0)
                    {
                        MessageBox.Show("Sửa thành công !!!");
                    }
                    else
                        MessageBox.Show("Sửa thất bại !!!");
                }
                else
                    MessageBox.Show("Không tìm được sinh viên !!!");
            }
            else
                MessageBox.Show("Mã sinh viên đã tồn tại !!!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string chuoitruyvan = "select * from SinhVien where MaSV = '"+txtMaSV.Text+"'";
            DataTable dt = db.getDataTable(chuoitruyvan);

            dgvSV.DataSource = dt;
        }





        
    }
}

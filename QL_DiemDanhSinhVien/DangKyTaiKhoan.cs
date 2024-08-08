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
    public partial class DangKyTaiKhoan : Form
    {
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string magv = txtmagiangvien.Text;
            string tentk = txt_tentaikhoan.Text;
            string matkhau = txt_matkhau.Text;
            string nhaplaimk = txt_nhaplaimatkhau.Text;
            if (kiemtraMaGV(txtmagiangvien.Text))
            {
                // Kiểm tra nhập đầy đủ thông tin
                if (string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(nhaplaimk))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ !!!");
                    return;
                }

                // Kiểm tra mật khẩu khớp
                if (matkhau != nhaplaimk)
                {
                    MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại !!!");
                    return;
                }

                // Thực hiện đăng ký tài khoản
                db.Open();
                string cautruyvan = "INSERT INTO TaiKhoan VALUES ('" + magv + "','" + tentk + "', '" + matkhau + "')";
                int kq = db.getNonQuery(cautruyvan);
                db.Close();

                // Xử lý kết quả
                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công !!!");
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại !!!");
                }
            }
            else
                MessageBox.Show("Giảng viên không tồn tại !!!");
            
        }

        private bool kiemtraMaGV(string ma)
        {
            string chuoitruyvan = "select count(*) from GiangVien where MaGV = '" + txtmagiangvien.Text + "'";

            int kq = (int)db.getScalar(chuoitruyvan);
            if (kq != 0)
                return true;
            return false;

        }
        private void chek_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if(chek_hienthimk.Checked)
            {
                txt_matkhau.PasswordChar = (char)0;
                txt_nhaplaimatkhau.PasswordChar = (char)0;
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
                txt_nhaplaimatkhau.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

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
    public partial class DangNhapTaiKhoan : Form
    {
        public DangNhapTaiKhoan()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        private void chek_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if(chek_hienthimk.Checked)
            {
                txt_MK.PasswordChar = (char)0;
            }
            else
            {
                txt_MK.PasswordChar = '*';
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void btn_DangNhap_Click(object sender, EventArgs e)
{
    string tentk = txt_tenTK.Text;
    string matkhau = txt_MK.Text;

    if(string.IsNullOrEmpty(tentk) || string.IsNullOrEmpty(matkhau))
    {
        MessageBox.Show("Vui lòng nhập đầy đủ !!!");
    }
    else
    {
        db.Open();
        string chuoitruyvan = "SELECT * FROM TaiKhoan Where TenTK = '"+tentk+"' and MatKhau = '"+matkhau+"'";
        object result = db.getScalar(chuoitruyvan);
        
        if(result != null)
        {
            MessageBox.Show("Đăng nhập thành công !!!");
            Menu f = new Menu();
            f.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!!");
        }
        db.Close();
    }
}

       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {
           DangKyTaiKhoan f = new DangKyTaiKhoan();
           f.ShowDialog();
       }

    }
}

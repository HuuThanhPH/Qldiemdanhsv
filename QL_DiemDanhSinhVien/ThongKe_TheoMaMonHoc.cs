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
    public partial class ThongKe_TheoMaMonHoc : Form
    {
        public ThongKe_TheoMaMonHoc()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        public void HienThiMaMonHoc()
        {
            string chuoitv = "select * from MonHoc";
            DataTable dt = db.getDataTable(chuoitv);

            cbo_MaMonHoc.DataSource = dt;
            cbo_MaMonHoc.DisplayMember = "TenMH";
            cbo_MaMonHoc.ValueMember = "MaMH";
        }
        private void ThongKe_TheoMaMonHoc_Load(object sender, EventArgs e)
        {
            HienThiMaMonHoc();
            dgvDiemDanh.ReadOnly = true;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            string chuoitv = "select * from DiemDanh where MaMH = '" + cbo_MaMonHoc.SelectedValue + "'";
            DataTable dt = db.getDataTable(chuoitv);

            dgvDiemDanh.DataSource = dt;
        }

       

        
    }
}

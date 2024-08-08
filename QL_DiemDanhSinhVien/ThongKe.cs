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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btn_Thongketheomasv_Click(object sender, EventArgs e)
        {
            ThongKe_TheoMaSV f = new ThongKe_TheoMaSV();
            f.Show();
        }

        private void btn_Thongketheomamonhoc_Click(object sender, EventArgs e)
        {
            ThongKe_TheoMaMonHoc f = new ThongKe_TheoMaMonHoc();
            f.Show();
        }

       
    }
}

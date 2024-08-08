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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.MdiParent = this;
            f.Show();
        }
        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiemDanh f = new DiemDanh();
            f.MdiParent = this;
            f.Show();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiangVien f = new GiangVien();
            f.MdiParent = this;
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.MdiParent = this;
            f.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.MdiParent = this;
            f.Show();
        }
    }
}

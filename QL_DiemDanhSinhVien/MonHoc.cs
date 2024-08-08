using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemDanhSinhVien
{
    public partial class MonHoc : Form
    {
        DBConnect db = new DBConnect(); 

        DataTable table = new DataTable();

        void Dulieu()
        {
            string query = "SELECT * FROM MonHoc";
            table = db.getDataTable(query);
            dgvTTSV.DataSource = table;
        }

        void HiemThiMaGV()
        {
            string chuoitruyvan = "SELECT * FROM GiangVien";
            DataTable dt = db.getDataTable(chuoitruyvan);

            cboMaGV.DataSource = dt;
            cboMaGV.DisplayMember = "TenGV";
            cboMaGV.ValueMember = "MaGV";
        }

        public MonHoc()
        {
            InitializeComponent();
        }

        private void monhoc_Load(object sender, EventArgs e)
        {
            db.Open();
            Dulieu();
            HiemThiMaGV();
            dgvTTSV.ReadOnly = true;
        }

        private void them_Click(object sender, EventArgs e)
        {
            string maMH = txt_mmonhoc.Text;
            string tenMH = txt_monhoc.Text;
            string maGV = cboMaGV.SelectedValue.ToString();

            string query = "INSERT INTO MonHoc VALUES(N'" + maMH + "', N'" + tenMH + "', N'" + maGV + "')";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Thêm Môn Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Thêm Môn Học Thất Bại !!!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maMH = txt_mmonhoc.Text;
            string query = "DELETE FROM MonHoc WHERE MaMH = '" + maMH + "'";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Xóa Môn Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Xóa Môn Học Thất Bại !!!");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string maMH = txt_mmonhoc.Text;
            string tenMH = txt_monhoc.Text;
            string maGV = cboMaGV.SelectedValue.ToString();

            string query = "UPDATE MonHoc SET TenMH = N'" + tenMH + "', MaGV = '" + maGV + "' WHERE MaMH = '" + maMH + "'";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Sửa Môn Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Sửa Môn Học Thất Bại !!!");
            }
        }
    }
}

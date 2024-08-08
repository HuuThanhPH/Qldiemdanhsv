using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemDanhSinhVien
{
    public partial class Lop : Form
    {
        DBConnect db = new DBConnect();

        DataTable table = new DataTable();

        void Dulieu()
        {
            string query = "SELECT * FROM Lop";
            table = db.getDataTable(query);
            dgvTTSV.DataSource = table;
        }

        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            db.Open();
            Dulieu();
            dgvTTSV.ReadOnly = true;
        }

        private void them_Click(object sender, EventArgs e)
        {
            string maLop = txt_malop.Text;
            string tenLop = txt_lop.Text;
            string query = "INSERT INTO LOP VALUES(N'" + maLop + "', N'" + tenLop + "')";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Thêm Lớp Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Thêm Lớp Học Thất Bại !!!");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maLop = txt_malop.Text;
            string query = "DELETE FROM LOP WHERE MaLop = '" + maLop + "'";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Xóa Lớp Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Xóa Lớp Học Thất Bại !!!");
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string maLop = txt_malop.Text;
            string tenLop = txt_lop.Text;
            string query = "UPDATE LOP SET TenLop = N'" + tenLop + "' WHERE MaLop = '" + maLop + "'";
            int kq = db.getNonQuery(query);

            if (kq != 0)
            {
                MessageBox.Show("Sửa Lớp Học Thành Công !!!");
                Dulieu();
            }
            else
            {
                MessageBox.Show("Sửa Lớp Học Thất Bại !!!");
            }
        }
    }
}

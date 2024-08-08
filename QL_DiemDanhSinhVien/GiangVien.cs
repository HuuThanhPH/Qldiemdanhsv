using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemDanhSinhVien
{
    public partial class GiangVien : Form
    {
        DBConnect db = new DBConnect();

        DataTable table = new DataTable();

        void loaddata()
        {
            string query = "SELECT * FROM GIANGVIEN";
            table = db.getDataTable(query);
            dgv.DataSource = table;
        }

        public GiangVien()
        {
            InitializeComponent();
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {
            db.Open();
            loaddata();
            dgv.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maGV = txtID.Text;
            string tenGV = txtTen.Text;
            string query = "INSERT INTO GIANGVIEN VALUES('" + maGV + "', N'" + tenGV + "')";
            db.getNonQuery(query);
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maGV = txtID.Text;
            string query = "DELETE FROM GIANGVIEN WHERE MaGV='" + maGV + "'";
            db.getNonQuery(query);
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgv.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGV = txtID.Text;
            string tenGV = txtTen.Text;
            string query = "UPDATE GIANGVIEN SET TenGV = N'" + tenGV + "' WHERE MaGV = '" + maGV + "'";
            db.getNonQuery(query);
            loaddata();
        }

      
    }
}

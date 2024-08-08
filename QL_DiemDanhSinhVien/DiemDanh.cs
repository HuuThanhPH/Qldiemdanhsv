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
    public partial class DiemDanh : Form
    {
        public DiemDanh()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == (char)8))
                e.Handled = true;
        }
        void HienthiDSDD()
        {
            string chuoitruyvan = "Select * from DiemDanh";
            DataTable dt = db.getDataTable(chuoitruyvan);

            //them khoa chinh\
            DataColumn[] key = new DataColumn[3];
            key[0] = dt.Columns[0];
            key[1] = dt.Columns[1];
            key[2] = dt.Columns[2];
            dt.PrimaryKey = key;

            //lien ket gridview
            dgvddsv.DataSource = dt;
        }

        void HienTHuMaSV()
        {
            string chuoitruyvan = "Select * from SinhVien";
            DataTable dt = db.getDataTable(chuoitruyvan);

            cboMaSV.DataSource = dt;
            cboMaSV.DisplayMember = "TenSV";
            cboMaSV.ValueMember = "MaSV";
        }
        void HienThiMaMH()
        {
            string chuoitruyvan = "Select * from MonHoc ";
            DataTable dt = db.getDataTable(chuoitruyvan);

            cboMaMH.DataSource = dt;
            cboMaMH.DisplayMember = "TenMH";
            cboMaMH.ValueMember = "MaMH";
        }

        void HienThiMaGV()
        {
            string chuoitruyvan = "Select * from GiangVien";
            DataTable dt = db.getDataTable(chuoitruyvan);

            cboMaGV.DataSource = dt;
            cboMaGV.DisplayMember = "TenGV";
            cboMaGV.ValueMember = "MaGV";
        }

        private void DiemDanh_Load(object sender, EventArgs e)
        {
            HienthiDSDD();
            HienTHuMaSV();
            HienThiMaMH();
            HienThiMaGV();
            dgvddsv.ReadOnly = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvddsv.DataSource;
            DataRow dr = dt.NewRow();

            dr["MaSV"] = cboMaSV.SelectedValue;
            dr["MaMH"] = cboMaMH.SelectedValue;
            dr["MaGV"] = cboMaGV.SelectedValue;
            dr["Ngay"] = dtpNgay.Value.ToString("dd/MM/yyyy");
            if(chekCoMat.Checked)
            {
                dr["TrangThai"] = chekCoMat.Text;
            }
            if (chekVangMat.Checked)
            {
                dr["TrangThai"] = chekVangMat.Text;
            }
            if (chekTre.Checked)
            {
                dr["TrangThai"] = chekTre.Text;
            }
            dt.Rows.Add(dr);

            string chuoitruyvan = "Select * from DiemDanh";
            int k = db.updateDataTable(dt, chuoitruyvan);

            if (k != 0)
                MessageBox.Show("Điểm Danh Thành Công !!!");
            else
                MessageBox.Show("Điểm Danh Thất Bại !!!");
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvddsv.DataSource;
            string[] keys = new string[] { cboMaSV.SelectedValue.ToString(), cboMaMH.SelectedValue.ToString(), dtpNgay.Value.ToString()};
            DataRow dr = dt.Rows.Find(keys);
            if (dr != null)
            {
                dr.Delete();
                string chuoitruyvan = "Select * from DiemDanh";
                int k = db.updateDataTable(dt, chuoitruyvan);

                if (k != 0)
                    MessageBox.Show("Xóa thành công !!!");
                else
                    MessageBox.Show("Xóa thất bại !!!");
            }
            else
                MessageBox.Show("Không tìm được sinh viên !!!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvddsv.DataSource;
            string[] keys = new string[] { cboMaSV.SelectedValue.ToString(), cboMaMH.SelectedValue.ToString(), dtpNgay.Value.ToString() };
            DataRow dr = dt.Rows.Find(keys);
            if (dr != null)
            {
                dr["MaSV"] = cboMaSV.SelectedValue;
                dr["MaMH"] = cboMaMH.SelectedValue;
                dr["MaGV"] = cboMaGV.SelectedValue;
                dr["Ngay"] = dtpNgay.Value.ToString("dd/MM/yyyy");
                if (chekCoMat.Checked)
                {
                    dr["TrangThai"] = chekCoMat.Text;
                }
                if (chekVangMat.Checked)
                {
                    dr["TrangThai"] = chekVangMat.Text;
                }
                if (chekTre.Checked)
                {
                    dr["TrangThai"] = chekTre.Text;
                }
                dt.Rows.Add(dr);

                string chuoitruyvan = "Select * from DiemDanh";
                int k = db.updateDataTable(dt, chuoitruyvan);

                if (k != 0)
                    MessageBox.Show("Sửa thành công !!!");
                else
                    MessageBox.Show("Sửa thất bại !!!");
            }
            else
                MessageBox.Show("Không tìm được sinh viên !!!");
        }

        

       
        
    }
}

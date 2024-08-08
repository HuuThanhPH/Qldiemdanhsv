using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_DiemDanhSinhVien
{
    class DBConnect
    {
        //thuoc tinh
        SqlConnection conn;
        //string chuoiketnoi = "Data Source=A207PC13;Initial Catalog=QLSINHVIEN;Integrated Security=True";
        string chuoiketnoi = "Data Source=MSI-GF63-THIN11\\SQLEXPRESS;Initial Catalog=QuanLyDiemDanhSV;Integrated Security=True";
        //phuong thuc khoi tao
        public DBConnect()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DBConnect(string chuoikn)
        {
            conn = new SqlConnection(chuoikn);
        }
        //phuong thuc xu ly
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public int getNonQuery(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, conn);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }
        public object getScalar(string chuoitruyvan)
        {
            Open();
            SqlCommand cmd = new SqlCommand(chuoitruyvan, conn);
            object kq = cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public DataTable getDataTable(string chuoitruyvan)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, conn);
            da.Fill(ds);

            return ds.Tables[0];
        }
        public int updateDataTable(DataTable dtnew, string chuoitruyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoitruyvan, conn);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            int kq = da.Update(dtnew);

            return kq;
        }
    }
}

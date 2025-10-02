using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class UtilDAL
    {
        private readonly string strConnect = @"Data Source=DESKTOP-0K8V9HG;Initial Catalog=QLThuVien;Integrated Security=True;TrustServerCertificate=True";
        public UtilDAL() { }

        public string CreateConnectionString(string username, string passwd)
        {
            return $"Server=DESKTOP-0K8V9HG;Database=QLThuVien;User Id={username};Password={passwd}";
        }
        // Lấy dữ liệu dạng DataTable (SELECT)
        public DataTable ExecuteQueryDataTable(string strSql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (DBHelper.strConnect == null) DBHelper.strConnect = strConnect;
                using (SqlConnection conn = new SqlConnection(DBHelper.strConnect))
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = ct;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    conn.Open();
                    adp.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                return null;
            }
        }


        // Thực thi Insert/Update/Delete
        public bool ExecuteNonQuery(string strSql, CommandType ct, ref string error, params SqlParameter[] parameters)
        {
            try
            {
                if (DBHelper.strConnect == null) DBHelper.strConnect = strConnect;
                using (SqlConnection conn = new SqlConnection(DBHelper.strConnect))
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = ct;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Thực thi câu lệnh trả về 1 giá trị duy nhất (COUNT, MAX, MIN, …)
        public object ExecuteScalar(string strSql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                if (DBHelper.strConnect == null) DBHelper.strConnect = strConnect;
                using (SqlConnection conn = new SqlConnection(DBHelper.strConnect))
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                {
                    cmd.CommandType = ct;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi ExecuteScalar: " + ex.Message);
                return null;
            }
        }

        // Trả về dữ liệu dạng XML
        public string ExecuteQueryXML(string strSql, CommandType ct, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.strConnect))
                using (SqlCommand cmd = new SqlCommand(strSql, conn))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = ct;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    DataSet ds = new DataSet();
                    conn.Open();
                    adp.Fill(ds);
                    return ds.GetXml();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy XML: " + ex.Message);
                return null;
            }
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAL
{
    public class DataBaseOpen
    {
        String Key = ConfigurationManager.ConnectionStrings["DataBaseKey"].ConnectionString;
        public int NoQuery(String sql, SqlParameter[] sp)
        {
            int i = 0;
            using (SqlConnection ct = new SqlConnection(Key))
            {
                ct.Open();
                using (SqlCommand cmd = new SqlCommand(sql, ct))
                {
                    if (sp != null)
                    {
                        cmd.Parameters.AddRange(sp);
                    }
                    i = cmd.ExecuteNonQuery();
                }
            }
            return i;
        }
        public DataTable Query(String sql, SqlParameter[] sp)
        {
            DataTable tb = new DataTable();
            using (SqlConnection ct = new SqlConnection(Key))
            {
                ct.Open();
                using (SqlCommand cmd = new SqlCommand(sql, ct))
                {
                    if (sp != null)
                    {
                        cmd.Parameters.AddRange(sp);
                    }
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(tb);
                    }
                }
            }
            return tb;
        }
    }
}









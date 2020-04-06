using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class RolesDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(RolesModle modle)
        {
            String sql = "INSERT INTO ROLES VALUES(@TITLE)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@TITLE",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Title
                }
            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE ROLES WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            }) ;
        }
        public int UpdateById(RolesModle modle)
        {
            String sql = "UPDATE ROLES SET TITLE=@TITLE WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
               new SqlParameter()
               {
                   ParameterName="@ID",
                   SqlDbType= SqlDbType.Int,
                   Value=modle.Id,
               },new SqlParameter()
               {
                   ParameterName="@TITLE",
                   SqlDbType= SqlDbType.Int,
                   Value=modle.Id,
               },
            }) ;
        }
        public DataTable SelectAll()
        {
            String sql = "SELECT * FROM ROLES";
            return dbo.Query(sql, null);
        }

    }
}






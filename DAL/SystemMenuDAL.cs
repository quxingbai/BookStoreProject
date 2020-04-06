using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Modle;

namespace DAL
{
    public class SystemMenuDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(SystemMenuModle modle)
        {
            String sql = "INSERT INTO SystemMenu VALUES(@Title,@Link,@ParentId)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@Title",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Title
                },
                new SqlParameter()
                {
                   ParameterName="@Link",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Link
                },
                new SqlParameter()
                {
                   ParameterName="@ParentId",
                    SqlDbType= SqlDbType.Int,
                    Value=modle.ParentId
                },
            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE SystemMenuL WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            });
        }
        public int UpdateById(SystemMenuModle modle)
        {
            String sql = "UPDATE SystemMenu SET TITLE=@TITLE WHERE(ID=@ID)";
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
            });
        }
        public DataTable SelectAll()
        {
            String sql = "SELECT * FROM SystemMenu";
            return dbo.Query(sql, null);
        }

    }
}

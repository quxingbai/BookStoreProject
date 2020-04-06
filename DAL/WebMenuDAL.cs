using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class WebMenuDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(WebMenuModle modle)
        {
            String sql = "INSERT INTO WebMenu VALUES(@Title,@Link,@ParentId)";
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
            String sql = "DELETE WebMenu WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            });
        }
        public int UpdateById(WebMenuModle modle)
        {
            String sql = "UPDATE WebMenu SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM WebMenu";
            return dbo.Query(sql, null);
        }

    }
}


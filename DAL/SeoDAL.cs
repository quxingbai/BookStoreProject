using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class SeoDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(SeoModle modle)
        {
            String sql = "INSERT INTO Seo VALUES(@Title,@Keyword,@Descriptions,@WebMenuId)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@Title",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Title
                },
                new SqlParameter()
                {
                   ParameterName="@Keyword",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Keyword
                },
                new SqlParameter()
                {
                   ParameterName="@Descriptions",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Descriptions
                },
                new SqlParameter()
                {
                   ParameterName="@WebMenuId",
                    SqlDbType= SqlDbType.Int,
                    Value=modle.WebMenuId
                },
            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE Seo WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            });
        }
        public int UpdateById(SeoModle modle)
        {
            String sql = "UPDATE Seo SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM Seo";
            return dbo.Query(sql, null);
        }

    }
}




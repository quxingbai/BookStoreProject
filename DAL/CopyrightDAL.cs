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
    public class CopyrightDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(CopyrightModle modle)
        {
            String sql = "INSERT INTO Copyright VALUES(@Title,@Content,@Address,@Tel1,@Tel2,@QQ1,@QQ2,@Wechat,@Email,@Logo,@Images)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@Title",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Title
                },
                new SqlParameter()
                {
                   ParameterName="@Content",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Content
                },
                new SqlParameter()
                {
                   ParameterName="@Address",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Address
                },
                new SqlParameter()
                {
                   ParameterName="@Tel1",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Tel1
                },
                new SqlParameter()
                {
                   ParameterName="@Tel2",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Tel2
                },
                new SqlParameter()
                {
                   ParameterName="@QQ1",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.QQ1
                },
                new SqlParameter()
                {
                   ParameterName="@QQ2",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.QQ2
                },
                new SqlParameter()
                {
                   ParameterName="@Wechat",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Wechat
                },
                new SqlParameter()
                {
                   ParameterName="@Email",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Email
                },
                new SqlParameter()
                {
                   ParameterName="@Images",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Images
                },

            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE Copyright WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            }) ;
        }
        public int UpdateById(CopyrightModle modle)
        {
            String sql = "UPDATE Copyright SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM Copyright";
            return dbo.Query(sql, null);
        }

    }
}

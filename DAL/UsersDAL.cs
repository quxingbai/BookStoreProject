using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class UsersDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(UsersModle modle)
        {
            String sql = "INSERT INTO Users VALUES(@EMAIL,@PASSWORD,@NICKNAME,@PHOTO,@CREATETIME)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@EMAIL",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Email
                }, new SqlParameter()
                {
                   ParameterName="@PASSWORD",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Password
                }, new SqlParameter()
                {
                   ParameterName="@NICKNAME",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.NickName
                }, new SqlParameter()
                {
                   ParameterName="@PHOTO",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.Photo
                }, new SqlParameter()
                {
                   ParameterName="@CREATETIME",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.CreateTime
                },
            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE Users WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            }) ;
        }
        public int UpdateById(UsersModle modle)
        {
            String sql = "UPDATE Users SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM Users";
            return dbo.Query(sql, null);
        }

    }
}


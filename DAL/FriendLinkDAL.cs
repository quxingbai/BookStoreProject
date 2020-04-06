using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class FriendLinkDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(FriendLinkModle modle)
        {
            String sql = "INSERT INTO FriendLink VALUES(@Title,@Link,@IsShow)";
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
                   ParameterName="@IsShow",
                    SqlDbType= SqlDbType.Bit,
                    Value=modle.IsShow
                },

            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE FriendLink WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            }) ;
        }
        public int UpdateById(FriendLinkModle modle)
        {
            String sql = "UPDATE FriendLink SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM FriendLink";
            return dbo.Query(sql, null);
        }

    }
}



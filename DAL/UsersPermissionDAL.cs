using System;
using System.Data.SqlClient;
using System.Data;
using Modle;

namespace DAL
{
    public class UsersPermissionDAL
    {
        DataBaseOpen dbo = new DataBaseOpen();
        public int Insert(UsersPermissionModle modle)
        {
            String sql = "INSERT INTO UsersPermission VALUES(@RolesId,@SystemMenuId)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@RolesId",
                    SqlDbType= SqlDbType.Int,
                    Value=modle.RolesId
                },
                new SqlParameter()
                {
                   ParameterName="@SystemMenuId",
                    SqlDbType= SqlDbType.Int,
                    Value=modle.SystemMenuId
                }
            });
        }
        public int DeleteById(int ID)
        {
            String sql = "DELETE UsersPermission WHERE(ID=@ID)";
            return dbo.NoQuery(sql, new SqlParameter[]{
                new SqlParameter()
                {
                   ParameterName="@ID",
                    SqlDbType= SqlDbType.Int,
                    Value=ID
                }
            }) ;
        }
        public int UpdateById(UsersPermissionModle modle)
        {
            String sql = "UPDATE UsersPermission SET TITLE=@TITLE WHERE(ID=@ID)";
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
            String sql = "SELECT * FROM UsersPermission";
            return dbo.Query(sql, null);
        }

    }
}



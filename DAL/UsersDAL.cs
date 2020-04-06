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
            String sql = "INSERT INTO Users VALUES(@EMAIL,@PASSWORD,@NICKNAME,@PHOTO,@CREATETIME,@RolesId)";
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
                },new SqlParameter()
                {
                   ParameterName="@RolesId",
                    SqlDbType= SqlDbType.NVarChar,
                    Value=modle.RolesId
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
        public DataTable SelectByName(String Name)
        {
            String sql = $"SELECT  * FROM USERS WHERE NAME LIKE '%{Name}%'";
            return dbo.Query(sql, null);
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="PassWordOLD">旧密码</param>
        /// <param name="NewPassWord">新密码</param>
        /// <returns>Boolean 是否修改成功</returns>
        public Boolean UpdatePassword(int ID, String PassWordOLD, String NewPassWord)
        {
            String sql = "UPDATE USERS SET PASSWORD = @NPW WHERE PASSWORD=@PWO AND ID = @ID";
            return dbo.NoQuery(sql, new SqlParameter[] {
                new SqlParameter()
                {
                    ParameterName="@NPW",
                    Value=NewPassWord,
                    SqlDbType= SqlDbType.VarChar,
                },new SqlParameter()
                {
                    ParameterName="@PWO",
                    Value=PassWordOLD,
                    SqlDbType= SqlDbType.VarChar,
                },new SqlParameter()
                {
                    ParameterName="@ID",
                    Value=ID,
                    SqlDbType= SqlDbType.Int,
                },
            }) > 0;
        }
        /// <summary>
        /// 修改邮箱
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="OE">旧邮箱</param>
        /// <param name="NE">新邮箱</param>
        /// <returns></returns>
        public Boolean UpdateEmail(int ID, String NE)
        {
            String sql = "UPDATE USERS SET EMAIL=@NE WHERE ID = @ID";
            return dbo.NoQuery(sql, new SqlParameter[] {
                new SqlParameter()
                {
                    ParameterName="@NE",
                    Value=NE,
                    SqlDbType= SqlDbType.VarChar,
                },new SqlParameter()
                {
                    ParameterName="@ID",
                    Value=ID,
                    SqlDbType= SqlDbType.Int,
                },
            }) > 0;
        }
        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="URL">新的图片地址</param>
        /// <returns></returns>
        public Boolean UpdatePhoto(int ID,String URL)
        {
            String sql = "UPDATE USERS SET PHOTO = @URL WHERE ID=@ID";
            return dbo.NoQuery(sql,new SqlParameter[]{
                new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName="@ID",
                    Value=ID
                },new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName="@URL",
                    Value=ID
                },
            })>0;
        }
        /// <summary>
        /// 修改名称
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="NName">新名字</param>
        /// <returns></returns>
        public Boolean UpdateNickName(int ID,String NNAME)
        {
            String sql = "UPDATE SET Nickname=@NNAME WHERE ID = @ID";
            return dbo.NoQuery(sql,new SqlParameter[]{
                new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName="@ID",
                    Value=ID
                },new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName="@NNAME",
                    Value=NNAME
                },
            }) > 0;
        }

    }
}


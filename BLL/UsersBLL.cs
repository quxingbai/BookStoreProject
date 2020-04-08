using System.Data;
using Modle;
using DAL;
using System;

namespace BLL
{
    public class UsersBLL
    {
        UsersDAL dal = new UsersDAL();
        public int Insert(UsersModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(UsersModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
        public DataTable SelectByName(String Name)
        {
            return dal.SelectByName(Name);
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
            return dal.UpdatePassword(ID, PassWordOLD, NewPassWord);
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
            return dal.UpdateEmail(ID, NE);
        }
        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="URL">新的图片地址</param>
        /// <returns></returns>
        public Boolean UpdatePhoto(int ID, String URL)
        {
            return dal.UpdatePhoto(ID, URL);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Email">邮箱</param>
        /// <param name="Password">密码</param>
        /// <returns></returns>
        public Boolean UserLoad(String Email, String Password)
        {
            return dal.UserLoad(Email, Password);
        }
    }
}

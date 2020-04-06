using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class UsersPermissionBLL
    {
        UsersPermissionDAL dal = new UsersPermissionDAL();
        public int Insert(UsersPermissionModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(UsersPermissionModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

using System.Data;
using Modle;
using DAL;

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
    }
}

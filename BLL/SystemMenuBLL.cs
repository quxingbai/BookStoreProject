using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class SystemMenuBLL
    {
        SystemMenuDAL dal = new SystemMenuDAL();
        public int Insert(SystemMenuModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(SystemMenuModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

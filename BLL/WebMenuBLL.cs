using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class WebMenuBLL
    {
        WebMenuDAL dal = new WebMenuDAL();
        public int Insert(WebMenuModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(WebMenuModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

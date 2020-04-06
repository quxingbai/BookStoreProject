using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class CopyrightBLL
    {
        CopyrightDAL dal = new CopyrightDAL();
        public int Insert(CopyrightModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(CopyrightModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

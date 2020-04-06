using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class SeoBLL
    {
        SeoDAL dal = new SeoDAL();
        public int Insert(SeoModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(SeoModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

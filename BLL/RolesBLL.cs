using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class RolesBLL
    {
        RolesDAL dal = new RolesDAL();
        public int Insert(RolesModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(RolesModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

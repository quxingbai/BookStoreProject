using System.Data;
using Modle;
using DAL;

namespace BLL
{
    public class FriendLinkBLL
    {
        FriendLinkDAL dal = new FriendLinkDAL();
        public int Insert(FriendLinkModle modle)
        {
            return dal.Insert(modle);
        }
        public int DeleteById(int ID)
        {
            return dal.DeleteById(ID);
        }
        public int UpdateById(FriendLinkModle modle)
        {
            return dal.UpdateById(modle);
        }
        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }
    }
}

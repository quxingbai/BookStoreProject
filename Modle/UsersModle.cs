using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modle
{
    public class UsersModle
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String NickName { get; set; }
        public String Photo { get; set; }
        public String CreateTime { get; set; }

        public int RolesId { get; set; }
    }
}

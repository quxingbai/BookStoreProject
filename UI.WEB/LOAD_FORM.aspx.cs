using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace UI.WEB
{
    public partial class LOAD_FORM : System.Web.UI.Page
    {
        UsersBLL ub = new UsersBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BT_LOAD_SUBMIT_Click(object sender, EventArgs e)
        {
            String Email = TEXT_LOAD_EMAIL.Text;
            String Password = TEXT_LOAD_PASSWORD.Text;
            Boolean load = ub.UserLoad(Email, Password);
            if (load)
            {
                Response.Write("<script>alert('登陆成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('登陆失败');</script>");
            }
        }
    }
}
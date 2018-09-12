using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_1.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string LoginId = WebConfigurationManager.AppSettings["AdminLoginId"];
            string Password = WebConfigurationManager.AppSettings["AdminPassword"];
            if (txtLoginId.Text == LoginId && txtPassword.Text == Password)
            {
                Session["ShoppingHeartAdmin"] = "ShoppingHeartAdmin";
                Response.Redirect("~/Admin/AddNewProducts.aspx");
            }
            else
            {
                 lblAlert.Text = "Incorrect LoginID/Password";

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessObject;
using System.Web.Services;

namespace CoffeeshopWebApp
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBL userbl = new UserBL();
            UserBO userbo = userbl.GetUserByUserPass(TextBox1.Text, TextBox2.Text);
            if (userbo == null)
            {
                Label1.Text = ("Incorrect username or password!");
                Label1.Visible =true;
            }
            else
            {
                Session["username"] = userbo.name;
                Session["password"] = userbo.password;
                Session["type"] = userbo.user_type;
                Response.Redirect("Coffee.aspx");

                Label1.Visible = false;
               
            }
        }


        [WebMethod]
        public static void SignOut()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}
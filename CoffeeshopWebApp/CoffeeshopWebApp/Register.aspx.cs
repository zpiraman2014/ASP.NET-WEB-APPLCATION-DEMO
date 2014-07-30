using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.Services;
using BusinessLogic;
using BusinessObject;

namespace CoffeeshopWebApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("SignIn.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string CheckUser(string user)
        {
            UserBL userbl = new UserBL();
            if (userbl.CheckUser(user))
            {
                return "Username already exist!";
            }

            return "Username available.";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserBL userbl = new UserBL();
            UserBO userbo = new UserBO(-1, txtUser.Text, txtPass.Text, txtEmail.Text, ddlUserType.SelectedValue);
            userbl.InsertNewUser(userbo);
           // Response.Write("<script>alert('New user added!');</script>");
            
        }

        protected void btnCheckAvailabiltiy_Click(object sender, EventArgs e)
        {

        }

        protected void btnCheckAvailabiltiy_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

    
    }
}
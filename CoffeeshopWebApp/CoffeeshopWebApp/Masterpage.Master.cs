using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeshopWebApp
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                if (Session["username"] != null)
                {


                    signin.Visible = false;
                    signout.Visible = true;
                    HyperLink1.Text = "Welcome " + Session["username"].ToString();

                }
                else
                {
                    signin.Visible = true;
                    signout.Visible = false;
                }
            }
        }
    }
}
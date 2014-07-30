using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using System.Web.Services;

namespace CoffeeshopWebApp
{
    public partial class Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] != null)
                {
                    FillGrid();
                }
                else
                {
                    Response.Redirect("SignIn.aspx");
                }
            }
        }

        private void FillGrid()
        {
            CoffeeBL coffeebl = new CoffeeBL();
            this.GridView1.DataSource = coffeebl.GetCoffeeList();
            this.GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
    
            CoffeeBL bl = new CoffeeBL();
            int id = (int)GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value;
            bl.DeleteCoffee(id);
            FillGrid();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
 

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

    }
}
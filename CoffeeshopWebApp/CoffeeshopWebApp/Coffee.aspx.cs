using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using System.Text;
using System.Collections;
using BusinessObject;

namespace CoffeeshopWebApp
{
    public partial class Coffee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CoffeeBL coffeebl = new CoffeeBL();
                this.DropDownList1.DataSource = coffeebl.GetCoffeeTypes();
                this.DropDownList1.DataBind();
                Label2.Text = Fill();

 
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = Fill();
        }

        public string Fill()
        {
            CoffeeBL coffeebl = new CoffeeBL();
            StringBuilder sb = new StringBuilder();
            ArrayList list = null;
            if (!IsPostBack)
            {
                list = coffeebl.GetCoffeeList();
            }
            else
            {
                if (DropDownList1.SelectedValue.Trim().ToUpper() != "ALL")
                {
                    list = coffeebl.GetCoffeeListByType(DropDownList1.SelectedValue);
                }
                else
                {
                    list = coffeebl.GetCoffeeList();
                }
            }

            foreach (var item in  list)
            {
                CoffeeBO coffee = item as CoffeeBO;
                sb.Append(string.Format(@"<table class='coffeeTable'>
                    <tr>
                        <th rowspan='6' width='150px'><img runat='server' src='{5}' ></th>
                        <th width='50px'>Name: </th>
                        <td>{0}</td>
                    </tr>
                    <tr>
                        <th>Type: </th>
                        <td>{1}</td>
                    </tr>
                     <tr>
                        <th>Price: </th>
                        <td>{2}</td>
                    </tr>
                      <tr>
                        <th>Roast: </th>
                        <td>{3}</td>
                    </tr>
                     <tr>
                        <th>Country: </th>
                        <td>{4}</td>
                    </tr>
                    <tr>
                        <th>Review: </th>
                        <td>{6}</td>
                    </tr>
                    </table>", coffee.name, coffee.type, coffee.price, coffee.roast, coffee.country, coffee.image, coffee.review));
            
            }

            return sb.ToString();
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
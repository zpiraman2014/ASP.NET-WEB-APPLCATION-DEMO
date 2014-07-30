using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using BusinessObject;
using BusinessLogic;

namespace CoffeeshopWebApp
{
    public partial class InsertUpdate : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlImages.DataSource = this.GetImageList();
                ddlImages.DataBind();
                Label1.Text = "<H1>Add new coffee</H1><hr></hr>";

                if (Request.QueryString["ID"] != null)
                {
                    Label1.Text = "<H1>Update coffee</H1><hr></hr>";
                    Button3.Text = "Update";
                    FillTextBox(Convert.ToInt32(Request.QueryString["ID"]));
                }
   

               
            }
 
        }

        private void FillTextBox(int id)
        {
            CoffeeBL bl = new CoffeeBL();
            CoffeeBO bo = bl.GetCoffeeById(id);
            this.txtCountry.Text = bo.country;
            this.txtName.Text = bo.name;
            this.txtPrice.Text = bo.price.ToString();
            this.txtReview.Text = bo.review;
            this.txtRoast.Text = bo.roast;
            this.txtType.Text = bo.type;
        }

        private ArrayList GetImageList()
        {
            ArrayList imgList = new ArrayList();
            string[] images = Directory.GetFiles(Server.MapPath("Images/Coffee"));

            foreach (var img in images)
            {
                imgList.Add(Path.GetFileName(img));
            }

            return imgList;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("Images/Coffee/") + filename);
                lblResult.Text = "Successfully uploaded!";
                Page_Load(sender, e);
            }
            catch (Exception)
            {
                lblResult.Text = "Upload failed!";
            }
        

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (Request.QueryString["ID"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["ID"]);
            }

            CoffeeBO coffeebo = new CoffeeBO(id,
                this.txtName.Text, this.txtType.Text, Convert.ToDouble(this.txtPrice.Text)
                , this.txtRoast.Text, this.txtCountry.Text, @"../images/coffee/" + this.ddlImages.SelectedValue, this.txtReview.Text
         
                );
            CoffeeBL bl = new CoffeeBL();

            if (Request.QueryString["ID"] != null)
            {
                bl.UpdateCoffee(coffeebo);
                lblResult.Text = "<script>alert('Successfully updated!');window.close();</script>";
            }
            else
            {
                bl.InsertCoffee(coffeebo);
                lblResult.Text = "<script>alert('Successfully added!');</script>";
   
            }

           
        }

        protected void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if (Label1.Text.Contains("Update coffee"))
            {
                Response.Write("<script>window.close();</script>");
            }
            else
            {
                Response.Redirect("Management.aspx");

            }
           
        }
    }
}
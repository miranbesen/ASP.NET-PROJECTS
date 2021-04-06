using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_Alistirma2
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        string id;   
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Id"];

            if(id=="1")
            {
                string key = "Telefon1";

                // Retrieve the Furniture object from session state.
                Product tel1 = (Product)Session[key];

                // Display the information for this object.
                Label1.Text =tel1.Vendor + " "+tel1.Model;
                Label2.Text = tel1.Type;
                Label3.Text = tel1.Vendor;
                Image1.ImageUrl = tel1.ImageUrl;
            }

            

            if (id == "2")
            {
                string key = "Telefon2";

                // Retrieve the Furniture object from session state.
                Product tel2 = (Product)Session[key];

                // Display the information for this object.
                Label1.Text = tel2.Vendor + " " + tel2.Model;
                Label2.Text = tel2.Type;
                Label3.Text = tel2.Vendor;
                Image1.ImageUrl = tel2.ImageUrl;
            }
           

            if (id == "3")
            {
                string key = "Telefon3";

                // Retrieve the Furniture object from session state.
                Product tel3 = (Product)Session[key];

                // Display the information for this object.
                Label1.Text = tel3.Vendor + " " + tel3.Model;
                Label2.Text = tel3.Type;
                Label3.Text = tel3.Vendor;
                Image1.ImageUrl = tel3.ImageUrl;
            }
          

            if (id == "4")
            {
                string key = "Telefon4";

                // Retrieve the Furniture object from session state.
                Product tel4 = (Product)Session[key];

                // Display the information for this object.
                Label1.Text = tel4.Vendor + " " + tel4.Model;
                Label2.Text = tel4.Type;
                Label3.Text = tel4.Vendor;
                Image1.ImageUrl = tel4.ImageUrl;
            }

            

            if (id == "5")
            {
                string key = "Telefon5";

                // Retrieve the Furniture object from session state.
                Product tel5 = (Product)Session[key];

                // Display the information for this object.
                Label1.Text = tel5.Vendor + " " + tel5.Model;
                Label2.Text = tel5.Type;
                Label3.Text = tel5.Vendor;
                Image1.ImageUrl = tel5.ImageUrl;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList idList = (ArrayList)Session["idList"];
            

            if (idList == null)
            {
                idList = new ArrayList();
            }

            if (idList.Contains(id))
            {
                Label4.Text = "Product is already in the list";
                Label4.Visible = true;
            }
            else
            {
                idList.Add(id);
                Label4.Text = "Product is added to the cart";
                Label4.Visible = true;
                Session["idList"] = idList;
            }

        }
    }
}
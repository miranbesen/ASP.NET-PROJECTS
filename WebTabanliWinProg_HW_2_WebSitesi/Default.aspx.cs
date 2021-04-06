using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_Alistirma2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                // Create Furniture objects.
                Product tel1 = new Product(1,"Telefon","Samsung","A20", "resimler/samsunga20.jfif");
                Product tel2 = new Product(2, "Telefon", "Iphone", "X", "resimler/iphonex.jfif");
                Product tel3 = new Product(3, "Telefon", "Xiaomi", "Mi8", "resimler/xiaomimi8.jfif");
                Product tel4 = new Product(4, "Telefon", "Huawei", "Y6", "resimler/huaweiy6.jfif");
                Product tel5 = new Product(5, "Telefon", "Sony", "Xperia", "resimler/sonyxperia.jfif");

                // Add objects to session state.
                Session["Telefon1"] = tel1;
                Session["Telefon2"] = tel2;
                Session["Telefon3"] = tel3;
                Session["Telefon4"] = tel4;
                Session["Telefon5"] = tel5;

            }

            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie == null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;

                Label1.Text = cookie["FirstName"] +" "+ cookie["LastName"];
            }
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie.Expires = DateTime.Now.AddDays(-7);

            Response.Cookies.Add(cookie);

            Response.Redirect("Default.aspx");
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_Alistirma2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            // Create the cookie object
            HttpCookie cookie = new HttpCookie("UserInfo");


            // Set a values in it
            cookie["FirstName"] = TextBox1.Text;
            cookie["LastName"] = TextBox2.Text;


            // Set an expiration date
            cookie.Expires = DateTime.Now.AddMonths(1);
            // Add it to the current web response
            Response.Cookies.Add(cookie);


            Response.Redirect("Default.aspx");

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}
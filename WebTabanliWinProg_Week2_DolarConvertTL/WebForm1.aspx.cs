using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_Week2_DolarConvertTL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Server.MapPath("Default.aspx");

            Label2.BorderStyle = BorderStyle.Outset;
            if(IsPostBack)
            {
                Label2.Text = "The page has been requested after a post back.";
            }
            else
            {
                TextBox1.Text = "0,00";
                Label2.Text="The page has been requested by the GET method";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dollars = double.Parse(TextBox1.Text);
                double tl = dollars * 7.40;

                Label3.Text = dollars.ToString() + "US dollars equal to" + tl.ToString("F2") + "TL";
            }
            catch(Exception ex)
            {
                Label3.Text = "the following error has occured:<br /> <br />" + ex.Message;

            }
        }
    }
}
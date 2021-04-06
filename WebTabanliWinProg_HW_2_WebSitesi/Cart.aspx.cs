using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_Alistirma2
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id="0",id2="0",id3="0",id4="0",id5="0";
            ArrayList idList = (ArrayList)Session["idList"];
            

            if (idList == null)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }


            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;

                if (idList.Contains("1"))
                {
                    id = "1";
                }
                if (idList.Contains("2"))
                {
                    id2 = "2";
                }
                if (idList.Contains("3"))
                {
                    id3 = "3";
                }
                if (idList.Contains("4"))
                {
                    id4 = "4";
                }
                if (idList.Contains("5"))
                {
                    id5 = "5";
                }


                if (id == "1")
                {
                    TableRow r = new TableRow();

                    string key = "Telefon1";

                    // Retrieve the Furniture object from session state.
                    Product tel1 = (Product)Session[key];
                    
                    Image img = new Image();
                    img.ImageUrl = tel1.ImageUrl;

                    TableCell t = new TableCell();
                    t.Controls.Add(img);
                    r.Cells.Add(t);

                    TableCell t1 = new TableCell();
                    t1.Controls.Add(new LiteralControl(tel1.Vendor + " " + tel1.Model + "<br/>Type:" + tel1.Type + "<br/>Vendor:" + tel1.Vendor + "<br/>"));
                    r.Cells.Add(t1);

                    Table1.Rows.Add(r);

                }
                if (id2 == "2")
                {
                    TableRow r = new TableRow();
                    string key = "Telefon2";

                    // Retrieve the Furniture object from session state.
                    Product tel2 = (Product)Session[key];

                    Image img = new Image();
                    img.ImageUrl = tel2.ImageUrl;

                    TableCell t = new TableCell();
                    t.Controls.Add(img);
                    r.Cells.Add(t);

                    TableCell t1 = new TableCell();
                    t1.Controls.Add(new LiteralControl(tel2.Vendor + " " + tel2.Model + "<br/>Type:" + tel2.Type + "<br/>Vendor:" + tel2.Vendor + "<br/>"));
                    r.Cells.Add(t1);

                    Table1.Rows.Add(r);

                }

                if (id3 == "3")
                {
                    TableRow r = new TableRow();
                    string key = "Telefon3";

                    // Retrieve the Furniture object from session state.
                    Product tel3 = (Product)Session[key];

                    Image img = new Image();
                    img.ImageUrl = tel3.ImageUrl;

                    TableCell t = new TableCell();
                    t.Controls.Add(img);
                    r.Cells.Add(t);

                    TableCell t1 = new TableCell();
                    t1.Controls.Add(new LiteralControl(tel3.Vendor + " " + tel3.Model + "<br/>Type:" + tel3.Type + "<br/>Vendor:" + tel3.Vendor + "<br/>"));
                    r.Cells.Add(t1);

                    Table1.Rows.Add(r);

                }

                if (id4 == "4")
                {
                    TableRow r = new TableRow();
                    string key = "Telefon4";

                    // Retrieve the Furniture object from session state.
                    Product tel4 = (Product)Session[key];

                    Image img = new Image();
                    img.ImageUrl = tel4.ImageUrl;

                    TableCell t = new TableCell();
                    t.Controls.Add(img);
                    r.Cells.Add(t);

                    TableCell t1 = new TableCell();
                    t1.Controls.Add(new LiteralControl(tel4.Vendor + " " + tel4.Model + "<br/>Type:" + tel4.Type + "<br/>Vendor:" + tel4.Vendor + "<br/>"));
                    r.Cells.Add(t1);

                    Table1.Rows.Add(r);

                }
                
                if (id5 == "5")
                {
                    TableRow r = new TableRow();
                    string key = "Telefon5";

                    // Retrieve the Furniture object from session state.
                    Product tel5 = (Product)Session[key];

                    Image img = new Image();
                    img.ImageUrl = tel5.ImageUrl;

                    TableCell t = new TableCell();
                    t.Controls.Add(img);
                    r.Cells.Add(t);

                    TableCell t1 = new TableCell();
                    t1.Controls.Add(new LiteralControl(tel5.Vendor + " " + tel5.Model + "<br/>Type:" + tel5.Type + "<br/>Vendor:" + tel5.Vendor + "<br/>"));
                    r.Cells.Add(t1);

                    Table1.Rows.Add(r);

                }

            }

        }
    }
}
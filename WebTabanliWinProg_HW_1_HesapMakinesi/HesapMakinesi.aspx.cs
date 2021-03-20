using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTabanliWinProg_HW_1_HesapMakinesi
{
    public partial class HesapMakinesi : System.Web.UI.Page
    {
        static int deg1, deg2;
        static Int64 fsonuc;
        static string islem;
        static int sayac=0;
        //static int sayac2=0; //sonuca gore deg1 e atama işlemi yapılırsa.

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
                
            }
        

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "5";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "5";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "5";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "5";
                }

                if (islem != "")
                {
                    if (Label1.Text == "")
                    {
                        Label1.Text = "5";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "5";
                    }
                }

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            deg1 = 0;
            deg2 = 0;
            islem = "";
            fsonuc = 0;
            sayac = 0;
            Label1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "9";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "9";

                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "9";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "9";

                }

                if (islem != "")
                {
                    if (Label1.Text == "")
                    {
                        Label1.Text = "9";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "9";
                    }
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "4";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "4";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "4";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "4";
                }

                if (islem != "")
                {
                    if (Label1.Text == "")
                    {
                        Label1.Text = "4";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "4";
                    }
                }
            }
        
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "6";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "6";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "6";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "6";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "6";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "6";
                    }
                }
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {  


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "1";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "1";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "1";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "1";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "1";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "1";
                    }
                }
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "2";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "2";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "2";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "2";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "2";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "2";
                    }
                }
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {


                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "3";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "3";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "3";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "3";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "3";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "3";
                    }
                }

            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "0";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "0";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "0";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "0";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "0";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "0";
                    }
                }

            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            deg2 = Int32.Parse(Label1.Text);

            switch (islem)
            {
                case "/":
                    fsonuc = deg1 / deg2;
                    TextBox1.Text = fsonuc.ToString();
                    Label1.Text = "";
                    islem = "";
                    break;
                case "*":
                    fsonuc = deg1 * deg2;
                    TextBox1.Text = fsonuc.ToString();
                    Label1.Text = "";
                    islem = "";
                    break;
                case "+":
                    fsonuc = deg1 + deg2;
                    TextBox1.Text = fsonuc.ToString();
                    Label1.Text = "";
                    islem = "";
                    break;
                case "-":
                    fsonuc = deg1 - deg2;
                    TextBox1.Text = fsonuc.ToString();
                    Label1.Text = "";
                    islem = "";
                    break;
                default:
                    TextBox1.Text = "ERROR";
                    break;
            }



        }

        protected void Button4_Click(object sender, EventArgs e) // bolme islemi butonu
        {
            try
            {
                Label2.Text = "";
                deg1 = Int32.Parse(TextBox1.Text);

                islem = "/";
                TextBox1.Text = TextBox1.Text + islem;
                sayac++;
                //TextBox1.Text = "0";
            }
            catch
            {
       
                Label2.Text = "DEGER COK BUYUK, LUTFEN DAHA KUCUK SAYILAR GİRİNİZ!!!";
                TextBox1.Text = "0";
                deg1 = 0;
                deg2 = 0;
                islem = "";
                fsonuc = 0;
                sayac = 0;
                Label1.Text = "";
            }

        }

        protected void Button1_Click(object sender, EventArgs e) 
        {
            if (sayac == 0)
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "7";
                }
                else

                {
                    TextBox1.Text = TextBox1.Text + "7";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "7";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "7";
                }
                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "7";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "7";
                    }
                }

            }
            
        }

        protected void Button8_Click(object sender, EventArgs e) //carpim islemi butonu
        {
            try
            {
                Label2.Text = "";
                deg1 = Int32.Parse(TextBox1.Text);
                islem = "*";
                TextBox1.Text = TextBox1.Text + islem;
                sayac++;
                //TextBox1.Text = "0";
            }

            catch
            {
                Label2.Text = "DEGER COK BUYUK, LUTFEN DAHA KUCUK SAYILAR GİRİNİZ!!!";
                TextBox1.Text = "0";
                deg1 = 0;
                deg2 = 0;
                islem = "";
                fsonuc = 0;
                sayac = 0;
                Label1.Text = "";
            }
        }

        protected void Button12_Click(object sender, EventArgs e) //fark islemi butonu
        {
            try
            {
                Label2.Text = "";
                deg1 = Int32.Parse(TextBox1.Text);
                islem = "-";
                TextBox1.Text = TextBox1.Text + islem;
                sayac++;
                //TextBox1.Text = "0";
            }

            catch
            {
                Label2.Text = "DEGER COK BUYUK, LUTFEN DAHA KUCUK SAYILAR GİRİNİZ!!!";
                TextBox1.Text = "0";
                deg1 = 0;
                deg2 = 0;
                islem = "";
                fsonuc = 0;
                sayac = 0;
                Label1.Text = "";
            }
        }

        protected void Button14_Click(object sender, EventArgs e) //toplama islemi butonu
        {
            try
            {
                Label2.Text = "";
                deg1 = Int32.Parse(TextBox1.Text);
                islem = "+";
                TextBox1.Text = TextBox1.Text + islem;
                sayac++;
                //TextBox1.Text = "0";
            }
            catch
            {
                Label2.Text = "DEGER COK BUYUK, LUTFEN DAHA KUCUK SAYILAR GİRİNİZ!!!";
                TextBox1.Text = "0";
                deg1 = 0;
                deg2 = 0;
                islem = "";
                fsonuc = 0;
                sayac = 0;
                Label1.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "8";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "8";
                }
            }
            else
            {
                if (TextBox1.Text == "0")
                {
                    TextBox1.Text = "8";
                }
                else
                {
                    TextBox1.Text = TextBox1.Text + "8";
                }

                if (islem != "")
                {

                    if (Label1.Text == "")
                    {
                        Label1.Text = "8";
                    }
                    else
                    {
                        Label1.Text = Label1.Text + "8";
                    }
                }

            }

        }

    }
}
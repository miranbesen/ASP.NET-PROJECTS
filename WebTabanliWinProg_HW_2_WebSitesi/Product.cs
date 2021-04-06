using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTabanliWinProg_Alistirma2
{
    public class Product
    {
        public int ProductID; //UrunId
        public string Type; //Urun tip
        public string Vendor; //Urun saticisi
        public string Model; //Urun modeli
        public string ImageUrl;
        
        public Product(int ProductID, string Type, string Vendor, string Model, string ImageUrl)
        {
            this.ProductID = ProductID;
            this.Type = Type;
            this.Vendor = Vendor;
            this.Model = Model;
            this.ImageUrl = ImageUrl;
        }

    }
}
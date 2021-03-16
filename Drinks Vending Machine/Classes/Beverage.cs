using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Drinks_Vending_Machine.Classes
{
      class Beverage
       {
        
       public string name;

       public  double price;

       public string urlimg="";

       public BitmapImage bt;
       public Beverage()
        {
            name = "";
            price = 0;
            bt = new BitmapImage(new Uri("", UriKind.Relative));
        }
      
       public Beverage(string name, double price, string urlimg)
        {

            
            this.urlimg = urlimg;
            this.name = name;
            this.price = price;
            bt = new BitmapImage(new Uri(urlimg, UriKind.Relative));
        }

        public  virtual string AddIngredients()
        {
            return "";
        }

        public virtual string AddhotWater()
        {
            return "";
        }

        public virtual string stirring()
        {
            return "";
        }

        public string Prepare()
        {

            StringBuilder preper = new StringBuilder();

            preper.AppendLine(  AddIngredients());

            preper.AppendLine(AddhotWater());

            preper.AppendLine(stirring());

            return preper.ToString();

        }

        public override string ToString()
        {
            return $"Name of Beverage:{name} Price of Beverage:{price}";
        }

        public override bool Equals(object obj)
        {
            bool res = false;

            Beverage bever = obj as Beverage;

            if (bever != null)
            {
                if(this.name==bever.name && this.price == bever.price)
                {

                    res= true;
                }
                else
                {

                    res= false;

                }

                 res=false;
            }

            return res;
        }


       }
}

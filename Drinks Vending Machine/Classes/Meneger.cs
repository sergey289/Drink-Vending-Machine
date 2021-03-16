using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Drinks_Vending_Machine.Classes
{
    class Meneger:Vending_machine
    {
        

        Beverage espressoh = new Espresso("Espresso", 1, "/Resources/Espresso.png");

        Beverage Doub_espresso = new Double_espresso("Double Espresso", 2, "/Resources/Double Espresso.png");

        Beverage mocaccino = new Double_espresso("Mocaccino", 4, "/Resources/mocaccino.png");

        Beverage hotchocolate = new Hot_Chocolate("Hot Chocolate", 5, "/Resources/Hot Chocolate.png");


        public void FillMashineDefultBever()
        {

           DefultBeverege(espressoh);
           DefultBeverege(Doub_espresso);
           DefultBeverege(mocaccino);

        }

        public void AddnewBever(string name)
        {

            if(name.Equals("Hot Chocolate"))
            {
               
               AddnewBeverage(hotchocolate);

             }
               
                

           

        }

        public void RemoveBev(string name)
        {

            Beverage bev = Allbeverege.Find(x => x.name.Contains(name));

            RemoveBeverege(bev);

        }

        public  List<usercont_Beverege>  ShowAllBevInMashine()
        {

           

            List<usercont_Beverege> bev = new List<usercont_Beverege>();

            foreach(Beverage i in Allbeverege)
            {
               

                usercont_Beverege bever = new usercont_Beverege();

                bever.txt_name.Text = i.name;

                bever.txt_price.Text = "$" + i.price.ToString();

                bever.img_logo.Source = i.bt;

                bev.Add(bever);

               
               

            }

            return bev;

        }

    }



}

 


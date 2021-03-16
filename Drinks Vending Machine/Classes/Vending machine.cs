using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace Drinks_Vending_Machine.Classes
{
    class Vending_machine
    {


       public static string nameOfBeverege;

       public  static List<Beverage> Allbeverege = new List<Beverage>();
       public   void AddnewBeverage(Beverage bev)
       {
            if (!Allbeverege.Contains(new Beverage(bev.name, bev.price, bev.urlimg)))
            {


                Allbeverege.Add(new Beverage(bev.name, bev.price, bev.urlimg));

            }

        }
       public   void DefultBeverege(Beverage bev)
        {

            Allbeverege.Add(bev);

        }
       public int AmountOfBevereges()
        {

            return Allbeverege.Count;
            


        }
       public  void RemoveBeverege(Beverage bev)
        {


            try
            {

                

               int index = Allbeverege.FindIndex(a => a.name == bev.name);
           
                Allbeverege.RemoveAt(index);

            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show(ex.Message);


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);


            }
           



    }
       public string ActivatePrepere()
        {

            string metprepere="";

            if (nameOfBeverege.Equals("Espresso"))
            {

                Beverage esp = new Espresso();

                metprepere= esp.Prepare();
               


            }else if(nameOfBeverege.Equals("Double Espresso"))
            {

                Beverage DoUbesp = new Double_espresso();

                metprepere = DoUbesp.Prepare();


            }else if(nameOfBeverege.Equals("Mocaccino"))
            {

                Beverage mocaccino = new Mocaccino();

                metprepere = mocaccino.Prepare();

            
            }else if (nameOfBeverege.Equals("Hot Chocolate"))
            {

                Beverage Hot_Chocolate = new Hot_Chocolate();

                metprepere = Hot_Chocolate.Prepare();
            }

            return metprepere;

        }


    }


}


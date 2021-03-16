using Drinks_Vending_Machine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drinks_Vending_Machine
{
    
    public partial class usercont_Beverege : UserControl
    {
        public usercont_Beverege()
        {
            InitializeComponent();
        }

        string BevName="";

        private void Button_access()
        {

            if (BevName != "")
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {

                        (window as MainWindow).btn_remove_bev.IsEnabled = true;
                    }
                }

            }


        }

       
        private void btn_choce_Click(object sender, RoutedEventArgs e)
        {
 

             btn_choce.Background = Brushes.Yellow;

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).pan_preper_meth.Children.Clear();
                }
            }



            if (txt_name.Text.Equals("Espresso"))
            {
                BevName = "Espresso";

                MainWindow.nameofbevtoremove = BevName;


                Vending_machine.nameOfBeverege = BevName;

                UserCont_espresso esp = new UserCont_espresso();

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                       
                        (window as MainWindow).pan_preper_meth.Children.Add(esp);
                    }
                }




            }else if (txt_name.Text.Equals("Double Espresso"))
            {

                BevName = "Double Espresso";

                MainWindow.nameofbevtoremove = BevName;

                Vending_machine.nameOfBeverege = BevName;

                UserCont_espresso esp = new UserCont_espresso();

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).pan_preper_meth.Children.Add(esp);
                    }
                }


            }else if (txt_name.Text.Equals("Mocaccino")){


                BevName = "Mocaccino";

                MainWindow.nameofbevtoremove = BevName;

                Vending_machine.nameOfBeverege = BevName;

                Addition_Mocaccino esp = new Addition_Mocaccino();

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).pan_preper_meth.Children.Add(esp);
                    }
                }


            }
            else if (txt_name.Text.Equals("Hot Chocolate"))
            {


                BevName = "Hot Chocolate";

                MainWindow.nameofbevtoremove = BevName;

                Vending_machine.nameOfBeverege = BevName;

                Addition_Hot_Chocolate hotchoc = new Addition_Hot_Chocolate();

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).pan_preper_meth.Children.Add(hotchoc);
                    }
                }


            }

            Button_access();

        }

        
    }
}

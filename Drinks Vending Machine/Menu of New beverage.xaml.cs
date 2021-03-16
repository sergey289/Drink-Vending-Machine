using Drinks_Vending_Machine.Classes;
using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Windows.Shapes;

namespace Drinks_Vending_Machine
{
    
    public partial class Menu_of_New_beverage : Window
    {
        public Menu_of_New_beverage()
        {
            InitializeComponent();
        }

        Meneger meng = new Meneger();

        string choise = "";


        private void btn_addto_menu_Click(object sender, RoutedEventArgs e)
        {



            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).main_manu.Children.Clear();
                }
            }

             meng.AddnewBever(choise);

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).ShowAllBeverege();
                }
            }

            this.Close();


        }

        private void btn_choce_hotchoc_Click(object sender, RoutedEventArgs e)
            {
              btn_choce_hotchoc.Background = Brushes.Yellow;

               choise = "Hot Chocolate";

            }

       

       
    }
}

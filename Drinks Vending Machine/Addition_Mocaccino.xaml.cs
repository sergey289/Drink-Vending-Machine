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
    
    public partial class Addition_Mocaccino : UserControl
    {
        public Addition_Mocaccino()
        {
            InitializeComponent();
        }


        public static string ingredientOfChoice = "";

        private void rad_sugrarless_Checked(object sender, RoutedEventArgs e)
        {

            if (rad_sugrarless.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }


            ingredientOfChoice = "Sugrarless";


        }

        private void rad_witch_broun_sug_Checked(object sender, RoutedEventArgs e)
        {


            if (rad_witch_broun_sug.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }

            ingredientOfChoice = "Broun Sugr";



        }

        private void rad_witch_crem_Checked(object sender, RoutedEventArgs e)
        {

            if (rad_witch_crem.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }

            ingredientOfChoice = "Witch crem";


        }
    }
}

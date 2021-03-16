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

    public partial class Addition_Hot_Chocolate : UserControl
    {
        public Addition_Hot_Chocolate()
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

        private void rad_Whipped_cream_Checked(object sender, RoutedEventArgs e)
        {

            if (rad_Whipped_cream.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }


            ingredientOfChoice = "Whipped cream";


        }

        private void rad_Marshmallows_Checked(object sender, RoutedEventArgs e)
        {
            if (rad_Marshmallows.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }


            ingredientOfChoice = "Marshmallows";
        }
    }
}

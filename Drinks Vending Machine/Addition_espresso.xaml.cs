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
    
    public partial class UserCont_espresso : UserControl
    {
        public UserCont_espresso()
        {
            InitializeComponent();

        }

       

        public static string ingredientOfChoice="";
        
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
            
            rad_witch_sug.BorderBrush = Brushes.Green;

            rad_sugrarless.BorderBrush = Brushes.Black;

            rad_witch_broun_sug.BorderBrush = Brushes.Black;
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

            rad_witch_broun_sug.BorderBrush = Brushes.Green;

            rad_witch_sug.BorderBrush = Brushes.Black;

            rad_sugrarless.BorderBrush = Brushes.Black;
        }

        private void rad_witch_sug_Checked(object sender, RoutedEventArgs e)
        {

            if (rad_witch_sug.IsChecked == true)
            {

                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).btn_preper.Visibility = Visibility.Visible;
                    }
                }


            }


            ingredientOfChoice = "White Sugr";

            rad_witch_sug.BorderBrush = Brushes.Green;

            rad_sugrarless.BorderBrush = Brushes.Black;

            rad_witch_broun_sug.BorderBrush = Brushes.Black;
        }

        
    }
}

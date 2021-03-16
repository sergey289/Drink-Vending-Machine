using Drinks_Vending_Machine.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
    
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
           

            InitializeComponent();

            btn_preper.Visibility = Visibility.Hidden;

            fiilMachine();

            ShowAllBeverege();


        }

        public static string nameofbevtoremove = "";
        
        Vending_machine venMachine = new Vending_machine();

        Meneger meng = new Meneger();

       
        public void fiilMachine()
        {

            meng.FillMashineDefultBever();

        }

        public  void RemoveBeverege()
        {
            meng.RemoveBev(nameofbevtoremove);

            pan_preper_meth.Children.Clear();

            txt_win.Text = "";

            btn_preper.Visibility = Visibility.Hidden;

        }

        public void ShowAllBeverege()
        {

            List<usercont_Beverege> ListOfbeverege = meng.ShowAllBevInMashine();

            foreach (usercont_Beverege i in ListOfbeverege)
            {

                if (main_manu.Children.Count <= 2)
                {
                   
                    main_manu.Children.Add(i);
                   
                    
                }
                else
                {
                  
                      i.Margin = new Thickness(-510, 150, 0, 0);

                       main_manu.Children.Add(i);

                }







            }
           



        }
       
        private void btn_preper_Click(object sender, RoutedEventArgs e)
        {

            txt_win.Text = venMachine.ActivatePrepere();

        }

        private void btn_add_bev_Click(object sender, RoutedEventArgs e)
        {
          
            Menu_of_New_beverage newWindow = new Menu_of_New_beverage();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
        

        }

        private void btn_remove_bev_Click(object sender, RoutedEventArgs e)
        {
            
             RemoveBeverege();

             main_manu.Children.Clear();

             ShowAllBeverege();


        }

       
    }
}

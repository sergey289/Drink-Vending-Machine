using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_Vending_Machine.Classes
{
    class Mocaccino:Beverage
    {

        Beverage beverage = new Beverage();

        List<string> ingredients;

        public Mocaccino()
        {
            ingredients = new List<string>();

        }

        public Mocaccino(string name, double price, string urlimg) : base(name, price, urlimg)
        {
            ingredients = new List<string>();

        }

        public void AddingredientsToList()
        {



            ingredients.Add("Ground coffee");
            ingredients.Add("milk");
            ingredients.Add("chocolate");
            ingredients.Add(Addition_Mocaccino.ingredientOfChoice);


        }


        public override string AddIngredients()
        {
            AddingredientsToList();

            StringBuilder AllIngredients = new StringBuilder();

            for (int i = 0; i < ingredients.Count; i++)
            {
                AllIngredients.AppendLine(ingredients[i]);



            }


            return AllIngredients.ToString();
        }


        public override string AddhotWater()
        {

            return "Water temperature 95 ° C";
        }


        public override string stirring()
        {
            return "Stirring process in progress";

        }


        public new string Prepare()
        {
            StringBuilder preper = new StringBuilder();

            preper.AppendLine(beverage.Prepare());

            return preper.ToString();

        }


        public override string ToString()
        {
            return base.ToString();
        }




    }
}

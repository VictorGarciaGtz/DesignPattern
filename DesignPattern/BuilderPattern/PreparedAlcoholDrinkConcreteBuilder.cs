using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class PreparedAlcoholDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;

        public PreparedAlcoholDrinkConcreteBuilder()
        {
            _preparedDrink = new PreparedDrink();
        }

        public void AddIngredients(List<string> ingredients)
        {
            if(_preparedDrink.Ingredients == null)
            {
                _preparedDrink.Ingredients = new List<string>();
            }

            _preparedDrink.Ingredients.AddRange(ingredients);   
        }

        public void Mix()
        {
            string ingredients = string.Join(", ", _preparedDrink.Ingredients);
            _preparedDrink.Result = string.Format("Mixing {0} with {1} ml of water and {2} ml of milk", ingredients, _preparedDrink.Water, _preparedDrink.Milk);
            Console.WriteLine("Mazclamos los ingredientes");
        }

        public void Reset()
        {
            _preparedDrink = new PreparedDrink();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Resting for {0} seconds", time);
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
           _preparedDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }

        public PreparedDrink GetPreparedDrink()
        {
            return _preparedDrink;
        }
    }
}

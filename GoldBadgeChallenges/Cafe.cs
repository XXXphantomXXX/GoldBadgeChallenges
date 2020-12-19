using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    public class Cafe
    {
        //POCO
        public int MealNum { get; set; } 
        public double Price { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public Cafe()
        {

        }
        public Cafe (int mealNum, double price, string mealName, string description, List<string> ingredients)
        {
            MealNum = mealNum;
            Price = price;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
        }
    }
}

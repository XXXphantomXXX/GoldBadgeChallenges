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
        //ask to explan constructers not fully understanding what they do 
        public Cafe (string mealNum, double price, string mealName, string description, string ingredients)
        {
            MealNum = mealNum;
            Price = price;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
        }
    }
}

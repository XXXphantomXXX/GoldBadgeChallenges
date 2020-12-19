using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    public class CafeRepo
    {
        public readonly List<Cafe> _cafemenu = new List<Cafe>();

        //Create
        public void AddMeal(Cafe FoodItem)
        {
            _cafemenu.Add(FoodItem);
        }

        //Read
        public List<Cafe> GetMenu()
        {
            return _cafemenu;
        }
        //update
        public bool UpdateMenu(int originalMealNum, Cafe NewMealNum)
        {
            //find
            Cafe oldMealNum = GetMenuByNum(originalMealNum);

            //update
            if (oldMealNum != null)
            {
                oldMealNum.MealNum = NewMealNum.MealNum;
                oldMealNum.Price = NewMealNum.Price;
                oldMealNum.MealName = NewMealNum.MealName;
                oldMealNum.Description = NewMealNum.Description;
                oldMealNum.Ingredients = NewMealNum.Ingredients;
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Delete
        public bool RemoveFoodItem(int mealNum)
        {
            Cafe foodItem = GetMenuByNum(mealNum);

            if (foodItem == null)
            {
                return false;
            }
            int intialCount = _cafemenu.Count;
            _cafemenu.Remove(foodItem);

            if(intialCount > _cafemenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        //GetHelper Method GetByMealNumber\
        private Cafe GetMenuByNum(int MealNum)
        {
            foreach(Cafe foodItem in _cafemenu)
            {
                if (foodItem.MealNum == MealNum)
                {
                    return foodItem;
                }
            }
            return null;
        }
    }
}

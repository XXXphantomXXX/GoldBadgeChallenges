using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepository
{
    class CafeRepo
    {
        private readonly List<Cafe> _cafemenu = new List<Cafe>();

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
        //Update
        //ask why it keeps making it a class not a method
        public UpdateMenu(string originalMealNum, Cafe NewMealNum)
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
            }

        }

        //Delete
        public bool RemoveFoodItem(string MealNum)
        {
            Cafe FoodItem = GetMenuByNum(FoodItem);

            if (FoodItem == nill)
            {
                return false;
            }
            int intialCount = _cafemenu.Count;
            _cafemenu.Remove(FoodItem);

            if(intialCount > _cafemenu.count)
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
            foreach(Cafe FoodItem in _cafemenu)
            {
                if (FoodItem.MealNum == MealNum)
                {
                    return FoodItem;
                }
            }
            return null;
        }
    }
}

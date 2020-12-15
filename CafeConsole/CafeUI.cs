using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRepository;



namespace CafeConsole
{

    class CafeUI
    {
        private CafeRepo _menuRepo = new CafeRepo();

      
       public void Run()
        {
            Menu();
        }

        
        private void Menu()
        {
            bool KeepRunning = true;
            while (KeepRunning)
            {
                //Menu Options
                Console.WriteLine("Select a menu options:\n" +
                    "1. Add New Food to menu\n" +
                    "2. Update Menu\n" +
                    "3. Delete food from menu\n" +
                    "4. show Menu\n" +
                    "5. Exit");

                //Input
                string input = Console.ReadLine();

                //Evaluate
                switch (input)
                {
                    case "1":
                        AddNewDish();
                        break;

                    case "2":
                        UpdateDish();
                        break;

                    case "3":
                        RemoveDish();
                        break;

                    case "4":
                        ShowMenu();
                        break;

                    case "5":
                        KeepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Stop playing with me and enter a right number!");
                        break;

                }
                Console.WriteLine("please press a key...");
                Console.ReadKey();
                Console.Clear();
            }
        }



        //Create
        public void AddNewDish()
        {
            Cafe foodItem = new Cafe();//ask about
            Console.WriteLine("Enter dish name");
            foodItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter Dish description ");
            foodItem.Description = Console.ReadLine();

            Console.WriteLine("Enter Dish Number");
            foodItem.MealNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Dish Price");
            foodItem.Price = double.Parse(Console.ReadLine());

            List<string> ingredientList = new List<string>();
            Console.WriteLine("how many ingredients are in this dish?");
            int ingredentnum = int.Parse(Console.ReadLine());
            for(int i = 0; i < ingredentnum; i++)
            {
                Console.WriteLine("what is your next ingredient");
                string ingredient = Console.ReadLine();
                ingredientList.Add(ingredient);
            }

            _menuRepo.AddMeal(foodItem);
        }


        //Read
        public void ShowMenu()
        {
            List<Cafe> ViewAllMenu = _menuRepo.GetMenu();

            foreach(Cafe FoodItem in ViewAllMenu)
            {
                Console.WriteLine($"Name:{FoodItem.MealName}\n Description:{FoodItem.Description}\n " +
                    $"Ingredients:{FoodItem.Ingredients}\n Meal Number:{FoodItem.MealNum}\n Price:{FoodItem.Price}");
            }
        }
        //Update

        //Delete
        public void RemoveDish()
        {
            ShowMenu();


        }


        //Seed Data
        private void SeedList()
        {
            Cafe ChickenCurry = new Cafe(5, 6.99, "Chicken Curry","chicken with curry sauce and rice","curry");
            _menuRepo.AddMeal(ChickenCurry);
        }
    }
}


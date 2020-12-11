using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeConsole
{
    class CafeUI
    {
        public void Run()
        {
            Menu();
        }
        //why is menu void isnt it returning what the user is inputing??
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
                        showMenu();
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

        //Read

        //Update

        //Delete


        //Seed Data
    }
}

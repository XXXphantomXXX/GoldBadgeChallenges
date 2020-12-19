using BadgeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BadgeConsole
{
    class BadgeUI
    {
        private BadgePoco _badgeUIRepo = new BadgePoco();
        private BadgeRepo _badgeRepo = new BadgeRepo();

        public void Run()
        {

            Menu();
        }

        // Menu
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Menu Options
                Console.WriteLine("Hello Security Admin\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Exit\n");

                //Input
                string input = Console.ReadLine();

                //Evaluate
                switch (input)
                {
                    case "1":
                        NewBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Stop playing with me and enter a right number");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public void NewBadge()
        {
            Console.Clear();
            BadgePoco badge = new BadgePoco();
            Console.WriteLine("What is badge number?");
            badge.BadgeID = int.Parse(Console.ReadLine());

            List<string> doors = new List<string>();
            Console.WriteLine("Add door badge will access");
            doors.Add(Console.ReadLine());
            Console.WriteLine("Add anther door?(y/n)?");
            bool Answer = bool.Parse(Console.ReadLine());
            bool RunnerBoy = true;
            while (RunnerBoy)
            {
                if (Answer == true)
                {
                    Console.WriteLine("Enter Next door");
                    doors.Add(Console.ReadLine());
                    RunnerBoy = false;
                }
                else
                {
                    RunnerBoy = false;
                }
            }
            badge.DoorNames = doors;
            _badgeRepo.AddNewBadge(badge.BadgeID, badge);
        }


        public void ListBadges()
        {

        }

        public void UpdateBadge()
        {
            Console.Clear();
            ListBadges();
            Console.WriteLine("Enter number of the badge youre updating?");
            int NumB = int.Parse(Console.ReadLine());
            BadgePoco badge = _badgeRepo.GetBadgeByID(NumB);

            

            
        }
        private string ListOfDoors(List<string> doors)
        { 
            
        }

    }
}
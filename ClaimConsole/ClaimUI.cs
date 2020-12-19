using ClaimRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaimConsole
{
    class ClaimUI
    {
        private ClaimsRepo _claimUIRepo = new ClaimsRepo();


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
                    "1. Create a claim\n" +
                    "2. Update Claim\n" +
                    "3. Delete Claim\n" +
                    "4. show All Claims\n" +
                    "5. Exit");
                //Input
                string input = Console.ReadLine();
                //Evaluate
                switch (input)
                {
                    case "1":
                        AddNewClaim();
                        break;

                    case "2":
                        UpdateClaim();
                        break;

                    case "3":
                        NextClaim();
                        break;

                    case "4":
                        ShowClaims();
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
        public void AddNewClaim()
        {
            ClaimsPoco claims = new ClaimsPoco();

            Console.WriteLine("Enter Claim ID number");
            claims.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Claim description ");
            claims.Description = Console.ReadLine();

            Console.WriteLine("Enter Claim Amount");
            claims.ClaimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of incident");
            claims.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of claim");
            claims.DateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is claim Valid? (true/false)");
            claims.IsValid = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number assosiated to the claim type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            int TypeNum = int.Parse(Console.ReadLine());
            claims.TypeOfClaim = (ClaimType)TypeNum;
            _claimUIRepo.AddClaim(claims);
        }
        public void ShowClaims()
        {
            Console.Clear();

            Queue<ClaimsPoco> ViewAllClaims = _claimUIRepo.GetClaims();

            foreach (ClaimsPoco content in ViewAllClaims)
            {
                Console.WriteLine($"claim ID:{content.ClaimID}\n Description:{content.Description}\n " +
                    $"Claim Amount:{content.ClaimAmount}\n Date of incident:{content.DateOfIncident}\n Date of claim:{content.DateOfClaim}\n" +
                    $"Is Claim Valid:{content.IsValid}\n Type of claim:{content.TypeOfClaim}");
            }
        }
        public void NextClaim()
        {
            Console.Clear();

            ClaimsPoco claims = _claimUIRepo.CurrentClaim();

            Console.WriteLine($"Claim ID:{claims.ClaimID}\n Description:{claims.Description}\n Claim Amount:{claims.ClaimAmount}\n Date of Incident:{claims.DateOfIncident}\n" +
                $"Date of Claim:{claims.DateOfClaim} Is Claim Valid:{claims.IsValid} Type of Claim:{claims.TypeOfClaim}");

            Console.WriteLine("Do you want to deal with claim?(true/false)");
            bool DealWithClaim = bool.Parse(Console.ReadLine());

            bool keepRunning = true;
            while (keepRunning)
            {
                if (DealWithClaim == true)
                {
                    _claimUIRepo.RemoveClaim();
                    keepRunning = false;
                }
                else if(DealWithClaim == false)
                {
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Choose True or false");
                }
            }
        }
        public void UpdateClaim()
        {
            ShowClaims();

            Console.WriteLine("Enter number of Item youll like to update.");

            int oldClaim = int.Parse(Console.ReadLine());
            ClaimsPoco claims = new ClaimsPoco();
            Console.WriteLine("Enter Claim ID number");
            claims.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Claim description ");
            claims.Description = Console.ReadLine();

            Console.WriteLine("Enter Claim Amount");
            claims.ClaimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of incident");
            claims.DateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of claim");
            claims.DateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is claim Valid? (true/false)");
            claims.IsValid = bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number assosiated to the claim type:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            int TypeNum = int.Parse(Console.ReadLine());
            claims.TypeOfClaim = (ClaimType)TypeNum;
            _claimUIRepo.UpdateClaim(oldClaim, claims);
        }
    } 
}











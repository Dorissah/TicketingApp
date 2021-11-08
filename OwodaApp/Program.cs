using System;

namespace Assigment3
{
    class Program
    {
        static void Main(string[] args)
        {
            OwodaApp Doris = new OwodaApp();
            Doris.MenuChoice();
        }
    }
    class OwodaApp
    {

        public string ticketType { get; set; }
        public double ticketPrice = 0;
        public double ticketSold = 0;
        private double totalAmount = 0.00;


        public void MenuChoice()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("choose action from menu");
            Console.WriteLine("1 to Buy ticket");
            Console.WriteLine("2 to Sales summary");

            string menuType = Console.ReadLine();
            if (menuType == "1")
            {
                BuyTicket();
            }
            else if (menuType == "2")
            {
                TotalSales();
            }
            else
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("Go back to menu and try again");

            }

        }
        public void BuyTicket()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Select Ticket Type");
            Console.WriteLine("1 for Daily");
            Console.WriteLine("2 for Monthly");
            //generate random number
            string ticketChoice = Console.ReadLine();
            Random rnd = new Random();
            int num = rnd.Next();
            Console.WriteLine("**************************************");
            if (ticketChoice == "1")
            {
                ticketPrice = 100;
                ticketSold += 1;
                Console.WriteLine($"ticket ID number is {num}");
                Console.WriteLine("Ticket Type: Daily");
                Console.WriteLine($"Ticket Price: {ticketPrice}");
                Console.WriteLine("**************************************");
                GoToMainMenu();
            }
            else

            {
                ticketPrice = 100 * 30 / 2;
                Console.WriteLine($"ticket ID number is {num}");
                Console.WriteLine("Ticket Type: Monthly");
                Console.WriteLine($"Ticket Price: NGN {ticketPrice}");
                Console.WriteLine("**************************************");
                GoToMainMenu();
            };


        }

      
        public void TotalSales()
        {

            totalAmount = ticketPrice * ticketSold;
            Console.WriteLine($"Total ticket Sold: {ticketSold}");
            Console.WriteLine($"Total ticket amount: {totalAmount} ");
            double ogaShare = 0.65 * totalAmount;
            double agberoShare = totalAmount - ogaShare;
            Console.WriteLine($"Oga Share: {ogaShare}");
            Console.WriteLine($"Agbero your Share: {agberoShare}");
            Console.WriteLine("**************************************");
            GoToMainMenu();
        }
        public void GoToMainMenu()
        {
            Console.WriteLine("select 1 to go to main menu");
            string menu = Console.ReadLine();

            if (menu == "1")
            {
                MenuChoice();
                Console.WriteLine("**************************************");
            }

            else
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("Go back to menu and try again");
            }
        }

    }
}


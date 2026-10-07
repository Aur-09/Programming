using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            // Declare and size the jagged array for string values
            string[][] hall = new string[5][];
            hall[0] = new string[4];
            hall[1] = new string[6];
            hall[2] = new string[8];
            hall[3] = new string[10];
            hall[4] = new string[12];

            int choice = 0;
            int totalseats_count = 0;
            for (int r = 0; r < hall.Length; r++)
            {
                for (int c = 0; c < hall[r].Length; c++)
                {
                    hall[r][c] = "";
                    totalseats_count++;
                }
            }

            DisplayWelcomePage();
            while (choice != 3)
            {
                Console.Clear();
                DisplayMenu();
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                {
                    Console.Clear();
                    if (choice == 1)
                    {
                        Book(hall);
                    }
                    else if (choice == 2)
                    {
                        int seatNumber = 1;
                        Console.WriteLine("Hall Showing Booked and Unbooked Seats\n");

                        for (int row = 0; row < hall.Length; row++)
                        {
                            for (int col = 0; col < hall[row].Length; col++)
                            {
                                Console.Write(hall[row][col]);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The number entered is either not a valid number or not within the range of the available options(1-3)");
                }
            }
        }
        static void Book(string[][] hall)
        {
            int row = 0;
            int col = 0;
            string name = "";
            int seatpassed_count = 0;
            Console.Write("Enter the seat number you would like to book(1-40): ");
            if (int.TryParse(Console.ReadLine(), out int seat_number) && seat_number >= 1 && seat_number <= 40)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                bool located = false;
                while (!located)
                {
                    if ((seat_number - seatpassed_count) <= hall[row].Length)
                    {
                        col = (seat_number - seatpassed_count) - 1;
                        if (hall[row][col] == "")
                        {
                            Console.WriteLine($"Seat {seat_number} is available for booking");
                            Console.WriteLine("Do you want to proceed and book the seat?(y/n): ");
                            string choice = Console.ReadLine().ToLower();
                            if (choice == "y" || choice == "yes".Trim())
                            {
                                hall[row][col] = $"{name}";
                                Console.WriteLine($"Seat {seat_number} has been succefully booked");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n\n======= IF YOU SEE THIS ITS EITHER YOU CHOSE A 'NO' OR YOU JUST ENTERED WHAT WAS NOT ASKED OF YOU TO ENTER! ========\n\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Do you want to book for a different seat or you want just stop and exit? ");
                                Console.WriteLine("If you want to continue, please press enter and choose option 1,\n IF NOT... press enter and choose option 3 to exit");
                                Console.ResetColor();
                                Console.ReadLine();
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine($"Seat {seat_number} is not available for booking, it has already been booked");
                        }
                        located = true;
                    }
                    else
                    {
                        seatpassed_count += hall[row].Length;
                        row = row + 1;
                    }
                }
            }        
            else
            {
                Console.WriteLine("The number entered is either not a valid number or not within the range of the available seats(1-40)");
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select your option below:");
            Console.WriteLine("1. Book a seat");
            Console.WriteLine("2. View available seats");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
        }
        static void DisplayWelcomePage()
        {
            Console.WriteLine("============ Welcome to Aur09 Stadium ==============");
            Console.WriteLine(@"                 =======      ");
            Console.WriteLine(@"               //       \\      ");
            Console.WriteLine(@"              //  *   *  \\     ");
            Console.WriteLine(@"              \\         //      ");
            Console.WriteLine(@"               \\  ===  //      ");
            Console.WriteLine(@"                 =======     ");
            Console.WriteLine(@"                   ||||      ");
            Console.WriteLine(@"                 ========      ");
            Console.WriteLine(@"           //    ========    \\ ");
            Console.WriteLine(@"          //     ========     \\ ");
            Console.WriteLine("====================================================");
            Console.Write("Press enter to procceed.......");
            Console.ReadLine();
        }
    }
}

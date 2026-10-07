// Name: Noluthando Buda
// Student Number: 2028419741
// Practical: CSIS 1624 - Practical 3
// Date: 30/07/2026

using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace CineVerseBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged Array: VIP stadium seating. Each seat stores the name of the
            // person who booked it, or "" if the seat is still available.
            // Row 0 (front) has fewer seats, back rows have more.
            string[][] hall;
            InitializeHall(new int[] { 4, 6, 8, 10, 12 }, out hall);

            int choice;
            string input;

            do
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("     CINEVERSE STADIUM SEATING SYSTEM   ");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. View Seating Chart & Book a Seat");
                Console.WriteLine("2. View Number of Available Seats");
                Console.WriteLine("0. Exit");
                Console.WriteLine("=========================================");
                Console.Write("Enter your choice: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    choice = -1;
                }

                if (choice == 1)
                {
                    HandleBooking(hall);
                }
                else if (choice == 2)
                {
                    int available;
                    CountAvailableSeats(hall, out available);
                    Console.WriteLine($"\nThere are {available} seats still available.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
                else if (choice == 0)
                {
                    Console.WriteLine("\nThank you for using CineVerse. Goodbye!");
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }

            } while (choice != 0);
        }

        // Creates the jagged array. seatsPerRow[r] gives the number of seats in row r.
        // Every seat starts as "" (empty string) to show it is available.
        static void InitializeHall(int[] seatsPerRow, out string[][] hall)
        {
           hall = new string[seatsPerRow.Length][];
           // for (int r = 0; r < hall.Length; r++)
           // {
           //     for (int c = 0; c < hall[r].Length; c++)
           //     {
           //         hall[r][c] = "";
           //     }
           // }
        }

        static void DisplayHall(string[][] hall)
        {
            int seat_count = 0;
            int[] seatsPerRow;
            InitializeHall(seatsPerRow, out hall);
            Console.WriteLine("--- STADIUM SEATING CHART ---");
            Console.WriteLine("\t\tSCREEN");
            for (int r = 0; r < hall.Length; r++)
            {
                for (int c = 0; c < hall[r].Length;c++)
                {
                    seat_count++;
                    string status = hall[r][c] == "" ? ".":"X";
                    Console.Write($"[ {seat_count}: {status} ]");
                }
            }
            Console.WriteLine(". = available, X = booked");
        }

        // TASK 1 - CheckSeatInput
        // The hall's rows do NOT all have the same length (row 0 has 4 seats, row 1
        // has 6, and so on), so you cannot just divide by a fixed number of columns
        // like you would with a normal 2D array.
        //
        // IMPORTANT: Do not use any break or return statements in this method.
        // Instead of exiting a loop or the method early, use boolean flags to
        // control your loops, and report the result back through the 'isValid'
        // out parameter.
        //
        // Complete this method so that it:
        //   1. Validates that 'input' is a whole number (use int.TryParse). Only do
        //      the rest of the work inside the resulting if-statement - do not
        //      return early if it fails.
        //   2. Works out the total number of seats in the hall by adding up the
        //      length of every row.
        //   3. Checks that the seat number is between 1 and the total number of
        //      seats, using an if-statement (not a return).
        //   4. Iterate through the rows to find which row the seat number falls
        //      into. Use a while loop with a boolean flag (e.g. 'located') as part
        //      of the loop condition, instead of using break to exit once the row
        //      is found. The row you land on is 'row', and (what's left - 1) is
        //      'col'.
        //   5. Once located, checks whether hall[row][col] is still available
        //      (an empty string ""). If every check has passed, set 'isValid' to
        //      true.
        static void CheckSeatInput(string input, string[][] hall, out int row, out int col, out bool isValid)
        {
            row = -1;
            col = -1;
            isValid = false;
            int totalSeats = 0;
            int seatspassed = 0;
            // TODO: complete this method (see instructions above)
            if (int.TryParse(Console.ReadLine(), out int SeatNumber))
            {
                for (int r = 0; r < hall.Length; r++)
                {
                    for (int c = 0; c < hall[r].Length; c++)
                    {
                        totalSeats += hall[r].Length;
                    }
                    if (SeatNumber >= 1 && SeatNumber <= totalSeats)
                    {
                        bool located = false;
                        while (!located)
                        {
                            if ((SeatNumber - seatspassed) <= hall[row].Length)
                            {
                                // row = row;
                                col = (SeatNumber - seatspassed) - 1;
                                located = true;
                            }
                            else
                            {
                                seatspassed += hall[row].Length;
                                row = row + 1;
                            }
                        }
                        if (hall[row][col] != "")
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                }
            }
        }
        // Places the given name into the seat at [row, col]. Assumes the seat has
        // already been validated using CheckSeatInput.
        static void Book(string[][] hall, int row, int col, string name)
        {
            DisplayHall(hall);

            Console.WriteLine("\n\nEnter the name of the person booking this seat: ");

            name = Console.ReadLine().Trim();
            CheckSeatInput("Enter the seat number you would like to book (0 to cancel): ", hall, out row, out col, out bool isValid);
            if (isValid)
            {
                hall[row][col] = name;
                Console.WriteLine("Seat booked successfully");
            }
            else
            {
                Console.WriteLine("Seat has already been booked");
            }
        }
        static void HandleBooking(string[][] hall)
        {
            int row = 0;
            int col = 0;
            string name = "";
            Book(hall, row, col, name);
        }
        // TASK 2 - CountAvailableSeats
        // IMPORTANT: Do not use any break or return statements in this method.
        // Report the result back through the 'count' out parameter instead of
        // returning it.
        //
        // Complete this method so that it:
        //   1. Loops through every row in the hall.
        //   2. Within each row, loops through every seat in that row (remember
        //      each row can be a different length).
        //   3. Each time a seat is found to be available (an empty string ""),
        //      adds 1 to 'count'.
        static void CountAvailableSeats(string[][] hall, out int count)
        {
            count = 0;
            // TODO: complete this method (see instructions above)
            for (int r = 0; r < hall.Length;r++)
            {
                for (int c = 0; c < hall[r].Length; c++)
                {
                    if (hall[r][c] == "")
                    {
                        count++;
                    }
                }
            }
        }
    }
}

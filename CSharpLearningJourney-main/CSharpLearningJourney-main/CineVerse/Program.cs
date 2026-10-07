// Name: [Your Name]
// Student Number: [Your Student Number]
// Practical: CSIS 1624 - Practical 3 (SOLUTION)
// Date: [Today's Date]

using System;

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
        // Every seat starts as "" (empty string) to show it is available. The result
        // is handed back through the 'hall' out parameter instead of a return
        // statement.
        static void InitializeHall(int[] seatsPerRow, out string[][] hall)
        {
            hall = new string[seatsPerRow.Length][];
            for (int r = 0; r < seatsPerRow.Length; r++)
            {
                hall[r] = new string[seatsPerRow[r]];
                for (int c = 0; c < hall[r].Length; c++)
                {
                    hall[r][c] = "";
                }
            }
        }

        static void DisplayHall(string[][] hall)
        {
            Console.WriteLine("\n--- STADIUM SEATING CHART ---");
            Console.WriteLine("             SCREEN             ");
            int seatNumber = 1;
            for (int r = 0; r < hall.Length; r++)
            {
                for (int c = 0; c < hall[r].Length; c++)
                {
                    string status = string.IsNullOrEmpty(hall[r][c]) ? "." : "X";
                    Console.Write($"[{seatNumber,2}:{status}] ");
                    seatNumber++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("(. = available, X = booked)");
        }

        // Converts a seat number into its row/col indexes and checks whether it is a
        // valid, available seat. The hall's rows do NOT all have the same length, so
        // the seat number has to be "walked" through each row's length to find which
        // row/col it lands on.
        //
        // Note: this method does not use any break or return statements. Instead of
        // exiting early, it uses boolean flags ('located' and 'isValid') to control
        // the loops and to report the result back through the out parameter.
        static void CheckSeatInput(string input, string[][] hall, out int row, out int col, out bool isValid)
        {
            row = -1;
            col = -1;
            isValid = false;

            int seatNumber;
            if (int.TryParse(input, out seatNumber))
            {
                int totalSeats = 0;
                for (int r = 0; r < hall.Length; r++)
                {
                    totalSeats += hall[r].Length;
                }

                if (seatNumber >= 1 && seatNumber <= totalSeats)
                {
                    int remaining = seatNumber;
                    int currentRow = 0;
                    bool located = false;

                    while (currentRow < hall.Length && !located)
                    {
                        if (remaining <= hall[currentRow].Length)
                        {
                            row = currentRow;
                            col = remaining - 1;
                            located = true;
                        }
                        else
                        {
                            remaining -= hall[currentRow].Length;
                        }
                        currentRow++;
                    }

                    if (located && string.IsNullOrEmpty(hall[row][col]))
                    {
                        isValid = true;
                    }
                }
            }
        }

        // Places the given name into the seat at [row, col]. Assumes the seat has
        // already been validated using CheckSeatInput.
        static void Book(string[][] hall, int row, int col, string name)
        {
            hall[row][col] = name;
        }

        static void HandleBooking(string[][] hall)
        {
            DisplayHall(hall);
            Console.Write("\nEnter the seat number you would like to book (0 to cancel): ");
            string input = Console.ReadLine();

            if (input != "0")
            {
                Console.Write("Enter the name of the person booking this seat: ");
                string name = Console.ReadLine();

                int row, col;
                bool isValid;
                CheckSeatInput(input, hall, out row, out col, out isValid);

                if (isValid)
                {
                    Book(hall, row, col, name);
                    Console.WriteLine($"\nSeat booked successfully for {name}!");
                }
                else
                {
                    Console.WriteLine("\nInvalid seat number, or that seat is already booked.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        // Loops through every row and every seat in that row, counting how many
        // seats are still available (""). The result is returned through the
        // 'count' out parameter instead of a return statement.
        static void CountAvailableSeats(string[][] hall, out int count)
        {
            count = 0;
            for (int r = 0; r < hall.Length; r++)
            {
                for (int c = 0; c < hall[r].Length; c++)
                {
                    if (string.IsNullOrEmpty(hall[r][c]))
                    {
                        count++;
                    }
                }
            }
        }
    }
}

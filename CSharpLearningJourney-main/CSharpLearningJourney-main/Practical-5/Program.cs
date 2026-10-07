using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ASCII_Art
{
    class Program
    {
        // Set to Practical 5 per the brief
        private static string StaticDirectory = @"T:/practical5";
        private static string[] files;

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                try
                {
                    Console.Clear();
                    // Get the directory to work in when the program starts
                    Console.Write($"Default directory is {StaticDirectory}\nEnter the directory path you would like to use or press enter to stick with default: ");
                    string sDir = Console.ReadLine();
                    if (sDir != "@") StaticDirectory = Regex.Unescape(sDir);

                    Console.Clear();
                    Console.WriteLine("\nChoose an option:");
                    Console.WriteLine("1. Read a text file");
                    Console.WriteLine("2. Create a text file");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                ReadFile();
                                break;
                            case 2:
                                CreateFile();
                                break;
                            case 3:
                                choice = -1;
                                break;
                            default:
                                Console.WriteLine("Invalid choice.Press any key to try again...");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number. \nPress any key to try again...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    Console.Write("Press any key to try again...");
                    Console.ReadKey();
                }
            } while (choice != -1);

        }


        private static void ReadFile()
        {
            try
            {
                // 1. Call GetTextFiles, return if fails
                if (!GetTextFiles(StaticDirectory)) return;

                // 2. Prompt user for file number
                Console.Write("Enter the number of the file to read: ");
                string input = Console.ReadLine();
                int fileNum;
                if (int.TryParse(input, out fileNum) && fileNum > 0 && fileNum <= files.Length)
                {
                    string selectedFile = files[fileNum - 1];
                    Console.Clear();
                    using (StreamReader sr = new StreamReader(selectedFile))
                    {
                        string content = sr.ReadToEnd();
                        Console.WriteLine($"--- Contents of {Path.GetFileName(selectedFile)} ---\n");
                        Console.WriteLine(content);
                    }
                    Console.WriteLine("\nPress any key to return to the menu...");
                }
                else
                {
                    Console.WriteLine("Invalid file number.");
                    Console.WriteLine("Press any key to try again...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                Console.Write("Press any key to try again...");
            }
            Console.ReadKey();
        }

        private static void CreateFile()
        {
            try
            {
                // Check if directory exists, create if not
                if (!Directory.Exists(StaticDirectory))
                {
                    Directory.CreateDirectory(StaticDirectory);
                }

                Console.Clear();
                Console.Write("Enter the new file name (include .txt): ");
                string fileName = Console.ReadLine();

                Console.Write("Enter the text you want to save in the file: ");
                string fileContent = Console.ReadLine();

                string filePath = Path.Combine(StaticDirectory, fileName);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(fileContent);
                }

                Console.WriteLine($"File '{fileName}' created successfully!");
                Console.WriteLine("Press any key to return to the menu...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the file: {ex.Message}");
                Console.Write("Press any key to try again...");
            }
            Console.ReadKey();
            
        }


        private static bool GetTextFiles(string directoryPath)
        {
            directoryPath = StaticDirectory;
            try
            {
                Console.Clear();
                if (Directory.Exists(directoryPath))
                {
                    int iCounter = 1;
                    files = Directory.GetFiles(directoryPath, "*.txt");
                    Console.WriteLine("Text files in the directory:");
                    foreach (string file in files)
                    {
                        Console.WriteLine($"{iCounter}. {Path.GetFileName(file)}");
                        iCounter++;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                    Console.Write("Press any key to try again...");
                    Console.ReadKey();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while listing files: {ex.Message}");
                Console.Write("Press any key to try again...");
                Console.ReadKey();
                return false;
            }
        }
    }
}

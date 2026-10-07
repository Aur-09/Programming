using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] students = new string[3][];

            students[0] = new string[] {"Ben", "Merry", "Dean"};
            students[1] = new string[] { "Pulane", "Peter", "Marriam", "Daniel"};
            students[2] = new string[] { "Maggie", "Gert"};

            Console.WriteLine("Best Performance in Computer Science");
            Console.WriteLine();
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Year {i+1} students:");
                Console.WriteLine("***********************");
                for(int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine(students[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

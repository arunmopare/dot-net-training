using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a program in C# Sharp to display the multiplication table of a given integer.
            int number;
            Console.WriteLine("Please Enter the Number that you want generate table for");
            number = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine($"Table for Number {number} is");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
            Console.ReadLine();

        }
    }
}

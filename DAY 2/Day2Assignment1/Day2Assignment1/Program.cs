using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string cont;
            do
            {
                int age = Convert.ToInt32(Console.ReadLine());
                switch (age >= 45)
                {
                    case true:
                        Console.WriteLine("You are eligible for vaccine");
                          break; 
                    case false:
                        Console.WriteLine("You are not eligible for vaccine");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                cont = Console.ReadLine();
            }
            while (cont.ToUpper() == "YES");
        }
    }
}

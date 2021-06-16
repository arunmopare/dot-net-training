using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assn2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How Many Numbers do you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;

            Console.WriteLine($"Please Enter {n} Numbers");
            for (int i = 0; i < n; i++) {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numbers You have Entered are ");
            for (int j = 0; j < n; j++)
            {
                sum = sum + a[j];
                Console.Write(" "+ Convert.ToString(a[j]));
            }
            Console.WriteLine($"\nAddition of {n} numbers is {sum}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            while (number != 999)
            {
                Console.WriteLine("Enter a number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number != 999)
                    {
                    sum = sum + number;
                }
            }
            Console.WriteLine("The sum of the numbers is {0}", sum);
            Console.ReadLine();
        }
    }
}

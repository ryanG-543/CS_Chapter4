using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number <= 50)
            {
                Console.WriteLine("{0}", number);
                number++;
            }
        }
    }
}

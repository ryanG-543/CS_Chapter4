using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 2;
            while (even <= 100)
            {
                Console.WriteLine("{0}", even);
                even+=2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            char vowel;
            const char a = 'a';
            const char A = 'A';
            const char e = 'e';
            const char E = 'E';
            const char i = 'i';
            const char I = 'I';
            const char o = 'o';
            const char O = 'O';
            const char U = 'U';
            const char u = 'u';
            Console.WriteLine("Enter a vowel");
            vowel = Convert.ToChar(Console.ReadLine());
            while ((vowel == a) || (vowel == A) || (vowel == E) || (vowel == e) || (vowel == I) || (vowel == i) || (vowel == O) || (vowel == o) || (vowel == U) || (vowel == u))
            {
                Console.WriteLine("Good");
            }
            Console.WriteLine("Not a vowel");
        }
    }
}

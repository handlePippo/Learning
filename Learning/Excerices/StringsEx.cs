using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercices
{
    public static class StringsEx
    {
        public static void Calculate()
        {
            Console.WriteLine("Inserisci una frase!");
            string input = Console.ReadLine();

            foreach(char el in input)
            {
                Console.WriteLine(el);
            }
        }
    }
}

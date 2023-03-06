using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerices
{
    public static class Basics
    {
        public static void Es3()
        {
            Console.WriteLine("Inserisci il primo numero");
            float firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero");
            float secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("la divisione e': " + (firstNumber / secondNumber));
        }
    }
}

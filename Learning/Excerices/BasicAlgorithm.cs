using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerices
{
    public static class BasicAlgorithm // Nome categoria
    {
        public static void Es1() // Numero esercizio
        {
            // Per questi esercizietti serve scrivere una classe

            Console.WriteLine("inserisci il primo numero");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("inserisci il secondo numero");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = firstNumber + secondNumber;

            if(firstNumber == secondNumber) result = result * 3;

            Console.WriteLine("il risultato e' " + result);
        }
    }
}

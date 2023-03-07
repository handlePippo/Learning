using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercices
{
    public static class FunctionEx
    {
        public static void Es9()
        {
            try {
                List<int> container = new List<int>();
                Console.WriteLine("Inserisci un numero!");
                string parseToInt = Console.ReadLine();
                int parsedNumber = int.Parse(parseToInt);

                for (int i = 1; i <= parsedNumber; i++)
                {
                    if (parsedNumber % i == 0)
                    {
                        container.Add(i);
                    }
                }

                if (container.Count > 2)
                {
                    Console.WriteLine("Il numero inserito non è primo");
                }
                else
                {
                    Console.WriteLine("Il numero inserito è primo");
                }

            } catch (Exception ex) {

                Console.Write("Carattere inserito non valido, riprova con un numero!");
                Es9();
            }

        }

        //////////////////////////////////////////////////////////////////////////////


        public static void Es11() {

            Console.WriteLine("Inserisci un numero!");
            string number = Console.ReadLine();
            int parsedNumber = int.Parse(number);
            int flag = 1;

            for (int i = 1; i < parsedNumber; i++)
            {
                flag = flag + flag * i;
            }
            Console.Write($"Il fattoriale di {parsedNumber} è {flag}!");
        }
    }
}

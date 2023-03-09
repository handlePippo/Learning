using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //definisco righe e altezza

            int altezza = 5; //perchè deve essere alta 5 righe, di conseguenza le righe dovranno essere 5
            int riga;
            int ast; //asterischi

            for (riga = 1; riga <= altezza; riga++)
            {
                //gestisco gli spazi

                for(int spazio = 1; spazio <= altezza - riga; spazio++)
                {
                    Console.Write(" ");
                }

                // gestisco gli asterischi 

                for( ast = 1; ast <= (riga * 2) - 1; ast++  )
                {
                    Console.Write("*");
                    for (int tronco = ast + 1 ) ;2

                }

                Console.Write("\n");
            }

        }
    }
}

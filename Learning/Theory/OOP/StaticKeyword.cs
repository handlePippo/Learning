using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOP
{
    public class StaticKeyword
    {
        // per rappresentare oggetti a singola entita'
        public static class God
        {
            public static int getAge()
            {
                return 0;
            }
        }

        public class Car
        {
            // propieta' statiche, in comune per l'insieme Car
            public static int Count = 0;
            public string Plate { get; }

            public Car(string plate)
            {
                Count++;
                Plate = plate;
            }

            // metodo statico
            public static string GetModel()
            {
                return "Ferrari";
            }
        }

    }
}

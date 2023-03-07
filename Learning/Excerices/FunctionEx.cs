using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercices
{
    public static class FunctionEx
    {
        public static int Es9(int input)
        {
            List<int> container = new List<int>();
            int item;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
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

            return input;
        }
    }
}

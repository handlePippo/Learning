

namespace Theory.OOP
{
    public class Syntax
    {
        // classe statica, Singleton
        public static class Util
        {
            private static int _count = 0;
            public static void Greet(string name)
            {
                _count++;
                Console.WriteLine("Ciao " + name + " hai salutato "+ _count + " volte" );
            }
        }

        public class Person
        {
            private static int _personCount = 0;

            // Costruttori
            public Person(string name, int age)
            {
                Name = name;
                Age = age;

                _personCount++;
            }

            public Person(string name, int age, string phone, string pin)
            {
                Name = name;
                Age = age;
                Phone = phone;
                Pin = pin;

                _personCount++;
            }


            public static Person FromName(string name)
            {
                return new Person(name, 0);
            }

            public static Person FromCF(string cf)
            {
                var person =  new Person("", 0);

                person.CF = cf;

                return person;
            }

            // Variabile

            public string Name = "Nome di default";
            public string CF;

            public int Age;
            public string Phone;

            // Porpieta'
            public string Pin { get; } = "1234";

            // Metodo
            public void Call()
            {
                Console.WriteLine("Sto chiamando " + Name + "...");
                Console.WriteLine("esistono " + _personCount + " persone");
            }
        }
    }
}

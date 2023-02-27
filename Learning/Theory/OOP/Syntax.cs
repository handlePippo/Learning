

namespace Theory.OOP
{
    public class Syntax
    {
        public class Person
        {

            // Costruttori
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Person(string name, int age, string phone, string pin)
            {
                Name = name;
                Age = age;
                Phone = phone;
                Pin = pin;
            }

            // Variabile

            public string Name = "Nome di default";
            public int Age;
            public string Phone;

            // Porpieta'
            public string Pin { get; } = "1234";

            // Metodo
            public void Call()
            {
                Console.WriteLine("Sto chiamando " + Name + "...");
            }
        }


    }
}

using System.Security.AccessControl;

namespace Exercises

{
    public class Persona
    {
        public string Name { get; set; }

        public Persona(string name)
        {
            this.Name = name;
        }

        public void Call()
        {
            Console.WriteLine("Il mio nome è" + Name);
        }

    }
}
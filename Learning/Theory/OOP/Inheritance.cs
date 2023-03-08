namespace Theory.OOP
{
    public class Inheritance
    {
        public abstract class Animal
        {
            public DateTime Birth { get; set; }
            public TimeSpan Age { 
                get 
                { 
                    return TimeSpan.FromSeconds((DateTime.Now - Birth).Seconds); 
                } 
            } 
        }

        public class Dog : Animal
        {
            public void Barks()
            {
                Console.WriteLine("Bau");
            }
        }

        public class Cat : Animal
        {
            public void Meows()
            {
                Console.WriteLine("Miao");
            }
        }

        public class Bat : Animal
        {

        }


    }
}

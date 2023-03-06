namespace Theory.OOP
{
    public class Inheritance
    {
        public class Animal
        {
            public DateTime Birth { get; set; }
            public TimeSpan Age => TimeSpan.FromTicks((DateTime.Now - Birth).Ticks);
        }


    }
}

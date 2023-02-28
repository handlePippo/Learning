namespace Excerices
{
    public class Persona {

        public int results;
        public int firstNumber;
        public int secondNumber;

        public int FirstNumber {
            get {
                return firstNumber;
            }
            set
            {
                firstNumber = value;
            }
        }

        public int SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
            }
        }

        public void Sum()
        {
            if (this.firstNumber == this.secondNumber)
            {
                results = (this.firstNumber + this.secondNumber) * 3;
            }
            else
            {
                results = this.firstNumber + this.secondNumber;
            }

            Console.WriteLine("La somma è " + results);
        }


        public Persona() { }
    }
}
namespace Excerices
{
    public class Persona {

        private int _number;
        public const int N = 51;
        public int result;

        public int Number { 
            get
            { 
                return _number;
            } 
            set 
            { 
                _number = value;
            } 
        }

        public void Check()
        {
            if(_number <= N)
            {
                result = N - _number;
            }
            else
            {
                result = (_number - N) * 3;
            }

            Console.WriteLine(result);
        }

    }
}
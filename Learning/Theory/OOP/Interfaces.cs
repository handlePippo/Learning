using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory.OOP
{
    public class Interfaces
    {
        public interface IPhoneRepository
        {
            List<IPhone> GetAllPhones();
        }

        public class InMemoryPhoneRepository : IPhoneRepository
        {
            List<IPhone> phones = new List<IPhone>() 
            {
                new Phone(), new Phone()  
            };

            public List<IPhone> GetAllPhones()
            {
                return phones;
            }
        }

        public class DbPhoneRepository : IPhoneRepository
        {
            public List<IPhone> GetAllPhones()
            {
                throw new NotImplementedException();
            }
        }

        public interface IPhone
        {
            public string Number { get; }
            public void Call(string number);
        }

        public class Phone : IPhone
        {
            public string Number { get; set; }
            public void Call(string number)
            {
                Console.WriteLine("calling " + number);
            }

            public void Charge()
            {

            }
        }



    }
}

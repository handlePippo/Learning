namespace Excercices
{
    public class ExInterfaces
    {
        #region es12.1
        public interface ITicket
        {
            public void Stamp();
        }

        public class SingleTicket : ITicket
        {
            public static bool Limit { get; set; } = true;
            public void Stamp()
            {

                if (!Limit)
                {
                    Console.WriteLine("Biglietto già stampato!");
                    return;
                }

                Console.WriteLine("Biglietto stampato.");
                Limit = false;
            }
        }
        public class TicketBooklet : ITicket
        {
            public int Counter { get; set; } = 9;
            public void Stamp()
            {
                if (Counter == 0)
                {
                    Console.WriteLine("Biglietti esauriti");
                    return;
                }

                Console.WriteLine($"Biglietto stampato! Biglietti rimanenti {Counter}");
                Counter--;
            }
        }
        public class Inspector 
        {
            public void GetTickets(List<ITicket> tickets)
            {

                foreach (var el in tickets)
                {
                    Console.WriteLine(tickets);
                }
            }            
        }
        #endregion

        #region es12.2

        public class Person
        {
            public string Name { get;  set; }
            public List<ITicket> Ticket { get;  set; }

            public Person(string pName, List<ITicket> pTicket )
            {
                Name = pName;
                Ticket = pTicket;
            }
        }

        public class Bus
        {
            public int Number { get; private set; }
            public List<Person> Travellers { get; private set; }
        }

        #endregion
    }
}

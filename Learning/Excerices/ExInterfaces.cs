namespace Excercices
{
    public class ExInterfaces
    {
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

                foreach (ITicket ticket in tickets)
                {
                    Console.WriteLine(ticket.ToString());
                }
            }            
        }
    }
}

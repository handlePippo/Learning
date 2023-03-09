using Excercices;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExInterfaces.SingleTicket singleTicket = new ExInterfaces.SingleTicket();

            ExInterfaces.TicketBooklet ticketBooklet = new ExInterfaces.TicketBooklet();

            ExInterfaces.Inspector inspector = new ExInterfaces.Inspector();

            singleTicket.Stamp();
            singleTicket.Stamp();
            singleTicket.Stamp();

            ticketBooklet.Stamp();
            ticketBooklet.Stamp();

            List<ExInterfaces.ITicket> tickets = new List<ExInterfaces.ITicket>()
        {
            new ExInterfaces.SingleTicket(),
            new ExInterfaces.SingleTicket(),
            new ExInterfaces.SingleTicket(),
            new ExInterfaces.TicketBooklet(),
            new ExInterfaces.TicketBooklet(),
            new ExInterfaces.TicketBooklet(),
            new ExInterfaces.TicketBooklet(),
            new ExInterfaces.TicketBooklet(),
        };

            inspector.GetTickets(tickets);
        }

    }

}

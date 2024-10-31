using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class TicketsServicies
    {
        static List<Ticket> dataTickets = new List<Ticket>();
        //private static int count = 0;
        public List<Ticket> Get()
        {
            return dataTickets;
        }
        public Ticket GetById(int id)
        {
            return dataTickets.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Ticket t)
        {
            dataTickets.Add(new Ticket(t));
            return true;
        }
        public ActionResult<bool> Put(int id, Ticket t)
        {
            for (int i = 0; i < dataTickets.Count; i++)
            {
                if (id == dataTickets[i].Id)
                {
                    dataTickets[i] = new Ticket(id, t);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataTickets.Remove(dataTickets.FirstOrDefault(x => x.Id == id));

        }
    }
}

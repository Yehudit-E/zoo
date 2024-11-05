using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class TicketsServicies
    {
        static List<Ticket> dataTickets = DataManager.dataManager.dataTickets;
        //private static int count = 0;
        public List<Ticket> Get()
        {
            return dataTickets;
        }
        public Ticket GetById(int id)
        {
            return dataTickets.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Ticket t)
        {
            dataTickets.Add(new Ticket(t));/////
            return true;
        }
        public bool Update(int id, Ticket t)
        {
            int index = dataTickets.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataTickets[index] = new Ticket(id, t);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataTickets.Remove(dataTickets.FirstOrDefault(x => x.Id == id));

        }
    }
}

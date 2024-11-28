using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class TicketsRepository : IRepository<Ticket>
    {
        private readonly DataContext _dataContext;

        public TicketsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Ticket> Get()
        {
            return _dataContext.dataTickets;
        }
        public Ticket GetById(int id)
        {
            return _dataContext.dataTickets.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Ticket item)
        {
            _dataContext.dataTickets.Add(new Ticket(item));
            return _dataContext.SaveTickets();
        }
        public bool Update(int id, Ticket item)
        {
            int index = _dataContext.dataTickets.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataTickets[index] = new Ticket(id, item);
                return _dataContext.SaveTickets();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataTickets.Remove(_dataContext.dataTickets.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveTickets();
            return false;
        }
    }
}

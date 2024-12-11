using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface ITicketsService
    {
        public List<Ticket> Get();
        public Ticket? GetById(int id);
        public Ticket Add(Ticket item);
        public Ticket Update(int id, Ticket item);
        public bool DeleteById(int id);
    }
}

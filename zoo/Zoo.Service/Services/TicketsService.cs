using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

namespace Zoo.Service.Services
{
    public class TicketsService:ITicketsService
    {
        readonly IRepository<Ticket> _iRepository;
        public TicketsService(IRepository<Ticket> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Ticket> Get()
        {
            return _iRepository.Get();
        }
        public Ticket? GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public Ticket Add(Ticket item)
        {
            return _iRepository.Add(item);
        }
        public Ticket Update(int id, Ticket item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }
    }
}

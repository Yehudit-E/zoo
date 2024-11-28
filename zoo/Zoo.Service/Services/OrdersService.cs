using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Service.Services
{
    public class OrdersService: IService<Order>
    {
        readonly IRepository<Order> _iRepository;
        public OrdersService(IRepository<Order> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Order> Get()
        {
            return _iRepository.Get();
        }
        public Order GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public bool Add(Order item)
        {
            return _iRepository.Add(item);
        }
        public bool Update(int id, Order item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface IOrdersService
    {
        public List<Order> Get();
        public Order? GetById(int id);
        public Order Add(Order item);
        public Order Update(int id, Order item);
        public bool DeleteById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class OrdersRepository:IRepository<Order>
    {
        private readonly DataContext _dataContext;
        public OrdersRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> Get()
        {
            return _dataContext.dataOrders;
        }
        public Order GetById(int id)
        {
            return _dataContext.dataOrders.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Order item)
        {
            _dataContext.dataOrders.Add(new Order(item));
            return _dataContext.SaveOrders();
        }
        public bool Update(int id, Order item)
        {
            int index = _dataContext.dataOrders.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataOrders[index] = new Order(id, item);
                return _dataContext.SaveOrders();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataOrders.Remove(_dataContext.dataOrders.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveOrders();
            return false;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class OrdersServicies
    {
        static List<Order> dataOrders = DataManager.dataManager.dataOrders;
        //private static int count = 0;
        public List<Order> Get()
        {
            return dataOrders;
        }
        public Order GetById(int id)
        {
            return dataOrders.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Order o)
        {
            dataOrders.Add(new Order(o));/////
            return true;
        }
        public bool Update(int id, Order o)
        {
            int index = dataOrders.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataOrders[index] = new Order(id, o);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataOrders.Remove(dataOrders.FirstOrDefault(x => x.Id == id));

        }
    }
}

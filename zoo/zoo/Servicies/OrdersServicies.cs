using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class OrdersServicies
    {
        static List<Order> dataOrders = new List<Order>();
        //private static int count = 0;
        public List<Order> Get()
        {
            return dataOrders;
        }
        public Order GetById(int id)
        {
            return dataOrders.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Order o)
        {
            dataOrders.Add(new Order(o));
            return true;
        }
        public ActionResult<bool> Put(int id, Order o)
        {
            for (int i = 0; i < dataOrders.Count; i++)
            {
                if (id == dataOrders[i].Id)
                {
                    dataOrders[i] = new Order(id, o);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataOrders.Remove(dataOrders.FirstOrDefault(x => x.Id == id));

        }
    }
}

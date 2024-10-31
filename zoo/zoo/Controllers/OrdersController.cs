using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        OrdersServicies ordersServicies = new OrdersServicies();
        // GET: api/<OrdersController>
        [HttpGet]
        public List<Order> Get()
        {
            return ordersServicies.Get();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return ordersServicies.GetById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            return ordersServicies.Post(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Order order)
        {
            return ordersServicies.Put(id, order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return ordersServicies.Delete(id);
        }
    }
}

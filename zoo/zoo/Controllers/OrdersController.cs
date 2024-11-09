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
        public ActionResult<IEnumerable<Order>> Get()
        {
            return ordersServicies.Get();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            Order order = ordersServicies.GetById(id);
            if (order == null)
                return NotFound();
            return order;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            return ordersServicies.Add(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Order order)
        {
            return ordersServicies.Update(id, order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return ordersServicies.Delete(id);
        }
    }
}

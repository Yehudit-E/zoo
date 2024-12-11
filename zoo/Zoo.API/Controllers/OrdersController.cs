using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IOrdersService _iOrdersService;
        public OrdersController(IOrdersService iService)
        {
            _iOrdersService = iService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return _iOrdersService.Get();
        }
        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            Order o = _iOrdersService.GetById(id);
            if (o == null)
                return NotFound();
            return o;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult<Order> Post([FromBody] Order o)
        {
            return _iOrdersService.Add(o);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult<Order> Put(int id, [FromBody] Order o)
        {
            return _iOrdersService.Update(id, o);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iOrdersService.DeleteById(id);
        }
    }
}

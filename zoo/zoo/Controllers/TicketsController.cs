using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        TicketsServicies ticketsServicies = new TicketsServicies();
        // GET: api/<TicketsController>
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return ticketsServicies.Get();
        }

        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            Ticket ticket = ticketsServicies.GetById(id);
            if (ticket == null)
                return NotFound();
            return ticket;
        }

        // POST api/<TicketsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Ticket ticket)
        {
            return ticketsServicies.Add(ticket);
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Ticket ticket)
        {
            return ticketsServicies.Update(id, ticket);
        }

        // DELETE api/<TicketsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return ticketsServicies.Delete(id);
        }
    }
}

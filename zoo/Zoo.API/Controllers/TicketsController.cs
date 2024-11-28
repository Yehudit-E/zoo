using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        readonly IService<Ticket> _iService;
        public TicketsController(IService<Ticket> iService)
        {
            _iService = iService;
        }
        // GET: api/<TicketsController>
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return _iService.Get();
        }
        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            Ticket t = _iService.GetById(id);
            if (t == null)
                return NotFound();
            return t;
        }

        // POST api/<TicketsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Ticket t)
        {
            return _iService.Add(t);
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Ticket t)
        {
            return _iService.Update(id, t);
        }

        // DELETE api/<TicketsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.DeleteById(id);
        }
    }
}

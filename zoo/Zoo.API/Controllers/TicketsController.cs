using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        readonly ITicketsService _iTicketsService
            ;
        public TicketsController(ITicketsService iService)
        {
            _iTicketsService = iService;
        }
        // GET: api/<TicketsController>
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            return _iTicketsService.Get();
        }
        // GET api/<TicketsController>/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            Ticket t = _iTicketsService.GetById(id);
            if (t == null)
                return NotFound();
            return t;
        }

        // POST api/<TicketsController>
        [HttpPost]
        public ActionResult<Ticket> Post([FromBody] Ticket t)
        {
            return _iTicketsService.Add(t);
        }

        // PUT api/<TicketsController>/5
        [HttpPut("{id}")]
        public ActionResult<Ticket> Put(int id, [FromBody] Ticket t)
        {
            return _iTicketsService.Update(id, t);
        }

        // DELETE api/<TicketsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iTicketsService.DeleteById(id);
        }
    }
}

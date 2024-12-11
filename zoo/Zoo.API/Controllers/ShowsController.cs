using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        readonly IShowsService _iShowsService;
        public ShowsController(IShowsService iService)
        {
            _iShowsService = iService;
        }
        // GET: api/<ShowsController>
        [HttpGet]
        public ActionResult<IEnumerable<Show>> Get()
        {
            return _iShowsService.Get();
        }
        // GET api/<ShowsController>/5
        [HttpGet("{id}")]
        public ActionResult<Show> Get(int id)
        {
            Show s = _iShowsService.GetById(id);
            if (s == null)
                return NotFound();
            return s;
        }

        // POST api/<ShowsController>
        [HttpPost]
        public ActionResult<Show> Post([FromBody] Show s)
        {
            return _iShowsService.Add(s);
        }

        // PUT api/<ShowsController>/5
        [HttpPut("{id}")]
        public ActionResult<Show> Put(int id, [FromBody] Show s)
        {
            return _iShowsService.Update(id, s);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iShowsService.DeleteById(id);
        }
    }
}

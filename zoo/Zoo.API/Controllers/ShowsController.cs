using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        readonly IService<Show> _iService;
        public ShowsController(IService<Show> iService)
        {
            _iService = iService;
        }
        // GET: api/<ShowsController>
        [HttpGet]
        public ActionResult<IEnumerable<Show>> Get()
        {
            return _iService.Get();
        }
        // GET api/<ShowsController>/5
        [HttpGet("{id}")]
        public ActionResult<Show> Get(int id)
        {
            Show s = _iService.GetById(id);
            if (s == null)
                return NotFound();
            return s;
        }

        // POST api/<ShowsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Show s)
        {
            return _iService.Add(s);
        }

        // PUT api/<ShowsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Show s)
        {
            return _iService.Update(id, s);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.DeleteById(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        ShowsServicies showsServicies = new ShowsServicies();
        // GET: api/<ShowsController>
        [HttpGet]
        public List<Show> Get()
        {
            return showsServicies.Get();
        }

        // GET api/<ShowsController>/5
        [HttpGet("{id}")]
        public Show Get(int id)
        {
            return showsServicies.GetById(id);
        }

        // POST api/<ShowsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Show show)
        {
            return showsServicies.Post(show);
        }

        // PUT api/<ShowsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Show show)
        {
            return showsServicies.Put(id, show);
        }

        // DELETE api/<ShowsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return showsServicies.Delete(id);
        }
    }
}

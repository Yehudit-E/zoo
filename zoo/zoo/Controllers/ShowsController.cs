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
        public ActionResult<IEnumerable<Show>> Get()
        {
            return showsServicies.Get();
        }

        // GET api/<ShowsController>/5
        [HttpGet("{id}")]
        public ActionResult<Show> Get(int id)
        {
            Show show = showsServicies.GetById(id);
            if (show == null)
                return NotFound();
            return show;
        }

        // POST api/<ShowsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Show show)
        {
            return showsServicies.Add(show);
        }

        // PUT api/<ShowsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Show show)
        {
            return showsServicies.update(id, show);
        }

        // DELETE api/<ShowsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return showsServicies.Delete(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        AnimalsServicies animalsServicies=new AnimalsServicies();
        // GET: api/<AnimalsController>
        [HttpGet]
        public List<Animal> Get()
        {
            return animalsServicies.Get();
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return animalsServicies.GetById(id);
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Animal animal)
        {
            return animalsServicies.Post(animal);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Animal animal)
        {
            return animalsServicies.Put(id, animal);
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return animalsServicies.Delete(id);
        }
    }
}

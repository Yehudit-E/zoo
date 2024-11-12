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
        private readonly AnimalsServicies animalsServicies;
        public AnimalsController(AnimalsServicies a)
        {
            animalsServicies = a;
        }
        // GET: api/<AnimalsController>
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return animalsServicies.Get();
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            Animal animal = animalsServicies.GetById(id);
            if (animal == null)
                return NotFound();
            return animal;
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Animal animal)
        {
            return animalsServicies.Add(animal);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Animal animal)
        {
            return animalsServicies.Update(id, animal);
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return animalsServicies.Delete(id);
        }
    }
}

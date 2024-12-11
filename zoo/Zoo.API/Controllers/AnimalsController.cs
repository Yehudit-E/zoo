using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Interfaces;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        readonly IAnimalsService _iAnimalsService;
        public AnimalsController(IAnimalsService iService)
        {
            _iAnimalsService = iService;
        }
        // GET: api/<AnimalssController>
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _iAnimalsService.Get();
        }       
        // GET api/<AnimalssController>/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            Animal a = _iAnimalsService.GetById(id);
            if (a == null)
                return NotFound();
            return a;
        }

        // POST api/<AnimalssController>
        [HttpPost]
        public ActionResult<Animal> Post([FromBody] Animal a)
        {
            Animal animal = _iAnimalsService.Add(a);
            if (animal == null)
                return NotFound();
            return animal;
        }

        // PUT api/<AnimalssController>/5
        [HttpPut("{id}")]
        public ActionResult<Animal> Put(int id, [FromBody] Animal a)
        {        
            Animal animal = _iAnimalsService.Update(id, a);
            if (animal == null)
                return NotFound();
            return animal;
        }

        // DELETE api/<AnimalssController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iAnimalsService.DeleteById(id);
        }
    }
}

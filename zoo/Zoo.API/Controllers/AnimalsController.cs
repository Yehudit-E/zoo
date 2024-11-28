using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Interfaces;
using Zoo.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        readonly IService<Animal>_iService;
        public AnimalsController(IService<Animal> iService)
        {
            _iService = iService;
        }
        // GET: api/<AnimalssController>
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _iService.Get();
        }       
        // GET api/<AnimalssController>/5
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            Animal a = _iService.GetById(id);
            if (a == null)
                return NotFound();
            return a;
        }

        // POST api/<AnimalssController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Animal a)
        {
            return _iService.Add(a);
        }

        // PUT api/<AnimalssController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Animal a)
        {
            return _iService.Update(id, a);
        }

        // DELETE api/<AnimalssController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.DeleteById(id);
        }
    }
}

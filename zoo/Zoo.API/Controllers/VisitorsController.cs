 using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        readonly IService<Visitor> _iService;
        public VisitorsController(IService<Visitor> iService)
        {
            _iService = iService;
        }
        // GET: api/<VisitorsController>
        [HttpGet]
        public ActionResult<IEnumerable<Visitor>> Get()
        {
            return _iService.Get();
        }
        // GET api/<VisitorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Visitor> Get(int id)
        {
            Visitor v = _iService.GetById(id);
            if (v == null)
                return NotFound();
            return v;
        }

        // POST api/<VisitorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Visitor v)
        {
            return _iService.Add(v);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Visitor v)
        {
            return _iService.Update(id, v);
        }

        // DELETE api/<VisitorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.DeleteById(id);
        }
    }
}

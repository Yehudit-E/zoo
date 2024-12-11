 using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        readonly IVisitorsService _iVisitorsService;
        public VisitorsController(IVisitorsService iService)
        {
            _iVisitorsService = iService;
        }
        // GET: api/<VisitorsController>
        [HttpGet]
        public ActionResult<IEnumerable<Visitor>> Get()
        {
            return _iVisitorsService.Get();
        }
        // GET api/<VisitorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Visitor> Get(int id)
        {
            Visitor v = _iVisitorsService.GetById(id);
            if (v == null)
                return NotFound();
            return v;
        }

        // POST api/<VisitorsController>
        [HttpPost]
        public ActionResult<Visitor> Post([FromBody] Visitor v)
        {
            return _iVisitorsService.Add(v);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<Visitor> Put(int id, [FromBody] Visitor v)
        {
            return _iVisitorsService.Update(id, v);
        }

        // DELETE api/<VisitorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iVisitorsService.DeleteById(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IService<Employee> _iService;
        public EmployeesController(IService<Employee> iService)
        {
            _iService = iService;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _iService.Get();
        }
        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee e = _iService.GetById(id);
            if (e == null)
                return NotFound();
            return e;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee e)
        {
            return _iService.Add(e);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Employee e)
        {
            return _iService.Update(id, e);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.DeleteById(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zoo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IEmployeesService _iEmployeesService;
        public EmployeesController(IEmployeesService iService)
        {
            _iEmployeesService = iService;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _iEmployeesService.Get();
        }
        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee e = _iEmployeesService.GetById(id);
            if (e == null)
                return NotFound();
            return e;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee e)
        {
            return _iEmployeesService.Add(e);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee e)
        {
            return _iEmployeesService.Update(id, e);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iEmployeesService.DeleteById(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeesServicies employeesServicies = new EmployeesServicies();
        // GET: api/<employeesController>
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return employeesServicies.Get();
        }

        // GET api/<employeesController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee employee = employeesServicies.GetById(id);
            if (employee == null)
                return NotFound();
            return employee;
        }

        // POST api/<employeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee employee)
        {
            return employeesServicies.Add(employee);
        }

        // PUT api/<employeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Employee employee)
        {
            return employeesServicies.Update(id, employee);
        }

        // DELETE api/<employeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return employeesServicies.Delete(id);
        }
    }
}

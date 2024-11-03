using blood_donations.Entities;
using blood_donations.Servies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        
        EmployeeService employee = new EmployeeService();
        [HttpGet]

        public IEnumerable<Employee> Get()
        {
            return employee.GetServies();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(string id)
        {
            return employee.GetServiesById(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee value)
        {
            return employee.PostServies(value);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id,[FromBody] Employee value)
        {
            return employee.PutServies(id,value);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            return employee.DeleteServies(id);
        }
    }
}

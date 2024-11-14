using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
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

        public ActionResult<List<Employee>> Get()
        {
            return Ok(employee.GetServies());
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult< Employee> Get(int id)
        {
            Employee result = employee.GetServiesById(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee value)
        {
            return employee.PostServies(value);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] Employee value)
        {
            return employee.PutServies(id,value);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return employee.DeleteServies(id);
        }
    }
}

using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public PatientServies patient { get; set; }
        // GET: api/<DonorsController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patient.GetServies();
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public Patient Get(string id)
        {
            return patient.GetServiesById(id);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Patient value)
        {
            return patient.PostServies(value);
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id,[FromBody] Patient value)
        {
            return patient.PutServies(id,value);
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            return patient.DeleteServies(id);
        }
    }
}

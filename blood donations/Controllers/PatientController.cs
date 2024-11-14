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
        public ActionResult<List<Patient>> Get()
        {
            return Ok(patient.GetServies());
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Patient> Get(int id)
        {
            Patient result = patient.GetServiesById(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Patient value)
        {
            return patient.PostServies(value);
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] Patient value)
        {
            return patient.PutServies(id,value);
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return patient.DeleteServies(id);
        }
    }
}

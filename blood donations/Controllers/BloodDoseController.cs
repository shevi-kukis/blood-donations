using blood_donations.Entities;
using blood_donations.Servies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodDoseController : ControllerBase
    {
        public BloodDoseService dose { get; set; }
        // GET: api/<BloodDoseController>


        [HttpGet]

        public ActionResult<List<BloodDose>> Get()
        {
            return Ok(dose.GetServies());
        }

        // GET api/<BloodDoseController>/5
        [HttpGet("{id}")]
       
        public ActionResult<BloodDose> Get(int id)
        {
            BloodDose result = dose.GetByIdService(id);
            if (result == null) 
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<BloodDoseController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] BloodDose value)
        {
            return Ok(dose.PostServies(value)) ;
        }

        // PUT api/<BloodDoseController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put( int id,[FromBody] BloodDose value)
        {
            return dose.PutServies(id, value);
        }

        // DELETE api/<BloodDoseController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
          return dose.DeleteServies(id) ;
        }
    }
}

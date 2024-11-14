using blood_donations.Entities;
using blood_donations.Servies;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompatibilityCheckController : ControllerBase
    {
        public CompatibilityCheckServies check { get; set; }

        // GET: api/<CompatibilityCheckController>
        [HttpGet]
        public ActionResult<List<CompatibilityCheck>> Get()
        {
            return Ok(check.GetServies());
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<CompatibilityCheck> Get(int id)
        {
            CompatibilityCheck result = check.GetByIdServies(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CompatibilityCheck c)
        {
            return check.PostServies(c);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,CompatibilityCheck c)
        {
            return check.PutServies(id, c);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return check.DeleteServies(id);
        }
    }
}

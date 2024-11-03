using blood_donations.Servies;
using blood_donations.Subjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        public DonorServies donor { get; set; }
        // GET: api/<DonorsController>
        [HttpGet]
        public IEnumerable<Donor> Get()
        {
            return donor.GetServies();
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public Donor Get(string id)
        {
            return donor.GetServiesById(id);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Donor value)
        {
           return  donor.PostServies(value);
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id, [FromBody] Donor value)
        {
          return  donor.PutServies(id, value);
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
          return  donor.DeleteServies(id);
        }
    }
}

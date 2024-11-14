using blood_donations.Entities;
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
        readonly DonorService _donorService;
        private object result;

        public DonorsController(DonorService donorService)
        {
           _donorService = donorService;
        }
          
        // GET: api/<DonorsController>
        [HttpGet]
        public ActionResult<List<Donor>> Get()
        {
           List<Donor>result=_donorService.GetServies();
            return result;
        }
        // GET api/<DonorsController>/5
        [HttpGet("{id}")]
        public ActionResult<Donor> Get(int id)
        {
           
            Donor result = _donorService.GetServiesById(id);
            if (result ==  null)
            { return NotFound(); }
            return Ok(result);
        }
        // POST api/<DonorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Donor value)
        {
           Donor result=_donorService.GetServiesById(value.Id);
            if (result != null)
                return BadRequest(false);
            var res = _donorService.PostServies(value);
            if (res == false)
                return BadRequest(false);
            return true;
        }

        // PUT api/<DonorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Donor value)
        {
            var res = _donorService.PutServies(id,value);
            if (res == false)
                return BadRequest(false);
            return true;
        }

        // DELETE api/<DonorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
          return  _donorService.DeleteServies(id);
        }
    }
}

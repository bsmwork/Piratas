using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Piratas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ficha : ControllerBase
    {
        // GET: api/<Ficha>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Ficha>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Ficha>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Ficha>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Ficha>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

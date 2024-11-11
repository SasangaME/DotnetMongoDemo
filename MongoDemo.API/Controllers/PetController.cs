using Microsoft.AspNetCore.Mvc;
using MongoDemo.Core.Models.Entities;
using MongoDemo.Db.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController(IPetRepository petRepository) : ControllerBase
    {
        // GET: api/<PetController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> Get()
        {
            var pets = await petRepository.GetAll();
            return Ok(pets);
        }

        // GET api/<PetController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> Get(string id)
        {
            var pet = await petRepository.GetById(id);
            return Ok(pet);
        }

        // POST api/<PetController>
        [HttpPost]
        public async Task<ActionResult<Pet>> Post([FromBody] Pet request)
        {
            var response = await petRepository.Create(request);
            return Ok(response);
        }

        // PUT api/<PetController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

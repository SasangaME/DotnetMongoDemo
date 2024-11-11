using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace MongoDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController(/*MongoContext mongoContext*/) : ControllerBase
    {
        // GET: api/<HelloController>
        [HttpGet]
        public async Task<string> Get()
        {
            //var items = await mongoContext.Items.Find(item => true).ToListAsync();
            //if (!items.Any())
            //{
            //    var item = new Item
            //    {
            //        Name = "demo item",
            //        Description = "demo description"
            //    };
            //    await mongoContext.Items.InsertOneAsync(item);
            //}
            return await Task.FromResult("Hello World!");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TestAPI.Domain;
using TestAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<ICategoryService>
    {
        public CategoriesController(ICategoryService service) : base(service)
        {
        }

        // GET: api/<Categories>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return Service.Get();
        }

        // GET api/<Categories>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return Service.Get(id);
        }

        // POST api/<Categories>
        [HttpPost]
        public void Post([FromBody] Category model)
        {
            Service.Create(model);
        }

        // PUT api/<Categories>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category model)
        {
            Service.Update(id, model);
        }

        // DELETE api/<Categories>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Service.Delete(id);
        }
    }
}

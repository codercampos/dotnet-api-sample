using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;
using TestAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : BaseController<IGameService>
    {
        public GamesController(IGameService service) : base(service)
        {
        }

        // GET: api/<GamesController>
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return Service.Get();
        }

        // GET api/<GamesController>/5
        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return Service.Get(id);
        }

        // POST api/<GamesController>
        [HttpPost]
        public void Post([FromBody] GameModel model)
        {
            Game game = new Game
            {
                Name = model.Name,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                CategoryId = model.CategoryId
            };
            Service.Create(game);
        }

        // PUT api/<GamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game model)
        {
            Service.Update(id, model);
        }

        // DELETE api/<GamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Service.Delete(id);
        }
    }
}

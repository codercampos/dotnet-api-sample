using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TestAPI.Domain;

namespace TestAPI.Services
{
    public class GameService : BaseService, IGameService
    {
        public GameService(DatabaseContext context) : base(context)
        {
        }

        public void Create(Game entity)
        {
            Context.Games.Add(entity);

            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Game entity = Context.Games.FirstOrDefault(x => x.Id == id);

            if (entity == null) return;

            Context.Games.Remove(entity);

            Context.SaveChanges();
        }

        public List<Game> Get()
        {
            return Context.Games
                .Include(x => x.Category)
                .ToList();
        }

        public Game Get(int id)
        {
            return Context.Games.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, Game game)
        {
            Game entity = Context.Games.FirstOrDefault(x => x.Id == id);

            // TODO Define response later when entity does not exists
            if (entity == null) return;

            entity.Name = game.Name;
            entity.Description = game.Description;

            Context.Update(entity);
            Context.SaveChanges();
        }
    }
}

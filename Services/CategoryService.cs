using TestAPI.Domain;

namespace TestAPI.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(DatabaseContext context) : base(context)
        {
        }

        public List<Category> Get()
        {
            return Context.Categories.ToList();
        }

        public Category Get(int id)
        {
            return Context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Category category)
        {
            Context.Categories.Add(category);

            Context.SaveChanges();
        }

        public void Update(int id, Category category)
        {
            Category entity = Context.Categories.FirstOrDefault(x => x.Id == id);

            // TODO Define response later when entity does not exists
            if (entity == null) return;

            entity.Name = category.Name;
            entity.Description = category.Description;

            Context.Update(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category entity = Context.Categories.FirstOrDefault(x => x.Id == id);

            if (entity == null) return;

            Context.Categories.Remove(entity);

            Context.SaveChanges();
        }
    }
}

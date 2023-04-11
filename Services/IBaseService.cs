namespace TestAPI.Services
{
    public interface IBaseService<T>
    {
        List<T> Get();
        T Get(int id);
        void Create(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}

using Microsoft.EntityFrameworkCore;

namespace TestAPI.Services
{
    public class BaseService
    {
        protected readonly DatabaseContext Context;
        public BaseService(DatabaseContext context)
        {
            Context = context;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    public class BaseController<T> : ControllerBase
    {
        protected readonly T Service;
        public BaseController(T service)
        {
            Service = service;
        }
    }
}

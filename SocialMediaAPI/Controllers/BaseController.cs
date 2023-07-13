using Microsoft.AspNetCore.Mvc;

namespace SocialMediaAPI.Controllers
{
    public abstract class BaseController<TService> : ControllerBase
    {
        protected readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }
    }
}

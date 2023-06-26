using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ServicesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var result = _serviceManager.T_GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceManager.T_Insert(service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var resut = _serviceManager.T_GetById(id);
            _serviceManager.T_Delete(resut);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceManager.T_Update(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var result = _serviceManager.T_GetById(id);
            return Ok(result);
        }
    }
}

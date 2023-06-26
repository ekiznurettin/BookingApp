using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeManager _subscribeManager;

        public SubscribesController(ISubscribeManager subscribeManager)
        {
            _subscribeManager = subscribeManager;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var result = _subscribeManager.T_GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeManager.T_Insert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var resut = _subscribeManager.T_GetById(id);
            _subscribeManager.T_Delete(resut);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeManager.T_Update(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var result = _subscribeManager.T_GetById(id);
            return Ok(result);
        }
    }
}

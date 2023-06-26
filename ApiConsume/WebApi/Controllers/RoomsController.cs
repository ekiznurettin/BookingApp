using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomManager _roomManager;

        public RoomsController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var result = _roomManager.T_GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomManager.T_Insert(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var resut = _roomManager.T_GetById(id);
            _roomManager.T_Delete(resut);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomManager.T_Update(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var result = _roomManager.T_GetById(id);
            return Ok(result);
        }
    }
}

using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffManager _staffManager;

        public StaffsController(IStaffManager staffManager)
        {
            _staffManager = staffManager;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var result = _staffManager.T_GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffManager.T_Insert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var resut = _staffManager.T_GetById(id);
            _staffManager.T_Delete(resut);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffManager.T_Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var result = _staffManager.T_GetById(id);
            return Ok(result);
        }
    }
}

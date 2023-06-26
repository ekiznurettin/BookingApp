using Busines.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialManager _testimonialManager;

        public TestimonialsController(ITestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var result = _testimonialManager.T_GetAll();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialManager.T_Insert(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var resut = _testimonialManager.T_GetById(id);
            _testimonialManager.T_Delete(resut);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialManager.T_Update(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var result = _testimonialManager.T_GetById(id);
            return Ok(result);
        }
    }
}

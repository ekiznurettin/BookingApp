using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class TestimonialManager:ITestimonialManager
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void T_Delete(Testimonial entity)
        {
         _testimonialDal.Delete(entity);
        }

        public List<Testimonial> T_GetAll( )
        {
           return _testimonialDal.GetAll();
        }

        public Testimonial T_GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void T_Insert(Testimonial entity)
        {
           _testimonialDal.Insert(entity);
        }

        public void T_Update(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}

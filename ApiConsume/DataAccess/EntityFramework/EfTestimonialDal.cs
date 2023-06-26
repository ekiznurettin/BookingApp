using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(AppDbContext context) : base(context)
        {

        }
    }
}

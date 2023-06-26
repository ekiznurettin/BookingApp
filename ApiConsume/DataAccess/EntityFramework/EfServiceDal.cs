using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfServiceDal:GenericRepository<Service>,IServiceDal
    {
        public EfServiceDal(AppDbContext context) : base(context)
        {

        }
    }
}

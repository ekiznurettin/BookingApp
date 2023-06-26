using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(AppDbContext context) : base(context)
        {

        }
    }
}

using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfStaffDal:GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(AppDbContext context) : base(context)
        {

        }
    }
}

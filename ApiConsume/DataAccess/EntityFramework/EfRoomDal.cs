using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(AppDbContext context) : base(context)
        {

        }
    }
}

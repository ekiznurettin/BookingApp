using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class RoomManager : IRoomManager
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void T_Delete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> T_GetAll()
        {
          return _roomDal.GetAll();
        }

        public Room T_GetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public void T_Insert(Room entity)
        {
          _roomDal.Insert(entity);
        }

        public void T_Update(Room entity)
        {
          _roomDal.Update(entity);
        }
    }
}

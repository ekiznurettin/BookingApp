using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class SubscribeManager : ISubscribeManager
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void T_Delete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public List<Subscribe> T_GetAll( )
        {
            return _subscribeDal.GetAll();
        }

        public Subscribe T_GetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public void T_Insert(Subscribe entity)
        {
         _subscribeDal.Insert(entity);
        }

        public void T_Update(Subscribe entity)
        {
           _subscribeDal.Update(entity);
        }
    }
}

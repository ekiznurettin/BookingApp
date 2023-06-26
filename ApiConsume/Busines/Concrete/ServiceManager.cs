using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void T_Delete(Service entity)
        {
         _serviceDal.Delete(entity);
        }

        public List<Service> T_GetAll()
        {
           return _serviceDal.GetAll();
        }

        public Service T_GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void T_Insert(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void T_Update(Service entity)
        {
          _serviceDal.Update(entity);
        }
    }
}

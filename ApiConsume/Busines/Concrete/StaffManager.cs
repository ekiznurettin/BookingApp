using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class StaffManager : IStaffManager
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void T_Delete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> T_GetAll( )
        {
          return _staffDal.GetAll();
        }

        public Staff T_GetById(int id)
        {
         return _staffDal.GetById(id);
        }

        public void T_Insert(Staff entity)
        {
           _staffDal.Insert(entity);
        }

        public void T_Update(Staff entity)
        {
        _staffDal.Update(entity);
        }
    }
}

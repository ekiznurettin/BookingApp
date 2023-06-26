namespace Busines.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void T_Insert(T entity);
        void T_Delete(T entity);
        void T_Update(T entity);
        List<T> T_GetAll();
        T T_GetById(int id);
    }
}

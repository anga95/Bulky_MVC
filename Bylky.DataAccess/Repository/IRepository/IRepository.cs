using System.Linq.Expressions;

namespace Bylky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, Boolean>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}

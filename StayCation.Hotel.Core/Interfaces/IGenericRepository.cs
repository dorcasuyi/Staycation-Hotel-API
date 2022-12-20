using System.Linq.Expressions;

namespace StayCation.Hotel.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T item);
        Task DeleteAsync(string id);
        Task<List<T>> GetAllAsync(/*Expression<Func<T, bool>> expression = null, List<string> includes = null*/);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, List<string> includes = null);
        void Update(T item);
        Task<List<T>> GetAsync();
    }
}
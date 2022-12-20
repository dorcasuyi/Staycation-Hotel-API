using Microsoft.EntityFrameworkCore;
using StayCation.Hotel.Core.Interfaces;
using StayCation.Hotel.Models.Models;
using System.Linq.Expressions;

namespace StayCation.Hotel.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HotelDbContext _dbContext;
        private readonly DbSet<T> _entitySet;
        public GenericRepository(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitySet = dbContext.Set<T>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task AddAsync(T item)
        {
            await _entitySet.AddAsync(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public async Task DeleteAsync(string id)
        {
            var entity = await _entitySet.FindAsync(id);
            _entitySet.Remove(entity);
        }
        public async Task<List<T>> GetAllAsync(/*Expression<Func<T, bool>> expression = null, List<string> includes = null*/ )
        {
            //IQueryable<T> query = _entitySet;
            //if (expression == null)
            //{
            //    query = query.Where(expression);
            ////}
            //if (includes == null)
            //{
            //    foreach (var include in includes)
            //    {
            //        query = query.Include(include);
            //    }
            //}
            //return await _entitySet.AsNoTracking().ToListAsync();
            return await _entitySet.ToListAsync();
            //return _entitySet.AsEnumerable();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _entitySet;
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return _entitySet.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public Task<List<T>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            _dbContext.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
    }
}

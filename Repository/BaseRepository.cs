using Base_Backend.Config.Database;
using Base_Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        public ApiDbContext _context;
        public BaseRepository(ApiDbContext context)
        {
            _context = context;
        }

        public virtual TEntity Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        public virtual IEnumerable<TEntity> GetAll()
        {
            string order = "name";
            return _context.Set<TEntity>().Skip((1-1) * 10).Take(10).ToList();
        }

        public virtual TEntity FindById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual void Delete(int id)
        {
            try
            {
                var obj = _context.Set<TEntity>().Find(id);
                _context.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual TEntity Update(int id, TEntity obj)
        {
            try
            {
                _context.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}

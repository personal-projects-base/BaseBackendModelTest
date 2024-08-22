using Base_Backend.Config.Database;
using Base_Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Repository;

public class PaisRepository : IPaisRepository
{
    public ApiDbContext _context;
    
    public PaisRepository(ApiDbContext context)
    {
        _context = context;
    }

    public virtual PaisEntity Add(PaisEntity obj)
    {
        try
        {
            _context.Set<PaisEntity>().Add(obj);
            _context.SaveChanges();
            return obj;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
        

    public virtual IEnumerable<PaisEntity> GetAll()
    {
        string order = "name";
        return _context.Set<PaisEntity>().Skip((1-1) * 10).Take(10).ToList();
    }

    public virtual PaisEntity FindById(int id)
    {
        return _context.Set<PaisEntity>().Find(id);
    }

    public virtual void Delete(int id)
    {
        try
        {
            var obj = _context.Set<PaisEntity>().Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public virtual PaisEntity Update(int id, PaisEntity obj)
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
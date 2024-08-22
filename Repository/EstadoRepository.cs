using Base_Backend.Config.Database;
using Base_Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Repository;

public class EstadoRepository : IEstadoRepository
{
    public ApiDbContext _context;
    
    public EstadoRepository(ApiDbContext context)
    {
        _context = context;
    }

    public virtual EstadoEntity Add(EstadoEntity obj)
    {
        try
        {
            if (obj.CountryId != 0)
            {
                obj.Pais = _context.Set<PaisEntity>().Find(obj.CountryId);
            }
            _context.Set<EstadoEntity>().Add(obj);
            _context.SaveChanges();
            return obj;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
        

    public virtual IEnumerable<EstadoEntity> GetAll()
    {
        string order = "name";
        return _context.EstadoContext.Include(e => e.Pais).Skip((1-1) * 10).Take(10).ToList();
    }

    public virtual EstadoEntity FindById(int id)
    {
        return _context.Set<EstadoEntity>().Find(id);
    }

    public virtual void Delete(int id)
    {
        try
        {
            var obj = _context.Set<EstadoEntity>().Find(id);
            _context.Remove(obj);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public virtual EstadoEntity Update(int id, EstadoEntity obj)
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
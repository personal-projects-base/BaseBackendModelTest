using Base_Backend.Config.Database;
using Base_Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Base_Backend.Repository;

public class CidadeRepository : ICidadeRepository
{
    
    public ApiDbContext _context;
    
    public CidadeRepository(ApiDbContext context)
    {
        _context = context;
    }
    
    public CidadeEntity Add(CidadeEntity obj)
    {
        try
        {
            if (obj.Country.Id != 0)
            {
                obj.Country = _context.Set<PaisEntity>().Find(obj.Country.Id);
            }
            _context.Set<CidadeEntity>().Add(obj);
            _context.SaveChanges();
            return obj;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public CidadeEntity FindById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CidadeEntity> GetAll()
    {
        string order = "name";

        return _context.CidadeContext.Include(c => c.Country).Skip((1-1) * 10).Take(10).ToList();
    }

    public CidadeEntity Update(int id, CidadeEntity obj)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
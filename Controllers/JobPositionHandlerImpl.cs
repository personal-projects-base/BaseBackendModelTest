
using Base_Backend.Config.Database;
using Base_Backend.Gen;
using Base_Backend.Model;
using Microsoft.AspNetCore.Mvc;
namespace Base_Backend.Controllers;


public class JobPositionHandlerImpl : JobPositionHandler
{
    
    private readonly ApiDbContext _context;

    public JobPositionHandlerImpl(ApiDbContext context)
    {
        _context = context;
    }

    public override ActionResult<List<ProductEntity>> GetProduct()
    {
        
        try
        {
            var products = _context.ProductContext.ToList();
            return products;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        return null;
    }
}
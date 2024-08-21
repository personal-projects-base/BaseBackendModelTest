
using Base_Backend.Config.Database;
using Base_Backend.Gen;
using Base_Backend.Model;
using Microsoft.AspNetCore.Mvc;
namespace Base_Backend.Controllers;


public class JobPositionHandlerImpl : JobPositionHandler
{


    public override ActionResult<List<ProductEntity>> GetProduct()
    {
        using (var context = new ApiDbContext())
        {
            var products = context.ProductContext.ToList();
            return products;
        }
    
        return null;
    }
}
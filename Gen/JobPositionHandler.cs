
using Base_Backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Gen;

[Serializable]
[ApiController]
[Route("v1/jobposition")]
public abstract class JobPositionHandler : ControllerBase
{
    
    [AcceptVerbs("GET")]
    [Route("GetProduct")]
    public abstract ActionResult<List<ProductEntity>> GetProduct();
    
}
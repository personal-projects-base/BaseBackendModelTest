using Base_Backend.Model;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers;

[Serializable]
[ApiController]
[Route("v1/jobposition")]
public abstract class JobPositionHandler : ControllerBase
{
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public abstract ActionResult<String> GetAll();
}
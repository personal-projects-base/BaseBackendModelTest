using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Gen;

[Serializable]
[ApiController]
[Route("v1/city")]
public abstract class CidadeHandler : ControllerBase
{
    public readonly ICidadeRepository _cidadeRepository;

    public CidadeHandler(ICidadeRepository cidadeRepository)
    {
        _cidadeRepository = cidadeRepository;
    }
    
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public abstract ActionResult<List<CidadeEntity>> GetAll();

    [AcceptVerbs("POST")]
    [Route("Save")]
    public abstract ActionResult<CidadeEntity> Save([FromBody] CidadeEntity city);
}
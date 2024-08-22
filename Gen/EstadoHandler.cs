using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Gen;

[Serializable]
[ApiController]
[Route("v1/state")]
public abstract class EstadoHandler : ControllerBase
{
    public readonly IEstadoRepository _estadoRepository;

    public EstadoHandler(IEstadoRepository estadoRepository)
    {
        _estadoRepository = estadoRepository;
    }
    
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public abstract ActionResult<List<EstadoEntity>> GetAll();

    [AcceptVerbs("POST")]
    [Route("Save")]
    public abstract ActionResult<EstadoEntity> Save([FromBody] EstadoEntity state);
}
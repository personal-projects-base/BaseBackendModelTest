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
    
    [HttpGet]
    public abstract ActionResult<List<CidadeEntity>> Cidade();

    [HttpPost]
    public abstract ActionResult<CidadeEntity> Cidade([FromBody] CidadeEntity city);
    
    [HttpPut("{id}")]
    public abstract ActionResult<CidadeEntity> Cidade(int id, [FromBody] CidadeEntity city);
    
    [HttpDelete("{id}")]
    public abstract ActionResult<CidadeEntity> Cidade(int id);
}
using Base_Backend.Gen;
using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers;

public class CidadeHandlerImpl : CidadeHandler
{
    public CidadeHandlerImpl(ICidadeRepository cidadeRepository) : base(cidadeRepository)
    {
    }

    public override ActionResult<List<CidadeEntity>> GetAll()
    {
        var obj = _cidadeRepository.GetAll();
        return Ok(obj);
    }

    public override ActionResult<CidadeEntity> Save(CidadeEntity city)
    {
        var obj = _cidadeRepository.Add(city);
        return obj;
    }
}
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
    
    public override ActionResult<List<CidadeEntity>> Cidade()
    {
        var obj = _cidadeRepository.GetAll();
        return Ok(obj);
    }

    public override ActionResult<CidadeEntity> Cidade(CidadeEntity city)
    {
        var obj = _cidadeRepository.Add(city);
        return obj;
    }

    public override ActionResult<CidadeEntity> Cidade(int id, CidadeEntity city)
    {
        var obj = _cidadeRepository.Update(id, city);
        return Ok(obj);
    }

    public override ActionResult<CidadeEntity> Cidade(int id)
    {
        throw new NotImplementedException();
    }
}
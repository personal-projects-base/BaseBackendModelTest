using Base_Backend.Gen;
using Base_Backend.Model;
using Base_Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Base_Backend.Controllers;

public class EstadoHandlerImpl : EstadoHandler
{
    public EstadoHandlerImpl(IEstadoRepository estadoRepository) : base(estadoRepository)
    {
    }

    public override ActionResult<List<EstadoEntity>> GetAll()
    {
        var obj = _estadoRepository.GetAll();
        return Ok(obj);
    }

    public override ActionResult<EstadoEntity> Save(EstadoEntity state)
    {
        var obj = _estadoRepository.Add(state);
        return Ok(obj);
    }
}
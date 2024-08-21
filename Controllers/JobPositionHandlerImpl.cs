using Microsoft.AspNetCore.Mvc;
namespace Base_Backend.Controllers;


public class JobPositionHandlerImpl : JobPositionHandler
{
    public override ActionResult<string> GetAll()
    {
        return "deu boa";
    }
}
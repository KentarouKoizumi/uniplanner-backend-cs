using Application.Commons;
using Application.DataObjects.ResponseModels.Root;
using Application.UseCases.Root.Greeting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RootController : ControllerBase
{
    /// <summary>
    /// お試しエンドポイント
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GreetingResponseModel))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExecutionError))]
    public IActionResult Get([FromServices] IGreetingUseCase useCase)
    {
        var result = useCase.Execute();
        if (result.Error != null)
        {
            return new ObjectResult(result.Error)
            {
                StatusCode = result.Error.Code
            };
        }
        return Ok(result.ResponseModel);
    }
}

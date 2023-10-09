using Application.UseCases.Root.Greeting;
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
    public string Get([FromServices] IGreetingUseCase useCase)
    {
        return useCase.Execute();
    }
}

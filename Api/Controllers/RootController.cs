using Application.UseCases.Root.Greeting;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RootController : ControllerBase
{
    [HttpGet]
    public string Get([FromServices] IGreetingUseCase greetingUseCase)
    {
        return greetingUseCase.Execute();
    }
}

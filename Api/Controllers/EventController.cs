using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DataObjects.ResponseModels.Events;
using Application.UseCases.Event.GetEvents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<GetEventResponseModel>))]
    public async Task<IActionResult> GetEvents([FromServices] IGetEventsUseCase useCase)
    {
        var result = await useCase.Execute();
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
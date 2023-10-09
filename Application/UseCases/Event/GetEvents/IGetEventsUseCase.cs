using Application.Commons;
using Application.DataObjects.ResponseModels.Events;

namespace Application.UseCases.Event.GetEvents;
public interface IGetEventsUseCase
{
    Task<ExecutionResult<List<GetEventResponseModel>>> Execute();
}
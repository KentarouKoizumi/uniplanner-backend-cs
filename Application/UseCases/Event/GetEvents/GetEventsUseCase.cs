using Application.Commons;
using Application.DataObjects.ResponseModels.Events;
using Domain.Interfaces.Repositories;

namespace Application.UseCases.Event.GetEvents;

public class GetEventsUseCase : IGetEventsUseCase
{
    private readonly IEventRepository _eventRepository;

    public GetEventsUseCase(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
    }

    public async Task<ExecutionResult<List<GetEventResponseModel>>> Execute()
    {
        var result = new ExecutionResult<List<GetEventResponseModel>>();

        var events = await _eventRepository.GetAllAsync();

        result.ResponseModel = events.Select(e => new GetEventResponseModel(e)).ToList();

        return result;
    }
}
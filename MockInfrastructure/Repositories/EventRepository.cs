
using Domain.Interfaces.Repositories;
using Domain.Models.Events;
using MockInfrastructure.DataObjects;
using MockInfrastructure.Mappers;

namespace MockInfrastructure.Repositories;
public class MockEventRepository : IEventRepository
{
    public Task<List<Event>> GetAllAsync()
    {
        var eventDataCollection = new List<EventCreateData>();

        for (int i = 1; i < 6; i++)
        {
            var eventId = Guid.NewGuid();
            var eventCreateData = new EventCreateData
            {
                Id = eventId,
                Name = $"Event {i}",
                Description = $"Event {i} Description",
                IsWeekly = false,
                Schedules = new List<ScheduleCreateData>()
            };

            for (int j = 1; j < 6; j++)
            {
                var scheduleCreateData = new ScheduleCreateData
                {
                    Id = Guid.NewGuid(),
                    EventId = eventId,
                    Date = new DateOnly(2023, i, j),
                    Period = j
                };

                eventCreateData.Schedules.Add(scheduleCreateData);
            }

            eventDataCollection.Add(eventCreateData);

        }

        var events = EventMockMapper.CreateEventMapper.Map<List<Event>>(eventDataCollection);
        return Task.FromResult(events);
    }
}
using AutoMapper;
using Domain.Models.Events;
using Domain.Models.Schedules;
using MockInfrastructure.DataObjects;

namespace MockInfrastructure.Mappers;

public class EventMockMapper
{
    public static Mapper CreateEventMapper = new(new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<EventCreateData, Event>();
        cfg.CreateMap<ScheduleCreateData, Schedule>();
    }));
}
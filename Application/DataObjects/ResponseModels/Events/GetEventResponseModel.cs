using System.ComponentModel.DataAnnotations;
using Application.DataObjects.ResponseModels.Schedules;
using Domain.Models.Events;

namespace Application.DataObjects.ResponseModels.Events;
public class GetEventResponseModel
{
    public GetEventResponseModel(Event eventData)
    {
        Id = eventData.Id;
        Name = eventData.Name;
        Description = eventData.Description;
        Schedules = eventData.Schedules.Select(schedule => new GetScheduleViewModel(schedule)).ToList();
    }
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public List<GetScheduleViewModel> Schedules { get; set; }
}
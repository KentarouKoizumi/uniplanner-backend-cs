using System.ComponentModel.DataAnnotations;
using Domain.Models.Schedules;

namespace Application.DataObjects.ResponseModels.Schedules;
public class GetScheduleViewModel
{
    public GetScheduleViewModel(Schedule schedule)
    {
        Id = schedule.Id;
        Date = schedule.Date;
        Period = schedule.Period;
    }
    [Required]
    public Guid Id { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public int Period { get; set; }
}
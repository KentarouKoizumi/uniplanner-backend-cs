using System.ComponentModel.DataAnnotations;
using Domain.Models.Schedules;

namespace Domain.Models.Events;

public class Event : Base
{
    [Required]
    public string Name { get; private set; }

    [Required]
    public bool isWeekly { get; private set; }


    [Required]
    public List<Schedule> Schedules { get; private set; }
}
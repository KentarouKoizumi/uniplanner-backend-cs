using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Models.Answers;
using Domain.Models.Events;

namespace Domain.Models.Schedules;

public class Schedule : Base
{
    [Required]
    public Guid EventId { get; private set; }

    [Required]
    public DateOnly Date { get; private set; }

    [Required]
    public int Period { get; private set; }

    [JsonIgnore]
    public Event Event { get; private set; }
    [JsonIgnore]
    public List<Answer> Answers { get; private set; }


}
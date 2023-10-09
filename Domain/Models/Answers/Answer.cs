using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Domain.Models.Schedules;
using Domain.Models.Users;

namespace Domain.Models.Answers;
public class Answer : Base
{
    [Required]
    public Guid UserId { get; private set; }

    [Required]
    public Guid ScheduleId { get; private set; }

    [Required]
    public RSVPStatus Status { get; private set; }


    [JsonIgnore]
    public User User { get; private set; }
    [JsonIgnore]
    public Schedule Schedule { get; private set; }
}
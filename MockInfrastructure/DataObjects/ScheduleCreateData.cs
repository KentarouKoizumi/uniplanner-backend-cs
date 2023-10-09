namespace MockInfrastructure.DataObjects;
public class ScheduleCreateData
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }
    public DateOnly Date { get; set; }
    public int Period { get; set; }
}
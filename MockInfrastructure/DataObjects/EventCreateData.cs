namespace MockInfrastructure.DataObjects;
public class EventCreateData
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsWeekly { get; set; }

    public List<ScheduleCreateData> Schedules { get; set; }
}
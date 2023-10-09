using Domain.Models.Events;

namespace Domain.Interfaces.Repositories;
public interface IEventRepository
{
    public Task<List<Event>> GetAllAsync();
}
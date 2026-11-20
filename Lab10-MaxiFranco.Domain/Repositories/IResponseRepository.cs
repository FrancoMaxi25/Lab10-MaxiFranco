using Lab10_MaxiFranco.Domain.Entities;

namespace Lab10_MaxiFranco.Domain.Repositories;

public interface IResponseRepository : IGenericRepository<Response>
{
    Task<IEnumerable<Response>> GetByTicketIdAsync(Guid ticketId);
}
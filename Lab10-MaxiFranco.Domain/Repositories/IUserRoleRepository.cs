using Lab10_MaxiFranco.Domain.Entities;

namespace Lab10_MaxiFranco.Domain.Repositories;

public interface IUserRoleRepository : IGenericRepository<UserRole>
{
    Task<IEnumerable<UserRole>> GetByUserIdAsync(Guid userId);
}
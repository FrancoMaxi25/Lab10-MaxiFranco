using Lab10_MaxiFranco.Domain.Entities;

namespace Lab10_MaxiFranco.Domain.Repositories;

public interface IRoleRepository : IGenericRepository<Role>
{
    Task<Role?> GetByNameAsync(string roleName);
}
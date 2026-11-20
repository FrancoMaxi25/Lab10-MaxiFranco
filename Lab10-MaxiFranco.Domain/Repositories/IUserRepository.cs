using Lab10_MaxiFranco.Domain.Entities;

namespace Lab10_MaxiFranco.Domain.Repositories;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> GetByEmailAsync(string email);
}
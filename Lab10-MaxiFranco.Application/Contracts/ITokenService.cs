using Lab10_MaxiFranco.Domain.Entities;
namespace Lab10_MaxiFranco.Application.Contracts;
public interface ITokenService
{
    (string Token, DateTime ExpiresAt) Generate(User user, IEnumerable<string> roles);
}

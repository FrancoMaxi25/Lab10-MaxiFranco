namespace Lab10_MaxiFranco.Application.Contracts;

public interface IPasswordHasher
{
    string Hash(string password);

    bool Verify(string password, string passwordHash);
}
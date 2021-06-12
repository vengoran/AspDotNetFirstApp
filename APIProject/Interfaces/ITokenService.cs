using APIProject.Entities;

namespace APIProject.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
using OmniAPI.Domain.Models;

namespace OmniAPI.Main.DataAccess
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetByEmail(string email);
        User GetById(int id);
    }
}

using OmniAPI.Data;
using OmniAPI.Domain.Models;

namespace OmniAPI.Main.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly OmniContext _context;

        public UserRepository(OmniContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            user.Id = _context.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}

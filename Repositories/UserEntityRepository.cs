using Database;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class UserEntityRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserEntityRepository(DataContext context)
        {
            _context = context;
        }

        public User GetUserById(string id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            return user;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}

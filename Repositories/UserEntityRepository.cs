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

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}

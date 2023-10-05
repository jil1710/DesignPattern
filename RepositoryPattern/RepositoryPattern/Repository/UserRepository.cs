

using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext context;

        public UserRepository(UserContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> AddUser(User user)
        {
          await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
           
            return true;
        }


    }
}

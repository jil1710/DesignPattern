using RepositoryPattern.Models;

namespace RepositoryPattern.Repository
{
    public interface IUserRepository
    {
        Task<bool> AddUser(User user);
        Task<User> GetUserById(int id);
        Task<List<User>> GetUsers();
    }
}
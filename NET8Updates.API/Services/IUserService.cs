using NET8Updates.API.Models;

namespace NET8Updates.API.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUserById(int id);
    }
}

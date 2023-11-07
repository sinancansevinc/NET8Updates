using NET8Updates.API.Data;
using NET8Updates.API.Models;

namespace NET8Updates.API.Services
{
    public class UserService : IUserService
    {
        static List<User> UserList;

        public UserService()
        {
            if(UserList == null)
            {
                UserList = FakeUsers.GetStaticUsers();
            }
        }
        public User GetUserById(int id)
        {
            return UserList.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return UserList;
        }
    }
}

using ServerApi.Models;

namespace ServerApp.Services
{
    public class UserService 
    {
        private static List<User> users;
        public List<User> GetAll()
        {
          return users;
        }

        public string connected = "inbal";
    }
}

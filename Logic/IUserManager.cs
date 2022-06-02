using System.Collections.Generic;

namespace Logic
{
    public interface IUserManager
    {
        public List<User> GetUsers();
        public User PostUser(User user);

        public User PutUser(User user);

        public User DeleteUser(User user);
    }
}
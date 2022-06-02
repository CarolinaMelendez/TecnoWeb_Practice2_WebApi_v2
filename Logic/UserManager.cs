using System;
using System.Collections.Generic;

namespace Logic
{
    public class UserManager : IUserManager
    {
        public List<User> Users { get; set; }
        public UserManager()
        {
            Users =  new List<User>()
            {
                new User(){ Ci = 10 , Name = "Carolina"},
                new User(){ Ci = 11 , Name = "Franco"},
                new User(){ Ci = 12 , Name = "Melany"}
            };
        }
        public List<User> GetUsers()
        {
            return Users;
        }
      
        public User PostUser(User user)
        {
            Users.Add(user);
            return user;
        }
        
        public User PutUser(User user)
        {
            // suponiendo que solo quiera cambiar el nombre
            Users.Find(u => u.Ci == user.Ci).Name = user.Name;
            return user;
        }
       
        public User DeleteUser(User user)
        {
            Users.Remove(user);
            return user;
        }
    }
}

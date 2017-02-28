using System.Collections.Generic;

namespace MyFirstApp.Domain.Models
{
    public class User
    {
        public long UserId { get; private set; }
        public string Username { get; private set; }   
        public string Password { get; private set; }       
        public string Email { get; private set; } 
        public IEnumerable<UserGroup> Groups {get; private set;}

        public User()
        {
            this.Groups = new List<UserGroup>();
        }

        public User(long userId, string username, string password, string email, IEnumerable<UserGroup> groups)
        {
            this.Groups = groups;
            this.Username = username;
            this.Password = password;
            this.Email = email;            
            this.Groups = groups;
        }
    }
}
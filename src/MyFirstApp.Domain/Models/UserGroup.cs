using System.Collections.Generic;
using MyFirstApp.Domain.Models;

namespace MyFirstApp.Domain.Models
{
    public class UserGroup
    {
        public long UserId { get; private set; }
        public User User { get; private set; }

        public long GroupId {get; private set;}
        public Group Group { get; set; }

    }
}
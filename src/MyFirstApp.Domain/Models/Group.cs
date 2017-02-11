using System.Collections.Generic;

namespace MyFirstApp.Domain.Models
{
    public class Group
    {
        public long GroupId { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<Permission> Permissions {get; private set;}
        public IEnumerable<User> Users {get; private set;}

        public Group()
        {
            this.Permissions = new List<Permission>();
            this.Users = new List<User>();
        }

        public Group(long groupId, string name, IEnumerable<Permission> permissions)
        {
            this.GroupId = groupId;
            this.Name = name;
            this.Permissions = permissions;
        }
    }
}
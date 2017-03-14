using System.Collections.Generic;

namespace MyFirstApp.Domain.Models
{
    public class Group
    {
        public long GroupId { get; private set; }
        public string Name { get; private set; }
        public IEnumerable<GroupPermission> Permissions {get; private set;}
        public IEnumerable<UserGroup> Users {get; private set;}

        public Group()
        {
            this.Permissions = new List<GroupPermission>();
            this.Users = new List<UserGroup>();
        }

        public Group(string name) : base()
        {
            this.Name = name;
        }

        public Group(long groupId, string name, IEnumerable<GroupPermission> permissions)
        {
            this.GroupId = groupId;
            this.Name = name;
            this.Permissions = permissions;
        }
    }
}
using System.Collections.Generic;
using MyFirstApp.Domain.Models;

namespace MyFirstApp.Domain.Models
{
    public class GroupPermission
    {
        public long GroupId { get; private set; }
        public Group Group { get; private set; }

        public long PermissionId { get; private set; }
        public Permission Permission { get; private set; }

        public GroupPermission(Group group, Permission permission)
        {
            this.Group = group;
            this.Permission = permission;
        }
    }
}
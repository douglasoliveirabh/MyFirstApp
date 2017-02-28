using System.Collections.Generic;

namespace MyFirstApp.Domain.Models
{
    public class Permission
    {
        public long PermissionId { get; private set; }
        public string Title { get; private set; }   
        public string ConstantName { get; private set; }     
        public IEnumerable<GroupPermission> Groups {get; private set;}

        public Permission()
        {
            this.Groups = new List<GroupPermission>();
        }

        public Permission(long permissionId, string title, string constantName, IEnumerable<GroupPermission> groups)
        {
            this.PermissionId = permissionId;
            this.Title = title;
            this.Groups = groups;
        }


    }
}
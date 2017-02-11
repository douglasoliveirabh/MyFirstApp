using System.Collections.Generic;

namespace MyFirstApp.Domain.Models
{

    public class Permission
    {
        public long PermissionId { get; private set; }
        public string Title { get; private set; }   
        public string ConstantName { get; private set; }     
        public IEnumerable<Group> Groups {get; private set;}

        public Permission()
        {
            this.Groups = new List<Group>();
        }

        public Permission(long permissionId, string title, string constantName, IEnumerable<Group> groups)
        {
            this.PermissionId = permissionId;
            this.Title = title;
            this.Groups = groups;
        }


    }
}
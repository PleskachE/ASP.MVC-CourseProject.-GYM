using Data.Entity;

using System.Collections.Generic;

namespace CourseProject.GYM.Models
{
    public class RedactorUsersModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Role> Roles { get; set; }

        public RedactorUsersModel(IEnumerable<User> users, IEnumerable<Role> roles)
        {
            this.Users = users;
            this.Roles = roles;
        }
    }
}
using Data.Entity;

using System.Web.Mvc;

namespace CourseProject.GYM.Models
{
    public class UserAndRolesModel
    {
        public User User { get; set; }
        public SelectList RoleService { get; set; }
    }
}
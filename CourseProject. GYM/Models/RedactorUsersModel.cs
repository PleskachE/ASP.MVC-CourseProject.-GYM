using Service.Abstraction;

namespace CourseProject.GYM.Models
{
    public class RedactorUsersModel
    {
        public IUserService UserService { get; set; }
        public IRoleService RoleService { get; set; }

        public RedactorUsersModel(IUserService userService, IRoleService roleService)
        {
            this.UserService = userService;
            this.RoleService = roleService;
        }
    }
}
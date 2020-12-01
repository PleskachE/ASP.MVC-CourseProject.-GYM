using Service.Abstraction;

namespace CourseProject.GYM.Models
{
    public static class UsersAndRolesRepository
    {
        public static IUserService UserService { get; set; }
        public static IRoleService RoleService { get; set; }
    }
}
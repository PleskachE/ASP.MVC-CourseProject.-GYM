using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseProject.GYM.Models
{
    public static class UsersAndRolesRepository
    {
        public static IUserService UserService { get; set; }
        public static IRolesService RolesService { get; set; }
    }
}
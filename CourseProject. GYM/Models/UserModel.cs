using System;

namespace CourseProject.GYM.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Emeil { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RolesId { get; set; }
    }
}
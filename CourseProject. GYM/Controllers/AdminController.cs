using CourseProject.GYM.Models;
using Data.Entity;
using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CourseProject.GYM.Controllers
{
    public class AdminController : Controller
    {

        private ITrainingService _trainingService { get; set; }
        private ISessionService _sessionService { get; set; }
        private IUserService _userService { get; set; }
        private IHallService _hallService { get; set; }
        private ISpecializationService _specializationService { get; set; }
        private IWorkSpecializationService _workSpecializationService { get; set; }
        private IRoleService _roleService { get; set; }

        public AdminController(ITrainingService trainingService, ISessionService sessionService, IUserService userService, 
            IHallService hallService, ISpecializationService specializationService, IWorkSpecializationService workSpecializationService,
            IRoleService roleService)
        {
            this._trainingService = trainingService;
            this._sessionService = sessionService;
            this._userService = userService;
            this._hallService = hallService;
            this._specializationService = specializationService;
            this._workSpecializationService = workSpecializationService;
            this._roleService = roleService;
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        [Authorize]
        public ActionResult RedactorUsers()
        {
            var model = new RedactorUsersModel(_userService, _roleService);
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteUser(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var removeUser = _userService.GetById(id.Value);
            _userService.Remove(removeUser);
            return Redirect("/Account/Index");
        }

        [HttpGet]
        [Authorize]
        public ActionResult UpdateUser(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = new UserAndRolesModel();
            model.User = _userService.GetById(id.Value);
            model.RoleService = new SelectList(_roleService.GetRoles(), "Id", "Name");
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateUser(UserAndRolesModel user)
        {
            _userService.Update(user.User);
            return Redirect("/Account/Index");
        }

        [HttpGet]
        [Authorize]
        public ActionResult CreateUser()
        {
            var model = new UserAndRolesModel();
            model.User = null;
            model.RoleService = new SelectList(_roleService.GetRoles(), "Id", "Name");
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateUser(UserAndRolesModel user)
        {
            var newUser = new User()
            {
                FirstName = user.User.FirstName,
                LastName = user.User.LastName,
                Birthdate = DateTime.Now,
                Emeil = user.User.Emeil,
                ContactPhoneNumber = user.User.ContactPhoneNumber,
                Login = user.User.Login,
                Password = user.User.Password,
                RoleId = user.User.RoleId
            };
            _userService.Add(user.User);
            return Redirect("/Account/Index");
        }
    }
}
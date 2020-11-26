using CourseProject.GYM.Models;

using Data.Entity;

using Service.Abstraction;

using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace CourseProject.GYM.Controllers
{
    public class AccountController : Controller
    {
        private const int _roleIdDefault = 1;

        private IUserService _userService;
        private IRolesService _rolesService;

        public AccountController(IUserService userService)
        {
            this._userService = userService;

            UsersAndRolesRepository.UserService = _userService;
            UsersAndRolesRepository.RolesService = _rolesService;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUsers().FirstOrDefault(x => x.Login == model.Login && x.Password == model.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином не существует");
                }
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetUsers().FirstOrDefault(x => x.Login == model.Login);
                if (user == null)
                {
                    var newUser = new User()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Birthdate = model.Birthdate,
                        Emeil = model.Emeil,
                        ContactPhoneNumber = model.ContactPhoneNumber,
                        Login = model.Login,
                        Password = model.Password,
                        RolesId = _roleIdDefault
                    };
                    _userService.Add(newUser);

                    user = _userService.GetUsers().FirstOrDefault(x => x.Login == model.Login);
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Login, true);
                        return RedirectToAction("Index", "Home", user);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже зарегестрирован!");
                }
            }
            return View(model);
        }


    }
}
using Base.Abstractions;
using CourseProject.GYM.Models;
using Data.Entity;
using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CourseProject.GYM.Controllers
{
    public class AccountController : Controller
    {
        private ListUsersModel _listUsersModel;

        private IWorkerService _workerService;
        private IUserService _clientService;

        public AccountController(IWorkerService workerService, IUserService clientService,
            RolesRepository rolesService)
        {
            this._workerService = workerService;
            this._clientService = clientService;

            _listUsersModel = new ListUsersModel(_workerService, _clientService);
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
            BaseUser resUser = null;
            if (ModelState.IsValid)
            {
                resUser = _listUsersModel.Users.FirstOrDefault(x => x.Login == model.Login && x.Password == model.Password);
                if (resUser != null)
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
        public ActionResult Register(RegisterModel model)
        {
            BaseUser resUser = null;

            if (ModelState.IsValid)
            {
                resUser = _listUsersModel.Users.FirstOrDefault(x => x.Login == model.Login);
                if (resUser == null)
                {
                    var newUser = new UserModel()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Birthdate = model.Birthdate,
                        Emeil = model.Emeil,
                        ContactPhoneNumber = model.ContactPhoneNumber,
                        Login = model.Login,
                        Password = model.Password
                    };
                    _workerService.Add(newUser);

                    resUser = _workerService.GetWorker().FirstOrDefault(x => x.Login == model.Login);
                    if (resUser != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Login, true);
                        return RedirectToAction("Index", "Home", resUser);
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
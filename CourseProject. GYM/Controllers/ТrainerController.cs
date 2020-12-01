using CourseProject.GYM.Models;
using Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CourseProject.GYM.Controllers
{
    public class ТrainerController : Controller
    {
        private ITrainingService _trainingService { get; set; }
        private ISessionService _sessionService { get; set; }
        private IUserService _userService { get; set; }
        private IHallService _hallService { get; set; }
        private ISpecializationService _specializationService { get; set; }

        public ТrainerController(ITrainingService trainingService, ISessionService sessionService, IUserService userService,
            IHallService hallService, ISpecializationService specializationService)
        {
            this._trainingService = trainingService;
            this._sessionService = sessionService;
            this._userService = userService;
            this._hallService = hallService;
            this._specializationService = specializationService;
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        [Authorize]
        public ActionResult MyWork()
        {
            var model = new List<ScheduleModel>();
            foreach(var item in _trainingService.GetTrainings())
            {
                if(item.UserId == AuthorizedUser.Id)
                {
                    model.Add(new ScheduleModel()
                    {
                        Id = item.Id,
                        TrainingName = _specializationService.GetById(item.SpecializationId).Name,
                        NameHall = _hallService.GetById(item.HallId).Name,
                        StartTime = item.StartTime,
                        EndTime = item.EndTime
                    });
                }
            }
            return View(model);
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        [Authorize]
        public ActionResult Users(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var model = new List<UserModel>();
            var sessions = _sessionService.GetSessions().ToList().FindAll(x => x.TrainingId == id.Value);
            foreach(var item in sessions)
            {
                model.Add(new UserModel()
                {
                    FirstName = _userService.GetById(item.UserId).FirstName,
                    LastName = _userService.GetById(item.UserId).LastName,
                    Emeil = _userService.GetById(item.UserId).Emeil,
                    ContactPhoneNumber = _userService.GetById(item.UserId).ContactPhoneNumber,
                });
            }
            return View(model);
        }
    }
}
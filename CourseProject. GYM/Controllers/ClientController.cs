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
    public class ClientController : Controller
    {

        private ITrainingService _trainingService { get; set; }
        private ISessionService _sessionService { get; set; }
        private IUserService _userService { get; set; }
        private IHallService _hallService { get; set; }
        private ISpecializationService _specializationService { get; set; }

        private ScheduleModel scheduleModel { get; set; }

        public ClientController(ITrainingService trainingService, ISessionService sessionService,
            IUserService userService, IHallService hallService, ISpecializationService specializationService)
        {
            this._trainingService = trainingService;
            this._sessionService = sessionService;
            this._userService = userService;
            this._hallService = hallService;
            this._specializationService = specializationService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult SignUpTrainingSession(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            scheduleModel = GetScheduleModel(id);
            return View(scheduleModel);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Result(int? id)
        {
            scheduleModel = GetScheduleModel(id);
            _sessionService.Add(new Data.Entity.Session
            {
                    TrainingId = scheduleModel.Id,
                    UserId = AuthorizedUser.Id
            });
            return Redirect("/Home/Index");
        }

        [HttpGet]
        [Authorize]
        public ActionResult Update()
        {
            var model = _userService.GetById(AuthorizedUser.Id);      
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Update(User user)
        {
            _userService.Update(user);
            return Redirect("/Home/Index");
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        [Authorize]
        public ActionResult MySchedule()
        {
            var model = new List<ScheduleModel>();
            var listSession = _sessionService.GetSessions().ToList().FindAll(x => x.UserId == AuthorizedUser.Id);
            var listTraining = new List<Training>();

            if (listSession != null)
            {
               for(var i = 0; i < listSession.Count; i++)
               {
                    listTraining.Add(_trainingService.GetById(listSession[i].TrainingId));
               }
            }

            foreach(var item in listTraining)
            {
                model.Add(new ScheduleModel()
                {
                    Id = item.Id,
                    TrainingName = _specializationService.GetById(_trainingService.GetById(item.Id).SpecializationId).Name,
                    NameHall = _hallService.GetById(_trainingService.GetById(item.Id).HallId).Name,
                    NameCoach = _userService.GetById(_trainingService.GetById(item.Id).UserId).FirstName + " "
                + _userService.GetById(_trainingService.GetById(item.Id).UserId).LastName,
                    StartTime = _trainingService.GetById(item.Id).StartTime,
                    EndTime = _trainingService.GetById(item.Id).EndTime,
                });
            }
            return View(model);
        }

        private ScheduleModel GetScheduleModel(int? id)
        {
            scheduleModel = new ScheduleModel()
            {
                Id = id.Value,
                TrainingName = _specializationService.GetById(_trainingService.GetById(id.Value).SpecializationId).Name,
                NameHall = _hallService.GetById(_trainingService.GetById(id.Value).HallId).Name,
                NameCoach = _userService.GetById(_trainingService.GetById(id.Value).UserId).FirstName + " "
                + _userService.GetById(_trainingService.GetById(id.Value).UserId).LastName,
                StartTime = _trainingService.GetById(id.Value).StartTime,
                EndTime = _trainingService.GetById(id.Value).EndTime,
            };
            return scheduleModel;
        }
    }
}
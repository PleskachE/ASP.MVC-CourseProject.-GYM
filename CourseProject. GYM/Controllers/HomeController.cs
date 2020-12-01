using CourseProject.GYM.Models;

using Service.Abstraction;

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace CourseProject.GYM.Controllers
{
    public class HomeController : Controller
    {
        private ISpecializationService _specializationService { get; set; }
        private IHallService _hallService { get; set; }
        private IUserService _userService { get; set; }
        private ITrainingService _trainingService {get;set;}

        public HomeController(ISpecializationService specializationService, IHallService hallService,
            IUserService userService, ITrainingService trainingService)
        {
            this._hallService = hallService;
            this._specializationService = specializationService;
            this._userService = userService;
            this._trainingService = trainingService;
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        public ActionResult Index()
        {
            HallsAndSpecializationModel model = new HallsAndSpecializationModel(_specializationService,
                _hallService);
            return View(model);
        }

        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        [HttpGet]
        public ActionResult Result(int id)
        {
            var training = _trainingService.GetTrainings().ToList().FindAll(x => x.SpecializationId == id);
            var model = new List<ScheduleModel>();
            foreach(var item in training)
            {
                model.Add(new ScheduleModel()
                {
                    Id = item.Id,
                    TrainingName = _specializationService.GetById(id).Name,
                    NameHall = _hallService.GetById(item.HallId).Name,
                    NameCoach = _userService.GetById(item.UserId).FirstName + " " + _userService.GetById(item.UserId).LastName,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime
                });
                if(_specializationService.GetById(id).IsSingle == true && _specializationService.GetById(id).Isgroup == false)
                {
                    model.Last().EmptySpace = 1 - item.CountTrainees;
                }
                else
                {
                    model.Last().EmptySpace = _hallService.GetById(item.HallId).MaxCountTrainees - item.CountTrainees;
                }
            }
            return View(model);
        }
    }
}
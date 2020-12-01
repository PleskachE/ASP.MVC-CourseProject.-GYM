using Service.Abstraction;

namespace CourseProject.GYM.Models
{
    public class HallsAndSpecializationModel
    {
        public ISpecializationService SpecializationService { get; set; }
        public IHallService HallService { get; set; }
        
        public HallsAndSpecializationModel(ISpecializationService specializationService, IHallService hallService)
        {
            this.HallService = hallService;
            this.SpecializationService = specializationService;
        }

    }
}
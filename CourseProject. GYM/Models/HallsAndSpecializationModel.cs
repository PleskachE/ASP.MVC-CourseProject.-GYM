using Data.Entity;

using System.Collections.Generic;

namespace CourseProject.GYM.Models
{
    public class HallsAndSpecializationModel
    {
        public IEnumerable<Specialization> Specializations { get; set; }
        public IEnumerable<Hall> Halls { get; set; }
        
        public HallsAndSpecializationModel(IEnumerable<Specialization> specializations, IEnumerable<Hall> halls)
        {
            this.Halls = halls;
            this.Specializations = specializations;
        }

    }
}
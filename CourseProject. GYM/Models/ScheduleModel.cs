using System;

namespace CourseProject.GYM.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public int EmptySpace { get; set; }
        public string TrainingName { get; set; }
        public string NameHall { get; set; }
        public string NameCoach { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
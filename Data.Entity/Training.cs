using Base.Abstractions;
using System;

namespace Data.Entity
{
    public class Training : BaseEntity
    {
        public int TrainingGymId { get; set; }
        public int UserId { get; set; }
        public int TrainingSpecializationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}

using Base.Abstractions;

namespace Data.Entity
{
    public class WorkSpecializations : BaseEntity
    {
        public int WorkerId { get; set; }
        public int TrainingSpecializationId { get; set; }
    }
}

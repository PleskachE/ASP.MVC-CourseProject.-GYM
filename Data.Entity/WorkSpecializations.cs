using Base.Abstractions;

namespace Data.Entity
{
    public class WorkSpecializations : BaseEntity
    {
        public int UserId { get; set; }
        public int TrainingSpecializationId { get; set; }
    }
}

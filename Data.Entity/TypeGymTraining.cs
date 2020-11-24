using Base.Abstractions;

namespace Data.Entity
{
    public class TypeGymTraining : BaseEntity
    {
        public int TrainingGymId { get; set; }
        public int TrainingSpecializationId { get; set; }
    }
}

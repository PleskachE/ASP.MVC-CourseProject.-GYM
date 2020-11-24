using Base.Abstractions;

namespace Data.Entity
{
    public class TrainingSessions : BaseEntity
    {
        public int ClientId { get; set; }
        public int TrainingId { get; set; }

    }
}

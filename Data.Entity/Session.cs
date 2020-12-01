using Base.Abstractions;

namespace Data.Entity
{
    public class Session : BaseEntity
    {
        public int UserId { get; set; }
        public int TrainingId { get; set; }

    }
}

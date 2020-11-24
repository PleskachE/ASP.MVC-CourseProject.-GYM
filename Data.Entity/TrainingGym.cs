using Base.Abstractions;

namespace Data.Entity
{
    public class TrainingGym : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

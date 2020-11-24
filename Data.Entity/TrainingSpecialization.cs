using Base.Abstractions;

namespace Data.Entity
{
    public class TrainingSpecialization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSingle { get; set; }
        public bool Isgroup { get; set; }
    }
}

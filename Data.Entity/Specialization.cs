using Base.Abstractions;

namespace Data.Entity
{
    public class Specialization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSingle { get; set; }
        public bool Isgroup { get; set; }
    }
}

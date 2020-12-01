using Base.Abstractions;

namespace Data.Entity
{
    public class HallSpecialization : BaseEntity
    {
        public int HallId { get; set; }
        public int SpecializationId { get; set; }
    }
}

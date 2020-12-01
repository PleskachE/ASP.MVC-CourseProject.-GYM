using Base.Abstractions;

namespace Data.Entity
{
    public class WorkSpecialization : BaseEntity
    {
        public int UserId { get; set; }
        public int SpecializationId { get; set; }
    }
}

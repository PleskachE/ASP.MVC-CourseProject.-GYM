using Base.Abstractions;
using System;

namespace Data.Entity
{
    public class Training : BaseEntity
    {
        public int HallId { get; set; }
        public int UserId { get; set; }
        public int SpecializationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CountTrainees { get; set; }
    }
}

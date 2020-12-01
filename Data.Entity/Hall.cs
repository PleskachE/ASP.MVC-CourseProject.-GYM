using Base.Abstractions;

namespace Data.Entity
{
    public class Hall : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxCountTrainees { get; set; }
    }
}

using Base.Abstractions;

namespace Data.Entity
{
    public class Client : BaseUser
    {
        public int SubscriptionNumber { get; set; }
    }
}

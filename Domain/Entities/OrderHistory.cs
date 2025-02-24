using paytr.Domain.Common;
using paytr.Domain.Enums;

namespace paytr.Domain.Entities
{
    public sealed class OrderHistory : EntityBase
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public OrderStatus Status { get; set; }
        public string? Description { get; set; }
    }

using paytr.Domain.Common;

namespace paytr.Domain.Entities
{
    public sealed class Payment : EntityBase
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public string PaytrStatus { get; set; } = null!;
        public decimal? TotalAmount { get; set; }
        public string? FailedReasonCode { get; set; }
        public string? FailedReasonMsg { get; set; }
        public string Hash { get; set; } = null!;
        public string? PaymentType { get; set; }
        public bool TestMode { get; set; } = false;
    }
}

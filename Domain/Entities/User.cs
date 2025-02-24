﻿using paytr.Domain.Common;
using paytr.Domain.ValueObjects;

namespace paytr.Domain.Entities
{
    public sealed class User : EntityBase
    {

        public Guid TenantId { get; set; } 
        public Tenant Tenant { get; set; } = null!;
        public string? ExternalUserId { get; set; }
        public Email Email { get; set; }
        public FullName FullName { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; } = [];

    }
}

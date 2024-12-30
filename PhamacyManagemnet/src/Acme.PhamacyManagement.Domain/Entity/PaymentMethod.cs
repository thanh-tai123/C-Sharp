using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class PaymentMethod : Entity<Guid>
    {
        public string PaymentMethodName { get; set; }
        public string Description { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}

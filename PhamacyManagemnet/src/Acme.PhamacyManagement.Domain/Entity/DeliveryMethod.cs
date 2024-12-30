using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class DeliveryMethod : Entity<Guid>
    {

        public string DeliveryMethodName { get; set; }
        public DeliveryMethodStatus methodStatus { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int Estimate {  get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

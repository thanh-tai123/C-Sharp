using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.IssueManagement.Entities
{
    public class OrderProducts: Entity<Guid>
    {
        public Guid ProductsId { get; set; }
        public int Quanlity {  get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
    }
}

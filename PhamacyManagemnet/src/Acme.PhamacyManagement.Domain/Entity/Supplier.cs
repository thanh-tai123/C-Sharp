using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Supplier : Entity<Guid>
    {
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}

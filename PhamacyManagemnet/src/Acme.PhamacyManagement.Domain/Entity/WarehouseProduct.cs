using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class WarehouseProduct : Entity<Guid>
    {
        public int Stock {  get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string ProductId { get; set; }
        public string WarehouseId { get; set; }
    }
}

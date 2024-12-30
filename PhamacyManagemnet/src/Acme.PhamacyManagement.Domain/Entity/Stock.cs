using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Stock : Entity<Guid>
    {
        public string ProductCode { get; set; }
        public int Quanlity { get; set; }
        public string UnitCode { get; set; }
        public string WarehouseCode { get; set; }
        public string ShopCode { get; set; }

    }
}

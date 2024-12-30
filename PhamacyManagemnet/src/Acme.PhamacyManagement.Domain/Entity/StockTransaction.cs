using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class StockTransaction : Entity<Guid>
    {
        public TranctionType tranctionType { get; set; }
        public string TranctionCode { get; set; }
        public DateTime TranctionDate { get; set; }= DateTime.Now;
        public string UnitCode { get; set; }
        public string ProductCode { get; set; }
        public int Quanlity { get; set; }
        public string WarehouseCode { get; set; }
        public string ShopCode { get; set; }

    }
}

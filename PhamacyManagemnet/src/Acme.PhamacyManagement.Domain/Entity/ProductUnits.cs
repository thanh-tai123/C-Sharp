using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class ProductUnits : Entity<Guid>
    {

        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal ExchangeRate { get; set; }
        public int Quanlity { get; set; }
        public Guid ProductId { get; set; }
        public string ProductCode {  get; set; }
        public LevelUnit Level { get; set; }
        public int QuantityPerUnit { get; set; }
        public string UnitCode { get; set; }


    }
}

using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class ProductPrice : Entity<Guid>
    {
        public string Channel {  get; set; }
        public string ShopCode { get; set; }
        public string ProductCode { get; set; }
        public string UnitCode { get; set; }
        public decimal Price { get; set; }
        public ActivePrice ActivePrice {  get; set; } 

    }
}

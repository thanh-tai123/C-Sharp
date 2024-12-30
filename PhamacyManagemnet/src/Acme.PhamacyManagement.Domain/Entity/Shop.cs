using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Shop : Entity<Guid>
    {
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string Phone {  get; set; }
        public string Adress { get; set; }
        public ShopStatus shopStatus { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}

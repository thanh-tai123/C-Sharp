using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class ReturnProduct : Entity<Guid>
    {
        public string ReturnProductCode { get; set; }
        public string TranctionCode { get; set; }
        public Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public string ShopCode { get; set; } 
        public string ShopName { get; set; }
        public int ReturnDate { get; set; }
        public string Reason { get; set; }
        public StatusReturn statusReturn { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class ReturnProductDetail : Entity<Guid>
    {
        public Guid ReturnProductId { get; set; }
        public string ReturnProductCode { get; set; }
        public Guid OrderDetailId { get; set; }
        public int Quanlity {  get; set; }
        public string WhsCode { get; set; }
        public string WhsName { get; set; }
        public DateTime InitiatedDate { get; set; }= DateTime.Now;
        public DateTime WarehouseReceiveDate;
        public DateTime ShopReceiveDate;
        public DateTime CompletionDate;


    }
}

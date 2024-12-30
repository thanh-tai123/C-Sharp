using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class OrderDetail: Entity<Guid>
    {
        public Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public string WhsCode { get; set; }
        public string WhsName { get; set; }
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        public int Quanlity {  get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }
        public string DiscountCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Total { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;    
        public int ReturnDuration { get; set; }
        
    }
}

using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Order : Entity<Guid>
    {
        public string OrderCode { get; set; }
       
        public OrderStatus orderStatus { get; set; }
        public int OrderVersion { get; set; }
        public string CusCode { get; set; }
        public string CusName { get; set; }
        public string CusPhone { get; set; }
        public string CusEmail { get; set; }
        public string CusAdress { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }

        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Total { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public string CreateBy { get; set; }
        public string ModifyBy { get; set; }
        public Guid DeliveryMethodId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

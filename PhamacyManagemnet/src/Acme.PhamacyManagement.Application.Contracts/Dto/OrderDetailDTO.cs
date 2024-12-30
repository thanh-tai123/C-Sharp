using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.PhamacyManagement.Dto
{
    public class OrderDetailDTO
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

    }
    public class CreateOrderDetailDto
    {
        public string OrderCode { get; set; }
        public string WhsCode { get; set; }
        public string WhsName { get; set; }
        //public Guid ProductId { get; set; }
        //public string ProductCode { get; set; }
        //public int Quanlity { get; set; }
        //public string UnitCode { get; set; }
        //public string UnitName { get; set; }
        //public decimal Price { get; set; }
        //public string DiscountCode { get; set; }
        //public decimal DiscountAmount { get; set; }
        //public decimal TaxRate { get; set; }
        //public decimal TotalTax { get; set; }
        //public decimal TotalBill { get; set; }
        //public decimal Total { get; set; }
        //public int ReturnDuration { get; set; }
    }

}

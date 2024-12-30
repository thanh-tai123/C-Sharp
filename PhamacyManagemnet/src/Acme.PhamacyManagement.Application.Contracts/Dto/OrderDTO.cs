using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.PhamacyManagement.Dto
{
    public class OrderDTO : EntityDto<Guid>
    {
        public string OrderCode { get; set; }
        public int OrderVersion { get; set; }
        public decimal TotalDiscount { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public string CreateBy { get; set; }
        public string ModifyBy { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Total { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public string UserAdress { get; set; }
        public string WarehouseId { get; set; }
        public PaymentStatus Status { get; set; }
        public Shipment Ship { get; set; }
        public Payment_Method Payment { get; set; }
        public List<OrderDetailDTO> OrderProducts { get; set; }
    }
    public class CreateOrderDto 
    {
        public string OrderCode { get; set; }
      
        public OrderStatus orderStatus { get; set; }
        public int OrderVersion { get; set; }
      
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Total { get; set; }
        public string Note { get; set; }
        public List<CreateOrderDetailDto> OrderProducts { get; set; }

    }

   
    public class UpdateOrderDTO {

        public PaymentStatus Status { get; set; }
    }

}

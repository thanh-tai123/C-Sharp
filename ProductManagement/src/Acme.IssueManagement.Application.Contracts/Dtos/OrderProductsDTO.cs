using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.Dtos
{
    public class OrderProductsDTO : EntityDto<Guid>
    {
        public Guid ProductsId { get; set; }
        public int Quanlity { get; set; }
    }
    public class CreateOrderProductsDTO {
        public Guid ProductsId { get; set; }
        public int Quanlity { get; set; }
    }
    public class GetOrderProductsDTO 
    {
        public Guid ProductsId { get; set; }
        public int Quanlity { get; set; }
        public decimal Total {  get; set; }
    }

}

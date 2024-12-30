using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.PhamacyManagement.Dto
{
    public class ProductPriceDTO : EntityDto<Guid>
    {
        public string Channel { get; set; }
        public string ShopCode { get; set; }
        public string ProductCode { get; set; }
        public string UnitCode { get; set; }
        public decimal Price { get; set; }
        public ActivePrice ActivePrice { get; set; }
    }
}

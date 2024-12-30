using Acme.PhamacyManagement.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Volo.Abp.Application.Dtos;

namespace Acme.PhamacyManagement.Dto
{
    public class ProductUnitDTO: EntityDto<Guid>
    {
        public string UnitName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public decimal ExchangeRate { get; set; }
        public int Quanlity { get; set; }
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LevelUnit Level { get; set; }
        public int QuantityPerUnit { get; set; }
        public string UnitCode { get; set; }

    }
}

using Acme.IssueManagement.Books;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.Dtos
{
    public class ProductsDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int Quanlity { get; set; }
    }
    public enum BookType
    {
        Undefined,
        Adventure,
        Biography,
        Science
    }
    public class CreateUpdateProductsDto
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
        public int Quanlity { get; set; }
    }
    public class GetProductListInput
    {
        public string Search { get; set; }
        public double? From { get; set; }
        public double? To { get; set; }
        public string SortBy { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 5;
    }

}

using Acme.IssueManagement.Books;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.IssueManagement.Entities
{
    public class Products: Entity<Guid>
    {
        public string Name { get; set; }
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
}

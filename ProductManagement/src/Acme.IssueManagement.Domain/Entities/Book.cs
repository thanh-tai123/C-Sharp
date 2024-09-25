using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Entities;
using Acme.IssueManagement.Entities;
namespace Acme.IssueManagement.Books
{
    public class Book : Entity<Guid>
    {   
       

        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublicTime { get; set; }
        public double Price { get; set; }
        public int Quanlity { get; set; }
       
    }
}

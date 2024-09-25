using Acme.IssueManagement.Books;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.IssueManagement.Dtos
{
    public class BookDTO
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublicTime { get; set; }
        public float Price { get; set; }
        public int Quanlity { get; set; }
    }
    public class CreateBookDTO {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublicTime { get; set; }
        public float Price { get; set; }
        public int Quanlity { get; set; }
    }

}

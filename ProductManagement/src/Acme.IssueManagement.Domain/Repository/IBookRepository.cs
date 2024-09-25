using System;
using System.Collections.Generic;
using System.Text;
using Acme.IssueManagement.Books;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Acme.IssueManagement.Repository
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(Guid bookId);
        Task<List<Book>> GetAllListAsync();
       
        Task<Book?> GetBookByBooknameAsync(string bookname);
        Task<Book> CreateAsync(Book book);
        Task GetAsync(string name);
    }
}

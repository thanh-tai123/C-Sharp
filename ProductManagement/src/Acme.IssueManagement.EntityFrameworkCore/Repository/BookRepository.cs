using Acme.IssueManagement.Books;
using Acme.IssueManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.IssueManagement.Repository
{
    public class BookRepository : IBookRepository, ISingletonDependency
    {
        private readonly IIssueManagementDbContext _dbContext;

        public BookRepository(IIssueManagementDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Book> CreateAsync(Book book)
        {
            var result = await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public Task<List<Book>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetAsync(Guid bookId)
        {
            try
            {
                var data = await _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(bookId));
                if (data != null) return data;
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public Task GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookByBooknameAsync(string bookname)
        {
            var bookData = await  _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(c => c.Name.Equals(bookname));
            if (bookData != null) return bookData;
            return null;
        }
    }   
}

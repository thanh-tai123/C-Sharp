using Acme.IssueManagement.Books;
using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.IssueManagement.Services
{
    public class BookService : IssueManagementAppService, IBookService
    {
      
        private readonly IBookRepository _bookEFRepository;
        private readonly IObjectMapper _objectMapper;
        public BookService(IBookRepository bookRepository, IObjectMapper objectMapper)
        {
            _bookEFRepository = bookRepository;
            _objectMapper = objectMapper;

        }

        public Task<CreateBookDTO> CreateAsync(CreateBookDTO bookDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BookDTO> GetByIdAsync(Guid bookId)
        {
            var data = await _bookEFRepository.GetAsync(bookId);
            if (data == null)
            {
                throw new UserFriendlyException("No Book Found").WithData("bookId", bookId);
            }
            return _objectMapper.Map<Book, BookDTO>(data);
        }
    }
}

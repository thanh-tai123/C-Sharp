using Acme.IssueManagement.Services;
using System;
using System.Threading.Tasks;
using Acme.IssueManagement.Dtos;
using Microsoft.AspNetCore.Mvc;
namespace Acme.IssueManagement.Controller
{
    [Route("api/BookManagement/books")]
    [ApiController]
    public class BookController : IssueManagementController, IBookService
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
                }


        [HttpGet("{bookId}")]
        public async Task<BookDTO> GetByIdAsync(Guid bookId)
        {
            try
            {
                return await _bookService.GetByIdAsync(bookId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        public Task<CreateBookDTO> CreateAsync(CreateBookDTO bookDto)
        {
            try
            {

                return _bookService.CreateAsync(bookDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

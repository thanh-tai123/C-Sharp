using Acme.IssueManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Services
{
    public interface IBookService   
    {
        Task<BookDTO> GetByIdAsync(Guid id);
        Task<CreateBookDTO> CreateAsync(CreateBookDTO bookDto);
    }
    }

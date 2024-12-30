using Acme.IssueManagement.Dtos;
using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IStockTransactionService 
    {
        Task<StockTransactionDTO> GetAsync(Guid id);
        Task<StockTransactionDTO> CreateAsync(CreateStockTransactionDTO input); 
        Task<List<StockTransactionDTO>> GetListAsync();
    }
}

using Acme.IssueManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.IServices
{
    public interface IOrderProductsServices
    {
        Task<List<OrderProductsDTO>> GetListAsync();
        Task<GetOrderProductsDTO> GetAsync(Guid id);
        Task<OrderProductsDTO> CreateAsync(CreateOrderProductsDTO input);
    }
}

using Acme.IssueManagement.Dtos;
using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IOrderServices
    {
        Task<OrderDTO> GetAsync(Guid id);
        Task<OrderDTO> CreateAsync(CreateOrderDto input);
        Task<OrderDTO> UpdateAsync(Guid id, UpdateOrderDTO input);
        Task DeleteAsync(Guid id);
        Task<List<OrderDTO>> GetListAsync();
    }
}

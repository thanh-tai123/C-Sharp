using Acme.IssueManagement.Dtos;
using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IWarehouseServices
    {
        Task<WarehouseDTO> GetAsync(Guid id);
        Task<WarehouseDTO> CreateAsync(CreateWarehouseDTO input);
        Task<WarehouseDTO> UpdateAsync(Guid id, UpdateWarehouseDTO input);
        Task DeleteAsync(Guid id);
        Task<List<WarehouseDTO>> GetListAsync();
    }
}

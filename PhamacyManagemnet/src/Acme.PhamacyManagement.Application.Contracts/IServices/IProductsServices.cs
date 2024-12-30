using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IProductsServices
    {
        Task<ProductsDTO> GetAsync(Guid id);
        Task<ProductsDTO> CreateAsync(CreateProductsDTO input);
        Task<ProductsDTO> UpdateAsync(Guid id, UpdateProductsDTO input);
        Task DeleteAsync(Guid id);
        Task<List<ProductsDTO>> GetListAsync();
    }
}

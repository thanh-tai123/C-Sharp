using Acme.IssueManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Services
{
    public interface IProductsServices
    {

        Task<List<ProductsDto>> GetListAsync(string search,string sortBy,double? minPrice,double?  maxPrice, int pageNumber, int pageSize);
        Task<ProductsDto> GetAsync(Guid id);
        Task<ProductsDto> CreateAsync(CreateUpdateProductsDto input);
        Task<ProductsDto> UpdateAsync(Guid id, CreateUpdateProductsDto input);
        Task DeleteAsync(Guid id);
    }
}

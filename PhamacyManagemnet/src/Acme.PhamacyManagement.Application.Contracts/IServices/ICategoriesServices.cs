using Acme.IssueManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.IServices
{
    public interface ICategoriesServices
    {
        Task<CategoriesDTO> GetAsync(Guid id);
        Task<CategoriesDTO> CreateAsync(CreateCategoriesDTO input);
        Task<CategoriesDTO> UpdateAsync(Guid id, UpdateCategoriesDTO input);
        Task DeleteAsync(Guid id);
        Task<List<CategoriesDTO>> GetListAsync();
    }
}

using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.IServices;
using Acme.PhamacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.PhamacyManagement.Services
{
    public class ProductsServices : PhamacyManagementAppService, IProductsServices
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IRepository<Products, Guid> _repository;
        public ProductsServices(IProductsRepository productsRepository, IRepository<Products, Guid> repository)
        {
            _productsRepository = productsRepository;
            _repository = repository;
        }
        public async Task<List<ProductsDTO>> GetListAsync()
        {
            try
            {
                var data = await _repository.GetListAsync();
                if (data == null || data.Count == 0)
                {
                    throw new UserFriendlyException("Not Found");
                }
                return ObjectMapper.Map<List<Products>, List<ProductsDTO>>(data);
            }
            catch (UserFriendlyException)
            {
                throw; // Let UserFriendlyException pass through
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                // _logger.LogError(ex, "An error occurred while getting the warehouse list.");
                throw ex;
            }
        }
        public Task<ProductsDTO> CreateAsync(CreateProductsDTO input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductsDTO> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

      

        public Task<ProductsDTO> UpdateAsync(Guid id, UpdateProductsDTO input)
        {
            throw new NotImplementedException();
        }
    }
}

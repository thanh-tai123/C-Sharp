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
    public class ProductPriceService : PhamacyManagementAppService, IProductPriceService
    {
        private readonly IProductPriceRepository _productPriceRepository;
        private readonly IRepository<ProductPrice, Guid> _repository;

        public ProductPriceService(IProductPriceRepository productPriceRepository, IRepository<ProductPrice, Guid> repository)
        {
            _productPriceRepository = productPriceRepository;
            _repository = repository;
        }

       
        public async Task<List<ProductPriceDTO>> GetListAsync()
        {
            try
            {
                var data = await _repository.GetListAsync();
                if (data == null || data.Count == 0)
                {
                    throw new UserFriendlyException("Not Found");
                }
                return ObjectMapper.Map<List<ProductPrice>, List<ProductPriceDTO>>(data);
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
    }
}

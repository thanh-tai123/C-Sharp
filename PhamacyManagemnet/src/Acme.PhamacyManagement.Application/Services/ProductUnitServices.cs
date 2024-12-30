using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp;
using Acme.PhamacyManagement.IServices;

namespace Acme.PhamacyManagement.Services
{
    public class ProductUnitServices : PhamacyManagementAppService, IProductUnitServices
    {
        private readonly IProductUnitRepository _productunitRepository;
        private readonly IRepository<ProductUnits, Guid> _repository;
        public ProductUnitServices(IProductUnitRepository productunitRepository, IRepository<ProductUnits, Guid> repository)
        {
            _productunitRepository = productunitRepository;
            _repository = repository;
        }
        public async Task<List<ProductUnitDTO>> GetListAsync()
        {
            try
            {
                var data = await _repository.GetListAsync();
                if (data == null || data.Count == 0)
                {
                    throw new UserFriendlyException("Not Found");
                }
                return ObjectMapper.Map<List<ProductUnits>, List<ProductUnitDTO>>(data);
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

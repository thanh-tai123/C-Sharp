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

namespace Acme.PhamacyManagement.Services
{
    public class WarehouseService : PhamacyManagementAppService, IWarehouseServices
    {
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly IRepository<Warehouse, Guid> _repository;

        public WarehouseService(IWarehouseRepository warehouseRepository, IRepository<Warehouse, Guid> repository)
        {
            _warehouseRepository = warehouseRepository;
            _repository = repository;
        }
        public async Task<List<WarehouseDTO>> GetListAsync()
        {
            try
            {
                var data = await _repository.GetListAsync();
                if (data == null || data.Count == 0)
                {
                    throw new UserFriendlyException("Not Found");
                }
                return ObjectMapper.Map<List<Warehouse>, List<WarehouseDTO>>(data);
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

        public async Task<WarehouseDTO> CreateAsync(CreateWarehouseDTO input)
        {
            try
            {
                var warehouse = ObjectMapper.Map<CreateWarehouseDTO, Warehouse>(input);
                await _repository.InsertAsync(warehouse);
                return ObjectMapper.Map<Warehouse, WarehouseDTO>(warehouse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                var data = _repository.FindAsync(id);
                if (data != null)
                {
                    throw new UserFriendlyException("Not found");
                }
                await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<WarehouseDTO> GetAsync(Guid id)
        {
            try
            {
                var data = await _warehouseRepository.GetAsync(id);
                if (data == null)
                {
                    throw new UserFriendlyException("Not found");
                }
                return ObjectMapper.Map<Warehouse, WarehouseDTO>(data);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<WarehouseDTO> UpdateAsync(Guid id, UpdateWarehouseDTO input)
        {
            try
            {

                var data = await _repository.GetAsync(id);
                if (data == null)
                {
                    throw new UserFriendlyException("Not Found");
                }
                ObjectMapper.Map(input, data);
                await _repository.UpdateAsync(data);
                return ObjectMapper.Map<Warehouse, WarehouseDTO>(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

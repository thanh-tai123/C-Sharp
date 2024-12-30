using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.PhamacyManagement.Repository
{
    public class WarehouseRepository : IWarehouseRepository, ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public WarehouseRepository(IPhamacyManagementDbContext dbContext) {
        _dbContext = dbContext;
        }
        public async Task<Warehouse> GetAsync(Guid warehouseId)
        {
            try
            {
                var data = await _dbContext.Warehouse.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(warehouseId));
                if (data != null) return data;
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

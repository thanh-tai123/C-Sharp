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
    public class ProductUnitRepository : IProductUnitRepository, ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public ProductUnitRepository(IPhamacyManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductUnits> GetAsyc(Guid productUnitId)
        {
            var data = await _dbContext.ProductUnits.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(productUnitId));
            return data;
        }

      
    }
}

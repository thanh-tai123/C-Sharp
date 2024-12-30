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
    public class ProductPriceRepository : IProductPriceRepository,ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public ProductPriceRepository(IPhamacyManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public async Task<ProductPrice> GetAsync(Guid id)
        {
            try
            {
                var data = await _dbContext.ProductPrices.AsNoTracking().FirstOrDefaultAsync(c => c.Equals(id));
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

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
    public class ProductsRepository : IProductsRepository,ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public ProductsRepository(IPhamacyManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Products> GetAsync(Guid id)
        {
           var data = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(c=>c.Id.Equals(id));
            return data;
        }
    }
}

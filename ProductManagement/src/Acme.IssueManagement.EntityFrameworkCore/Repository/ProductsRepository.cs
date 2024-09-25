using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using Acme.IssueManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.IssueManagement.Repository
{
    public class ProductsRepository : IProductsRepository, ISingletonDependency
    {
        private readonly IIssueManagementDbContext _dbContext;

        public ProductsRepository(IIssueManagementDbContext context)
        {
            _dbContext = context;
        }
        public async Task<Products> GetAsync(Guid productsId)
        {
            try
            {
                var data = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(productsId));
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


using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.IssueManagement.Repository
{
    public class CategoriesRepository : ICategoriesRepository, ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public CategoriesRepository(IPhamacyManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Categories> GetAsync(Guid cateogoryId)
        {
            try
            {
                var data = await _dbContext.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(cateogoryId));
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

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
    public class OrderRepository : IOrderRepository, ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _dbContext;
        public OrderRepository(IPhamacyManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> GetAsync(Guid id)
        {
            var data = await _dbContext.Orders.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(id));
            if(data == null) return null;
            return data;
        }
    }
}

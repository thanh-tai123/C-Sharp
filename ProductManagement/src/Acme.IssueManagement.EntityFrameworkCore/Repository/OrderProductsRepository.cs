using Acme.IssueManagement.Entities;
using Acme.IssueManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Repository
{
    public class OrderProductsRepository : IOrderProductsRepository
    {
        private readonly IIssueManagementDbContext _dbContext;

        public OrderProductsRepository(IIssueManagementDbContext context)
        {
            _dbContext = context;
        }
        public async Task<OrderProducts> GetAsync(Guid ordersproductId)
        {
            try
            {
                var data = await _dbContext.OrderProducts.AsNoTracking().FirstOrDefaultAsync(c => c.Id.Equals(ordersproductId));
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

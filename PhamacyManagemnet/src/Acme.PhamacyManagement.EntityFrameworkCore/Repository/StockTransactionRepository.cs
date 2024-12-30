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
   public  class StockTransactionRepository : IStockTransactionRepository, ISingletonDependency
    {
        private readonly IPhamacyManagementDbContext _context;
        public StockTransactionRepository(IPhamacyManagementDbContext context)
        {
            _context = context;
        }

        public async Task<StockTransaction> GetAsync(Guid id)
        {
            try
            {
                var data = await _context.StockTransactions.AsNoTracking().SingleOrDefaultAsync(c => c.Equals(id));
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

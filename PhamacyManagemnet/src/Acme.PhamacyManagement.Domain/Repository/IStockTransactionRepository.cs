using Acme.PhamacyManagement.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.Repository
{
    public interface IStockTransactionRepository
    {
        Task<StockTransaction> GetAsync(Guid id);
    }
}

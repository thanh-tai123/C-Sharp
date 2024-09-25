using Acme.IssueManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Repository
{
    public interface IOrderProductsRepository
    {
        Task<OrderProducts> GetAsync(Guid orderId);
    }
}

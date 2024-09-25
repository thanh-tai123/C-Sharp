using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Repository
{
    public interface IProductsRepository
    {
        Task<Products> GetAsync(Guid productsId);
    }
}

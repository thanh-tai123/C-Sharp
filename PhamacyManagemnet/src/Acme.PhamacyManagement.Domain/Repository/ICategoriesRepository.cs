
using Acme.PhamacyManagement.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Repository
{
    public interface ICategoriesRepository
    {
        Task<Categories> GetAsync(Guid cateogoryId);
    }
}

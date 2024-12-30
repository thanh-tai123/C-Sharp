using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IProductUnitServices
    {
        Task<List<ProductUnitDTO>> GetListAsync();
    }
}

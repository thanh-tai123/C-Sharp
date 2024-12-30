using Acme.PhamacyManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.IServices
{
    public interface IProductPriceService
    {
        Task<List<ProductPriceDTO>> GetListAsync();
    }
}

using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.Controller
{
    [Route("api/productprice")]
    public class ProductPriceController : PhamacyManagementController
    {
        private readonly IProductPriceService _productPriceService;
        public ProductPriceController(IProductPriceService productPriceService)
        {
           _productPriceService = productPriceService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductPriceDTO>>> GetListAsync()
        {
            try
            {

                var data = await _productPriceService.GetListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

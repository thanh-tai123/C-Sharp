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
    [Route("api/productunit")]
    public class ProductUnitController : PhamacyManagementController
    {
        private readonly IProductUnitServices _productUnitServices;
       public ProductUnitController(IProductUnitServices productUnitServices)
        {
            _productUnitServices = productUnitServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductUnitDTO>>> GetListAsync()
        {
            try
            {

                var data = await _productUnitServices.GetListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

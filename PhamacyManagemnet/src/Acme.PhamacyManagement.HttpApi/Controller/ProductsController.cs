using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.IServices;

using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.PhamacyManagement.Controller
{
    [Route("api/products")]
    public class ProductsController : PhamacyManagementController
    {
        private readonly IProductsServices _productsServices;
        public ProductsController(IProductsServices productsServices)
        {
            _productsServices = productsServices;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductsDTO>>> GetListAsync()
        {
            try
            {

                var data = await _productsServices.GetListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

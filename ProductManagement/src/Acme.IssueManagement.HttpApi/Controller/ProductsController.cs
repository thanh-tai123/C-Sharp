using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Controller
{
    [Route("api/products")]
    public class ProductsController : IssueManagementController
    {
        private readonly IProductsServices _productAppService;

        public ProductsController(IProductsServices bookAppService)
        {
            _productAppService = bookAppService;
        }

        //[HttpGet]
        //public async Task<List<ProductsDto>> GetListAsync()
        //{
        //    try
        //    {
        //        return await _productAppService.GetListAsync();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        [HttpGet]
        public async Task<List<ProductsDto>> GetListAsync(string search = null, 
                                                          string sortBy = null,
                                                          double? minPrice = null,
                                                          double? maxPrice = null,
                                                          int pageNumber = 1,
                                                          int pageSize = 5)  
        {
            try
            {
                var products = await _productAppService.GetListAsync(search, sortBy, minPrice, maxPrice, pageNumber, pageSize);
                return products;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsDto>> GetAsync(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return NotFound(); 
                }

                var product = await _productAppService.GetAsync(id);

                if (product == null)
                {
                    return NotFound(); 
                }

                return Ok(product); 
            }
            catch (Exception ex)
            {
             
                return StatusCode(500, "Internal server error: " + ex.Message); 
            }
        }

        [HttpPost]
        public async Task<ProductsDto> CreateAsync(CreateUpdateProductsDto input)
        {
            try
            {
               
                return await _productAppService.CreateAsync(input);

            }
            catch(Exception ex) 
            {
                throw ex;
            }
           
        }

        [HttpPut("{id}")]
        public async Task<ProductsDto> UpdateAsync(Guid id, CreateUpdateProductsDto input)
        {
            return await _productAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _productAppService.DeleteAsync(id);
        }
    }
}

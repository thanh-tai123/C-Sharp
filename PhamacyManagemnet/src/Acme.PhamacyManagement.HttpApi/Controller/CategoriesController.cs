using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.IServices;

using Acme.PhamacyManagement;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.IssueManagement.Controller
{
    [Route("api/categories")]
    public class CategoriesController : PhamacyManagementController
    {
        private readonly ICategoriesServices _categoriesServices;

        public CategoriesController(ICategoriesServices categoriesService)
        {
            _categoriesServices = categoriesService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriesDTO>> GetAsync(Guid id)
        {
            try
            {
                var result = await _categoriesServices.GetAsync(id);
                return Ok(result);
            }
            catch (UserFriendlyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                // Log more details
                return StatusCode(500, new { message = "An internal error occurred", details = ex.Message });
            }
        }
        [HttpPut("{id}")]
        public async Task<CategoriesDTO> UpdateAsync(Guid id, UpdateCategoriesDTO input)
        {
            try
            {
                return await _categoriesServices.UpdateAsync(id, input);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet]
        public async Task<ActionResult<List<CategoriesDTO>>> GetListAsync()
        {
            try
            {
                var result = await _categoriesServices.GetListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving categories", details = ex.Message });
            }
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<ActionResult> CreateAsync(CreateCategoriesDTO input)
        {
            try
            {
                await _categoriesServices.CreateAsync(input);
                return Ok(new { message = "Category created successfully." });
            }
            catch (UserFriendlyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (BusinessException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the category.", details = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                await _categoriesServices.DeleteAsync(id);
                return Ok("Deleted.");
            }
            catch (UserFriendlyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the category.", details = ex.Message });
            }
        }
    }

}

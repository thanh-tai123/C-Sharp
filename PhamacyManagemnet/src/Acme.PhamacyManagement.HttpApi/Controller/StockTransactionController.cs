using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.IServices;
using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.PhamacyManagement.Controller
{
    [Route("api/stock")]
    public class StockTransactionContronller : PhamacyManagementController
    {
        private readonly IStockTransactionService _stockTransactionService;
        public StockTransactionContronller(IStockTransactionService stockTransactionService)
        {
            _stockTransactionService = stockTransactionService;
        }


        [HttpGet]
        public async Task<ActionResult<List<StockTransactionDTO>>> GetListAsync()
        {
            try
            {
                var result = await _stockTransactionService.GetListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving categories", details = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateStockTransactionDTO input)
        {
            try
            {
                await _stockTransactionService.CreateAsync(input);
                return Ok(new { message = "StockTransaction created successfully." });
            }
            catch (UserFriendlyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the category.", details = ex.Message });
            }
        }
    }
}

    

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
    [Route("api/warehouse")]
    public class WarehouseController : PhamacyManagementController
    {
        private readonly IWarehouseServices _warehouseServices;

        public WarehouseController(IWarehouseServices warehouseService)
        {
            _warehouseServices=warehouseService;
        }


        [HttpGet]
        public async Task<ActionResult<List<WarehouseDTO>>> GetListAsync()
        {
            try
            {
                var result = await _warehouseServices.GetListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log error here
            

                return StatusCode(500, new
                {
                    message = "An error occurred while retrieving warehouse list",
                    details = ex.Message
                });
            }
        }


    }
}

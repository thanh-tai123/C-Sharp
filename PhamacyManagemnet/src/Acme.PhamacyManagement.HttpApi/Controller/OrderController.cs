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
    [Route("api/orders")]
    public class OrderController : PhamacyManagementController
    {
        private readonly IOrderServices _orderServices;
        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        [HttpGet("id")]
        public async Task<ActionResult<OrderDTO>> GetAsync(Guid id)
        {
            try
            {
                var data = await _orderServices.GetAsync(id);
                return Ok(data);
            }
            catch (UserFriendlyException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex) {
                {
                    return StatusCode(500, new { message = "An internal error occurred", details = ex.Message });
                }

            }
        }
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<ActionResult>  Create(CreateOrderDto orderDTO)
        {
            try
            {
                await _orderServices.CreateAsync(orderDTO);
                return Ok(new {message = "Order Successfuly"});
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
    }
}

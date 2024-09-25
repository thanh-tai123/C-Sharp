using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.IServices;
using Acme.IssueManagement.Services;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.IssueManagement.Controller
{
    [Route("api/orders")]
    public class OrderProductController : IssueManagementController
    {
        private readonly IOrderProductsServices _orderproductAppService;

        public OrderProductController(IOrderProductsServices orderbookAppService)
        {
            _orderproductAppService = orderbookAppService;
        }
        [HttpGet]
        public async Task<List<OrderProductsDTO>> GetListAsync()
        {
            try
            {
                return await _orderproductAppService.GetListAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("{id}")]
        public async Task<GetOrderProductsDTO> GetAsync(Guid id)
        {
            try
            {
                return await _orderproductAppService.GetAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<OrderProductsDTO> CreateAsync(CreateOrderProductsDTO input)
        {
            try
            {
                return await _orderproductAppService.CreateAsync(input);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}

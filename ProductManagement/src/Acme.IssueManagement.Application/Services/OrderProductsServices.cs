using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.Entities;
using Acme.IssueManagement.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.IssueManagement.Services
{
    public class OrderProductsServices : IssueManagementAppService, IOrderProductsServices
    {
        private readonly IRepository<OrderProducts, Guid> _orderproductsRepository;
        private readonly IRepository<Products, Guid> _productsRepository;
        public OrderProductsServices(IRepository<OrderProducts, Guid> orderproductsRepository, IRepository<Products, Guid> productsRepository)
        {
            _orderproductsRepository = orderproductsRepository;
            _productsRepository = productsRepository;
        }

        public async Task<OrderProductsDTO> CreateAsync(CreateOrderProductsDTO input)
        {
          
            var product = await _productsRepository.GetAsync(input.ProductsId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }
           
            if (product.Quanlity < input.Quanlity)
            {
                throw new Exception("Insufficient product quantity.");
            }

        
            product.Quanlity -= input.Quanlity;

           
            await _productsRepository.UpdateAsync(product);

        
            var order = ObjectMapper.Map<CreateOrderProductsDTO, OrderProducts>(input);
            order.Total = input.Quanlity * (decimal)product.Price;
            await _orderproductsRepository.InsertAsync(order);

            // Return the created order
            return ObjectMapper.Map<OrderProducts, OrderProductsDTO>(order);
        }


        public async Task<GetOrderProductsDTO> GetAsync(Guid id)
        {
            var order = await _orderproductsRepository.GetAsync(id);
            return ObjectMapper.Map<OrderProducts, GetOrderProductsDTO>(order);
        }

        public async Task<List<OrderProductsDTO>> GetListAsync()
        {
            var orders = await _orderproductsRepository.GetListAsync();
            return ObjectMapper.Map<List<OrderProducts>, List<OrderProductsDTO>>(orders);

        }
    }
}

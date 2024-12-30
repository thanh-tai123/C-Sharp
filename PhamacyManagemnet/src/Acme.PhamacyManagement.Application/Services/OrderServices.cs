using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.IServices;
using Acme.PhamacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.PhamacyManagement.Services
{
    public class OrderServices : PhamacyManagementAppService, IOrderServices
    {
        //private readonly IOrderRepository _orderRepository;
        private readonly IRepository<Order, Guid> _repository;
        private readonly IRepository<OrderDetail, Guid> _orderDetailRepository;
        public OrderServices( IRepository<Order, Guid> repository, IRepository<OrderDetail, Guid> orderDetailRepository)
        {
           
            _repository = repository;
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<OrderDTO> CreateAsync(CreateOrderDto input)
        {
            var order = ObjectMapper.Map<CreateOrderDto, Order>(input);
            await _repository.InsertAsync(order);

            try
            {
                foreach (var detail in input.OrderProducts)
                {
                    var orderDetail = ObjectMapper.Map<CreateOrderDetailDto, OrderDetail>(detail);
                    orderDetail.OrderId = order.Id;
                    await _orderDetailRepository.InsertAsync(orderDetail);
                }
            }
            catch (Exception ex)
            {
               
                throw new Exception("Failed to create order details. Original error: " + ex.Message);
            }

            return ObjectMapper.Map<Order, OrderDTO>(order);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDTO>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderDTO> UpdateAsync(Guid id, UpdateOrderDTO input)
        {
            throw new NotImplementedException();
        }
    }
}

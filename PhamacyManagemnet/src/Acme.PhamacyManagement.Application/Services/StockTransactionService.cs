using Acme.IssueManagement.Dtos;
using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.Entity;
using Acme.PhamacyManagement.IServices;
using Acme.PhamacyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.PhamacyManagement.Services
{
   public  class StockTransactionService : PhamacyManagementAppService, IStockTransactionService
    {
        private readonly IStockTransactionRepository _stockTransactionRepository;
        private readonly IRepository<StockTransaction,Guid> _repository;
        public StockTransactionService(IStockTransactionRepository stockTransactionRepository, IRepository<StockTransaction,Guid> repository)
        {
            _stockTransactionRepository = stockTransactionRepository;
            _repository = repository;
        }

        public async Task<StockTransactionDTO> CreateAsync(CreateStockTransactionDTO input)
        {
            try
            {
               
                string transactionCode = GenerateRandomCode(8);
                var stocktran = ObjectMapper.Map<CreateStockTransactionDTO, StockTransaction>(input);

               
                stocktran.TranctionCode = transactionCode;

                stocktran.TranctionDate = DateTime.Now;

                await _repository.InsertAsync(stocktran);
                return ObjectMapper.Map<StockTransaction, StockTransactionDTO>(stocktran);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        public Task<StockTransactionDTO> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StockTransactionDTO>> GetListAsync()
        {

            try
            {
                var data = await _repository.GetListAsync();
                if (data == null || data.Count == 0)
                {
                    throw new UserFriendlyException("Not Found");
                }
                return ObjectMapper.Map<List<StockTransaction>, List<StockTransactionDTO>>(data);
            }
            catch (UserFriendlyException)
            {
                throw; // Let UserFriendlyException pass through
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                // _logger.LogError(ex, "An error occurred while getting the warehouse list.");
                throw ex;
            }
        }
    }
    }


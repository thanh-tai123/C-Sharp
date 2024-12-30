using Acme.IssueManagement.Dtos;

using Acme.IssueManagement.IServices;
using Acme.IssueManagement.Repository;
using Acme.PhamacyManagement;
using Acme.PhamacyManagement.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.IssueManagement.Services
{
  public class CategoriesServices : PhamacyManagementAppService, ICategoriesServices
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IRepository<Categories, Guid> _repository;
        private readonly ILogger<CategoriesServices> _logger;

        public CategoriesServices(ICategoriesRepository categoriesRepository, IRepository<Categories, Guid> repository, ILogger<CategoriesServices> logger)
        {
            _categoriesRepository = categoriesRepository;
            _repository = repository;
            _logger = logger;
        }

        public async Task<CategoriesDTO> CreateAsync(CreateCategoriesDTO input)
        {
            try
            {
                var categories = ObjectMapper.Map<CreateCategoriesDTO, Categories>(input);
                if (input.CategoryName.IsNullOrEmpty())
                {
                    throw new BusinessException(PhamacyManagementErrorCodes.ERROR_INVALID_INPUT).WithData("fields", nameof(input.CategoryName));
                }
                await _repository.InsertAsync(categories);
                return ObjectMapper.Map<Categories, CategoriesDTO>(categories);
            }
            catch (BusinessException ex)
            {
                // Log the business exception if necessary
                throw; // Re-throw the business exception to be handled by the middleware
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                throw ex;
            }
        }

        public async Task<CategoriesDTO> GetAsync(Guid id)
        {
            try
            {
                var category = await _categoriesRepository.GetAsync(id);
                if (category == null)
                {
                    throw new UserFriendlyException("Category not found").WithData("CategoryId", id);
                }
                return ObjectMapper.Map<Categories, CategoriesDTO>(category);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in GetAsync with id {id}", id);
                //throw new UserFriendlyException("An error occurred while retrieving the category.", ex);
                throw ex;
            }
        }

        public async Task<List<CategoriesDTO>> GetListAsync()
        {
            try
            {
                var categories = await _repository.GetListAsync();
                return ObjectMapper.Map<List<Categories>, List<CategoriesDTO>>(categories);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in GetListAsync");
                //throw new UserFriendlyException("An error occurred while retrieving the categories.", ex);
                throw ex;
            }
        }

        public async Task<CategoriesDTO> UpdateAsync(Guid id, UpdateCategoriesDTO input)
        {
            try
            {
                var category = await _repository.GetAsync(id);
                if (category == null)
                {
                    throw new UserFriendlyException("Category not found");
                }

                ObjectMapper.Map(input, category);
                await _repository.UpdateAsync(category);
                return ObjectMapper.Map<Categories, CategoriesDTO>(category);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in UpdateAsync with input {input}", input);
                throw ex;
                //throw new UserFriendlyException("An error occurred while updating the category.", ex);
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                var category = await _repository.FindAsync(id);
                if (category == null)
                {
                    throw new UserFriendlyException("Category not found");
                }
                await _repository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error occurred in DeleteAsync with id {id}", id);
                //throw new UserFriendlyException("An error occurred while deleting the category.", ex);
                throw ex;
            }
        }
    }

}

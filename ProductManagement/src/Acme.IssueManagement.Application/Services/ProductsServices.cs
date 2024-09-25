using Acme.IssueManagement.Books;
using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace Acme.IssueManagement.Services
{
    public class ProductsServices : IssueManagementAppService, IProductsServices
    {
        private readonly IRepository<Products, Guid> _productsRepository;

        public ProductsServices(IRepository<Products, Guid> productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<ProductsDto> CreateAsync(CreateUpdateProductsDto input)
        {
            var product = ObjectMapper.Map<CreateUpdateProductsDto, Products>(input);
            await _productsRepository.InsertAsync(product);
            return ObjectMapper.Map<Products, ProductsDto>(product);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productsRepository.DeleteAsync(id);
        }

        public async Task<ProductsDto> GetAsync(Guid id)
        {
            var product = await _productsRepository.GetAsync(id);
            return ObjectMapper.Map<Products, ProductsDto>(product);
        }

        //public async Task<List<ProductsDto>> GetListAsync()
        //{
        //    var products = await _productsRepository.GetListAsync();
        //    return ObjectMapper.Map<List<Products>, List<ProductsDto>>(products);
        //}
        public async Task<List<ProductsDto>> GetListAsync(
    string search = null,
    string sortBy = null,
    double? minPrice = null,
    double? maxPrice = null,
    int pageNumber = 1,
    int pageSize = 10)  // Default page size
        {
            var products = await _productsRepository.GetListAsync();

            // Filter by search term
            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.Where(p => p.Name.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Filter by price range
            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value).ToList();
            }
            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value).ToList();
            }

            // Sort by specified criteria
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "priceasc":
                        products = products.OrderBy(p => p.Price).ToList();
                        break;
                    case "pricedesc":
                        products = products.OrderByDescending(p => p.Price).ToList();
                        break;
                    case "name":
                        products = products.OrderBy(p => p.Name).ToList();
                        break;
                    default:
                        // Default sorting can be implemented here if needed
                        break;
                }
            }

            // Apply pagination
            var pagedProducts = products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return ObjectMapper.Map<List<Products>, List<ProductsDto>>(pagedProducts);
        }

       

        public async Task<ProductsDto> UpdateAsync(Guid id, CreateUpdateProductsDto input)
        {
            var product = await _productsRepository.GetAsync(id);
            ObjectMapper.Map(input, product);
            await _productsRepository.UpdateAsync(product);
            return ObjectMapper.Map<Products, ProductsDto>(product);
        }
    }
}

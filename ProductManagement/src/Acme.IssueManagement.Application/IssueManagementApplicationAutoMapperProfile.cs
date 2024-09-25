using Acme.IssueManagement.Books;
using Acme.IssueManagement.Dtos;
using Acme.IssueManagement.Entities;
using AutoMapper;

namespace Acme.IssueManagement;

public class IssueManagementApplicationAutoMapperProfile : Profile
{
    public IssueManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
      

        // Map from CreateBookDTO to Book
        CreateMap<CreateBookDTO, Book>()
           .ForMember(dts => dts.Id, opts => opts.Ignore())
           .ReverseMap();

        // Optional: If you want to map from BookDTO back to Book
        CreateMap<BookDTO, Book>()
             .ForMember(dts => dts.Id, opts => opts.Ignore())
           .ReverseMap();
       

        //
        CreateMap<Products, ProductsDto>().ReverseMap();
        CreateMap<CreateUpdateProductsDto, Products>();

        CreateMap<OrderProducts,OrderProductsDTO>().ReverseMap();
        CreateMap<CreateOrderProductsDTO, OrderProducts>();

        CreateMap<OrderProducts, GetOrderProductsDTO>().ReverseMap();
    }
}

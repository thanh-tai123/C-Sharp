using Acme.IssueManagement.Dtos;
using Acme.PhamacyManagement.Dto;
using Acme.PhamacyManagement.Entity;
using AutoMapper;
using System.Collections.Generic;

namespace Acme.PhamacyManagement;

public class PhamacyManagementApplicationAutoMapperProfile : Profile
{
    public PhamacyManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        //CreateMap<CreateCategoriesDTO, Categories>().ReverseMap();
        CreateMap<CreateCategoriesDTO, Categories>();
        CreateMap<Categories, CategoriesDTO>();
        CreateMap<CreateWarehouseDTO, Warehouse>();
        CreateMap<Warehouse, WarehouseDTO>();
        CreateMap<CreateProductsDTO, Products>();
        CreateMap<Products, ProductsDTO>();
        CreateMap<ProductUnits, ProductUnitDTO>();
        CreateMap<ProductPrice ,ProductPriceDTO>();
        CreateMap<StockTransaction, StockTransactionDTO>();
        CreateMap<CreateStockTransactionDTO, StockTransaction>();

        CreateMap<CreateOrderDto, Order>();

        CreateMap<CreateOrderDetailDto, OrderDetail>();

        CreateMap<Order, OrderDTO>();
        CreateMap<OrderDetail, CreateOrderDetailDto>();
        CreateMap<OrderDetail, OrderDetailDTO>();
    }
}

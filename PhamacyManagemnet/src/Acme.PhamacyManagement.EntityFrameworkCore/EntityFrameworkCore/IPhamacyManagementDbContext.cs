using Acme.PhamacyManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.PhamacyManagement.EntityFrameworkCore;

[ConnectionStringName(PhamacyManagementDbProperties.ConnectionStringName)]
public interface IPhamacyManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Categories> Categories { get; }
    DbSet<Products> Products { get; }
    DbSet<Order> Orders { get; }
    DbSet<OrderDetail> OrderDetails { get; }
    DbSet<Discount> Discounts { get; }
    DbSet<ProductUnits> ProductUnits { get; }
    DbSet<Unit> Units { get; }
    DbSet<Warehouse> Warehouse { get; }
    DbSet<WarehouseProduct> WarehouseProducts { get; }
    DbSet<Supplier> Suppliers { get; }
     DbSet<ProductPrice> ProductPrices {  get; }
    DbSet<StockTransaction> StockTransactions { get; }
}

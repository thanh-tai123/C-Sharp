using Acme.PhamacyManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.PhamacyManagement.EntityFrameworkCore;

[ConnectionStringName(PhamacyManagementDbProperties.ConnectionStringName)]
public class PhamacyManagementDbContext : AbpDbContext<PhamacyManagementDbContext>, IPhamacyManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Products> Products { get; }
    public DbSet<Order> Orders { get; }
    public DbSet<OrderDetail> OrderDetails { get; }
    public DbSet<Discount> Discounts { get; }
    public DbSet<ProductUnits> ProductUnits { get; }
    public DbSet<Unit> Units { get; }
    public DbSet<Warehouse> Warehouse { get; }
    public DbSet<WarehouseProduct> WarehouseProducts { get; }
    public DbSet<Supplier> Suppliers { get; }
    public DbSet<ProductPrice> ProductPrices { get; }
    public DbSet<StockTransaction> StockTransactions { get; }
    public PhamacyManagementDbContext(DbContextOptions<PhamacyManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePhamacyManagement();
        builder.Entity<Categories>(b =>
        {
            b.ToTable("Categories");

            b.ConfigureByConvention();
        });

        builder.Entity<Products>(b =>
        {
            b.ToTable("Products");

            b.ConfigureByConvention();
        });
        builder.Entity<Order>(b =>
        {
            b.ToTable("Order");

            b.ConfigureByConvention();
        });
        builder.Entity<OrderDetail>(b =>
        {
            b.ToTable("OrderDetail");
            b.HasOne<Order>()
             .WithMany()
             .HasForeignKey(op => op.OrderId);

            b.ConfigureByConvention();
        });
        builder.Entity<Discount>(b =>
        {
            b.ToTable("Discount");

            b.ConfigureByConvention();
        });

        //
        builder.Entity<ProductUnits>(b =>
        {
            b.ToTable("ProductUnits");

            b.ConfigureByConvention();
        });

        builder.Entity<Unit>(b =>
        {
            b.ToTable("Unit");

            b.ConfigureByConvention();
        });
        builder.Entity<Warehouse>(b =>
        {
            b.ToTable("Warehouse");

            b.ConfigureByConvention();
        });
        builder.Entity<WarehouseProduct>(b =>
        {
            b.ToTable("WarehouseProduct");

            b.ConfigureByConvention();
        });
        builder.Entity<Supplier>(b =>
        {
            b.ToTable("Supplier");

            b.ConfigureByConvention();
        });
        builder.Entity<ProductPrice>(b =>
        {
            b.ToTable("ProductPrice");

            b.ConfigureByConvention();
        });
        builder.Entity<StockTransaction>(b =>
        {
            b.ToTable("StockTransaction");

            b.ConfigureByConvention();
        });
        //builder.Entity<ProductTransaction>(b =>
        //{
        //    b.ToTable("ProductTransaction");

        //    b.ConfigureByConvention();
        //});
        //builder.Entity<ProductTransactionDetail>(b =>
        //{
        //    b.ToTable("ProductTransactionDetail");

        //    b.ConfigureByConvention();
        //});
    }
}

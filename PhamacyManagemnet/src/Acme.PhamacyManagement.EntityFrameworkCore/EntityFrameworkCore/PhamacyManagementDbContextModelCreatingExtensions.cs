using Acme.PhamacyManagement.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.PhamacyManagement.EntityFrameworkCore;

public static class PhamacyManagementDbContextModelCreatingExtensions
{
    public static void ConfigurePhamacyManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(PhamacyManagementDbProperties.DbTablePrefix + "Questions", PhamacyManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
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

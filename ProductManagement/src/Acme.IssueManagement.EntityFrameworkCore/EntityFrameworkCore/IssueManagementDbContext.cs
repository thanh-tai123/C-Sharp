using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;
namespace Acme.IssueManagement.EntityFrameworkCore;

[ConnectionStringName(IssueManagementDbProperties.ConnectionStringName)]
public class IssueManagementDbContext : AbpDbContext<IssueManagementDbContext>, IIssueManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Book> Books { get; set; }
  
    public DbSet<Products> Products { get; set; }
    public DbSet<OrderProducts> OrderProducts { get; set; }
    public IssueManagementDbContext(DbContextOptions<IssueManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureIssueManagement();
        builder.Entity<Products>(b =>
        {
            b.ToTable("Products"); // Đặt tên bảng
            b.ConfigureByConvention(); // Cấu hình theo quy ước
        }); 
        builder.Entity<OrderProducts>(b =>
        {
            b.ToTable("OrderProducts"); // Đặt tên bảng
            b.ConfigureByConvention(); // Cấu hình theo quy ước
        });
    }
}

using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.IssueManagement.EntityFrameworkCore;

[ConnectionStringName(IssueManagementDbProperties.ConnectionStringName)]
public interface IIssueManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    public DbSet<Book> Books { get; set; }
  
    public DbSet<Products>  Products { get; set; }
    public DbSet<OrderProducts> OrderProducts { get; set; }

}

using Acme.IssueManagement.Books;
using Acme.IssueManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.IssueManagement.EntityFrameworkCore
{



    public static class IssueManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureIssueManagement(
            this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            
            builder.Entity<Book>(
           b =>
           {
               b.ToTable("Books");
               b.ConfigureByConvention();
           });
            
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
}
/* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(IssueManagementDbProperties.DbTablePrefix + "Questions", IssueManagementDbProperties.DbSchema);

                b.ConfigureByConvention();

                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
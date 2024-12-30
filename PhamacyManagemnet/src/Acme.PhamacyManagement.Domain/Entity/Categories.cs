using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Categories : Entity<Guid>
    {
        public string CategoryName { get; set; }
    }
}

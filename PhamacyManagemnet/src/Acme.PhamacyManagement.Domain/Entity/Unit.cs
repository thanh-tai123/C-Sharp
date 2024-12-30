using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Unit : Entity<Guid>
    {
        public string UnitCode { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}

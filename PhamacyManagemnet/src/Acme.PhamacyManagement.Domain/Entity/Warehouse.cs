using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Warehouse : Entity<Guid>
    {
        
            public string WarehouseCode { get; set; }
            public string Name { get; set; }
            public string Address { get; set; } // Fixed typo
            public string Phone { get; set; }
            public DateTime CreatedDate { get; set; } = DateTime.Now; // Updated property name
            public DateTime UpdatedDate { get; set; } = DateTime.Now; // Updated property name
            public string CreatedBy { get; set; } // Updated property name
            public string UpdatedBy { get; set; } // Updated property name
        }

    
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.PhamacyManagement.Dto
{
    public class WarehouseDTO : EntityDto<Guid>
    {
        public string WarehouseCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } // Fixed typo
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Updated property name
        public DateTime UpdatedDate { get; set; } = DateTime.Now; // Updated property name
        public string CreatedBy { get; set; } // Updated property name
        public string UpdatedBy { get; set; } 
    }

    public class CreateWarehouseDTO {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
      
        public string CreatedBy { get; set; }

    }
    public class UpdateWarehouseDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; }

    }
}

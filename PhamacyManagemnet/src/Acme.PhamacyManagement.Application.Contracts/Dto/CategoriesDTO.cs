using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.IssueManagement.Dtos
{
    public class CategoriesDTO : EntityDto<Guid>
    {
        public string CategoryName { get; set; }
    }
    public class CreateCategoriesDTO
    {

        public string CategoryName { get; set; }
    }
    public class UpdateCategoriesDTO
    {

        public string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Acme.PhamacyManagement.Entity
{
    public class Products : Entity<Guid>
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DosageForm {  get; set; } //Dang Bao Che
        public string Ingredients { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Uses { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public DateTime UpdateDate { get; set; }= DateTime.Now;
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public Guid CategoriesID { get; set; }
    }
}

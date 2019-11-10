namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string Metatitle { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(50)]
        public string SeoTitle { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(50)]
        public string Metakeywords { get; set; }

        [StringLength(50)]
        public string MetaDicription { get; set; }

        public bool? Status { get; set; }

        public bool? ShowOnHome { get; set; }

        public long? PaterID { get; set; }
    }
}

namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string PHONE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public bool? STATUS { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string content { get; set; }
    }
}

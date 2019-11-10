namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Text { get; set; }

        [StringLength(50)]
        public string Link { get; set; }

        public int? Displayorder { get; set; }

        [StringLength(50)]
        public string target { get; set; }

        public bool? status { get; set; }

        public int? typeID { get; set; }
    }
}

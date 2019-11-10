namespace SaleShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="This fiel is required!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "This fiel is required!")]
        [StringLength(50)]
        public string Password { get; set; }

        public bool Status { get; set; }
        [Required(ErrorMessage = "This fiel is required!")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "This fiel is required!")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "This fiel is required!")]
        [StringLength(50)]
        public string Phone { get; set; }

        public int? provinceID { get; set; }

        public int? districtID { get; set; }

        public int? precinctID { get; set; }

        [StringLength(50)]
        public string GruopID { get; set; }
    }
}

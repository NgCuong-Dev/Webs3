namespace baitapltw.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(200)]
        public string FeatureImage { get; set; }

        public int CateID { get; set; }

        [StringLength(500)]
        public string Des { get; set; }

        public virtual Category Category { get; set; }
    }
}

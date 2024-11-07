namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            AttributesPrices = new HashSet<AttributesPrice>();
        }

        public int ProductID { get; set; }

        [StringLength(250)]
        public string ProductName { get; set; }

        [StringLength(250)]
        public string ShortDesc { get; set; }

        public string Description { get; set; }

        public int? CatID { get; set; }

        public int? Price { get; set; }

        public int? Discount { get; set; }

        [StringLength(250)]
        public string Thumb { get; set; }

        [StringLength(250)]
        public string Video { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool? BestSellers { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? Active { get; set; }

        public string Tags { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Alias { get; set; }

        [StringLength(250)]
        public string MetaDesc { get; set; }

        [StringLength(250)]
        public string MetaKey { get; set; }

        public int? UnitslnStock { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttributesPrice> AttributesPrices { get; set; }

        public virtual Category Category { get; set; }
    }
}

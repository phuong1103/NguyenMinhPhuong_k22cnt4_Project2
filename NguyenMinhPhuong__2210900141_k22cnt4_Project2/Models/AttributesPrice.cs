namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttributesPrice
    {
        public int AttributesPriceID { get; set; }

        public int? AttributesID { get; set; }

        public int? ProductID { get; set; }

        public decimal? Price { get; set; }

        public bool? Active { get; set; }

        public virtual Attribute Attribute { get; set; }

        public virtual Product Product { get; set; }
    }
}

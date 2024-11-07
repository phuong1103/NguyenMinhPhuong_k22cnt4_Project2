namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Locatinon
    {
        [Key]
        public int LocationID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(150)]
        public string Slug { get; set; }

        [StringLength(250)]
        public string NameWithType { get; set; }

        [StringLength(250)]
        public string PathWithType { get; set; }

        public int? ParentCode { get; set; }

        public int? Levels { get; set; }
    }
}

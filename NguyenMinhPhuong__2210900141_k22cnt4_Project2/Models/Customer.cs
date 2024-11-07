namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerID { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(250)]
        public string Avatar { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Email { get; set; }

        public int? LocatinonID { get; set; }

        public int? District { get; set; }

        public int? Ward { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(10)]
        public string Salt { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        public int AccountID { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(10)]
        public string Sail { get; set; }

        public bool Active { get; set; }

        [StringLength(150)]
        public string FullName { get; set; }

        public int? RoleID { get; set; }

        public DateTime? LastLogin { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual Role Role { get; set; }
    }
}

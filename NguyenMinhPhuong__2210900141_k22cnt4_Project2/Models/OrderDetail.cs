namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        public int? OrderNumber { get; set; }

        public int? Quantity { get; set; }

        public int? Discount { get; set; }

        public int? Total { get; set; }

        public DateTime? ShipDate { get; set; }

        public virtual Order Order { get; set; }
    }
}

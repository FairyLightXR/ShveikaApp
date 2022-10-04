namespace ShveikaApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Product = new HashSet<Product>();
        }

        public int OrderID { get; set; }

        [Required]
        [StringLength(250)]
        public string OrderInfo { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime OrderDeliveryDate { get; set; }

        public int OrderPickupPointID { get; set; }

        [StringLength(150)]
        public string OrderClientFIO { get; set; }

        public short OrderPickupCode { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public virtual OrderPickupPoint OrderPickupPoint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}

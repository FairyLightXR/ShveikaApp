namespace ShveikaApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        [StringLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductMeasure { get; set; }

        public decimal ProductCost { get; set; }

        public byte ProductMaxDiscount { get; set; }

        [Required]
        public string ProductManufacturer { get; set; }

        public int ProductSupplierID { get; set; }

        [Required]
        public string ProductCategory { get; set; }

        public byte ProductDiscountAmount { get; set; }

        public int ProductQuantityInStock { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        public string ProductPhoto { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}

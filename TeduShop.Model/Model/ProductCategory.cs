﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("ProductCategories")]
    public class ProductCategory : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        [MaxLength(256)]
        public string Image { set; get; }

        [Required]
        [MaxLength(500)]
        public string Description { set; get; }

        public bool? HomeFlag { set; get; }

        [Required]
        public int? ParentID { set; get; }

        [Required]
        public int? DisplayOrder { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}
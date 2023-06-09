//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CakeShop.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductIngredients = new HashSet<ProductIngredient>();
        }
    
        public int Id { get; set; }
        public int ProductType { get; set; }
        public string Name { get; set; }
        public int Mass { get; set; }
        public int Color { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    
        public virtual Color Color1 { get; set; }
        public virtual ProductType ProductType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}

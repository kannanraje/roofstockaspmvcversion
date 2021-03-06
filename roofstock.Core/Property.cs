//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace roofstock.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.Addresses = new HashSet<Address>();
            this.Photos = new HashSet<Photo>();
        }
    
        public long PropertyId { get; set; }
        public long AccountId { get; set; }
        public string MainImageUrl { get; set; }
        public Nullable<int> Yearbuilt { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public Nullable<decimal> MonthlyRent { get; set; }
        public Nullable<decimal> GrossYield { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photo> Photos { get; set; }
    }
}

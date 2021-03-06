//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int id { get; set; }
        public string custom_order_id { get; set; }
        public int customer_id { get; set; }
        public string order_type { get; set; }
        public Nullable<decimal> total_payment { get; set; }
        public Nullable<decimal> payment_amount { get; set; }
        public Nullable<decimal> rest_amount { get; set; }
        public Nullable<bool> cancelled { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public string notes { get; set; }
        public Nullable<decimal> total_vat { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}

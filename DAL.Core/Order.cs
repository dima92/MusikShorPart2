//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrdersProducts = new HashSet<OrdersProduct>();
        }
    
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Amount { get; set; }
        public int TypeOrdersId { get; set; }
        public Nullable<int> AddressDeliveryId { get; set; }
        public System.DateTime DateShapingOrders { get; set; }
        public Nullable<System.DateTime> DatePurchase { get; set; }
        public Nullable<System.DateTime> DateCancel { get; set; }
        public decimal OrderSum { get; set; }
        public Nullable<int> PaymentRequisitesId { get; set; }
        public int NumberOrder { get; set; }
    
        public virtual AddressDelivery AddressDelivery { get; set; }
        public virtual PaymentRequisite PaymentRequisite { get; set; }
        public virtual Type_Order Type_Order { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}

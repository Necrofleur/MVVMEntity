//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic.UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrderHeaderSalesReason
    {
        public int SalesOrderID { get; set; }
        public int SalesReasonID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}

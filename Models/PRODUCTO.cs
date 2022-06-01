//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROYECTOMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public int REF_PRODUCTO { get; set; }
        public string NOM_PRODUCTO { get; set; }
        public Nullable<System.DateTime> FECHA_INGRESO { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<double> PRECIO_COMPRA { get; set; }
        public Nullable<double> PRECIO_VENTA { get; set; }
        public Nullable<int> DNI_PROVEEDOR { get; set; }
    
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}

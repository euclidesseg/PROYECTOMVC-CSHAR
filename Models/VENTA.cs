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
    
    public partial class VENTA
    {
        public int NUM_VENTA { get; set; }
        public Nullable<int> REF_PRODUCTO1 { get; set; }
        public string MEDIO_PAGO { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}

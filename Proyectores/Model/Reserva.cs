//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyectores.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public decimal ID { get; set; }
        public decimal ID_SALON { get; set; }
        public decimal ID_PERSONA { get; set; }
        public System.DateTime FECHA_RESERVA { get; set; }
        public System.DateTime FECHA_ALTA { get; set; }
        public Nullable<System.DateTime> FECHA_BAJA { get; set; }
        public Nullable<decimal> ID_MOTIVO_BAJA { get; set; }
        public System.DateTime H_DESDE { get; set; }
        public System.DateTime H_HASTA { get; set; }
    }
}

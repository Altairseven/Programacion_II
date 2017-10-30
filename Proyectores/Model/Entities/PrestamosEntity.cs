using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectores.Model.Entities {
    public class PrestamosEntity {

        public decimal ID { get; set; }
        public decimal ID_PROYECTOR { get; set; }
        public decimal ID_SALON { get; set; }
        public decimal ID_PERSONA { get; set; }
        public decimal? ID_RESERVA { get; set; }
        public DateTime H_DESDE { get; set; }
        public DateTime H_HASTA { get; set; }
        public int ACTIVO { get; set; }
        public DateTime FECHA { get; set; }


        public string APE_NOM { get; set; }
        public string TIPO_PERSONA { get; set; }
        public string SALON { get; set; }
        public string ButtonLB { get; set; }
        public string DesdeSrt { get; set; }
        public string HastaSrt { get; set; }


        public PrestamosEntity() {

        }

        public PrestamosEntity(Prestamos x) {
            ID = x.ID;
            ID_PROYECTOR = x.ID_PROYECTOR;
            ID_SALON = x.ID_SALON;
            ID_PERSONA = x.ID_PERSONA;
            ID_RESERVA = x.ID_RESERVA;
            H_DESDE = x.H_DESDE;
            H_HASTA = x.H_HASTA;
            DesdeSrt = x.H_DESDE.ToShortTimeString();
            HastaSrt = x.H_HASTA.ToShortTimeString();
            ACTIVO = x.ACTIVO;
            FECHA = x.FECHA;
        }
        public PrestamosEntity(Reserva x) {
            ID_SALON = x.ID_SALON;
            ID_PERSONA = x.ID_PERSONA;
            FECHA = x.FECHA_RESERVA;
            H_DESDE = x.H_DESDE;
            H_HASTA = x.H_HASTA;
            DesdeSrt = x.H_DESDE.ToShortTimeString();
            HastaSrt = x.H_HASTA.ToShortTimeString();
            ID_RESERVA = x.ID;

        }
    }
}

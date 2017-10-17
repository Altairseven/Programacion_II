﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model;

namespace Proyectores.Model.Entities {
    class ReservasEntity {

        public decimal ID { get; set; }
        public decimal ID_SALON { get; set; }
        public decimal ID_PERSONA { get; set; }
        public DateTime FECHA_RESERVA { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public DateTime? FECHA_BAJA { get; set; }
        public decimal? ID_MOTIVO_BAJA { get; set; }
        public DateTime H_DESDE { get; set; }
        public DateTime H_HASTA { get; set; }

        public ReservasEntity() {

        }

        public ReservasEntity(Reserva x) {
            ID = x.ID;
            ID_SALON = x.ID_SALON;
            ID_PERSONA = x.ID_PERSONA;
            FECHA_RESERVA = x.FECHA_RESERVA;
            FECHA_ALTA = x.FECHA_ALTA;
            FECHA_BAJA = x.FECHA_BAJA;
            ID_MOTIVO_BAJA = x.ID_MOTIVO_BAJA;
            H_DESDE = x.H_DESDE;
            H_HASTA = x.H_HASTA;
        }
    }
}

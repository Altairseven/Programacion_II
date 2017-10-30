using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model;

namespace Proyectores.Model.Entities {
    public class SalonesEntity {
        public decimal ID { get; set; }
        public string NOMBRE { get; set; }
        public string BusquedaContent { get; set; }

        public SalonesEntity(Salones x) {
            ID = x.ID;
            NOMBRE = x.NOMBRE;
            BusquedaContent = x.ID.ToString() + 'Ç' + x.NOMBRE;

        }
    }
}

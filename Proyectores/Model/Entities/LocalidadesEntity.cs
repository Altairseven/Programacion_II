using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Model;

namespace Proyectores.Model.Entities {
    public class LocalidadesEntity {

        public decimal ID { get; set; }
        public decimal COD_POSTAL { get; set; }
        public string NOMBRE { get; set; }
        public decimal? ID_PROVINCIA { get; set; }
        public string NOMBRE_PROVINCIA { get; set; }

        public LocalidadesEntity() { }

        public LocalidadesEntity(Localidades x) {
            ID = x.ID;
            COD_POSTAL = x.COD_POSTAL;
            NOMBRE = x.NOMBRE;
            ID_PROVINCIA = x.ID_PROVINCIA;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model;

namespace Proyectores.Model.Entities {
    class ProvinciasEntity {

        public decimal ID { get; set; }
        public string Nombre { get; set; }

        public ProvinciasEntity() { }

        public ProvinciasEntity(Provincias x) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyectores.Classes {
    public class ReportMode {
        public string MType { get; set; }
        public string MLabel { get; set; }

        public ReportMode(string t, string l) {
            MType = t;
            MLabel = l;
        }
    }

    public class Reportes {
        public List<ReportMode> RList { get; set; }

        public Reportes() {
            RList = new List<ReportMode>();
            RList.Add(new ReportMode("", "< Seleccione >"));
            RList.Add(new ReportMode("Baja_por_Cancelacion", "Reservas Canceladas"));
            RList.Add(new ReportMode("Baja_por_Prestamo", "Reservas Concretadas"));
            RList.Add(new ReportMode("Proy_Por_salon", "Uso de proyectores por salon"));
            RList.Add(new ReportMode("Proy_Rotos", "Registro proyectores fuera de servicio"));

        }
    }
}

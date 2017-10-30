using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectores.Forms.Busquedas {
    public interface IFormPersonas {

        decimal? ID_Persona { get; set; }
        String P_Nombre { get; set; }
        String P_Apellido { get; set; }
        string Nombre_Tipo_Persona { get; set; }

    }
}

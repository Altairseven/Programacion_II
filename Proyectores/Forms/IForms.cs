using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectores.Forms {
    public interface IForms {

        decimal? Loc_ID { get; set; }
        decimal? COD_Postal { get; set; }
        String Loc_Nombre { get; set; }

    }
}

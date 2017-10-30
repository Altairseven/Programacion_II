using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model;

namespace Proyectores.Model.Entities {
    public class ProyectoresEntity {

        public decimal ID { get; set; }
        public string MARCA { get; set; }
        public string SERIAL { get; set; }
        public decimal HDMI { get; set; }
        public string MODELO { get; set; }
        public decimal DISPONIBLE { get; set; }
        public decimal OPERATIVO { get; set; }
        public string HDMIstr { get; set; }
        public string DISPONIBLEstr { get; set; }
        public string OPERATIVOstr { get; set; }
        //usados para reportes
        public string APE_NOM { get; set; }


        public ProyectoresEntity() {

        }

        public ProyectoresEntity(Proyectores x) {
            ID = x.ID;
            MARCA = x.MARCA;
            SERIAL = x.SERIAL;
            HDMI = x.HDMI;
            MODELO = x.MODELO;
            DISPONIBLE = x.DISPONIBLE;
            OPERATIVO = x.OPERATIVO;
            

        }

    }
}

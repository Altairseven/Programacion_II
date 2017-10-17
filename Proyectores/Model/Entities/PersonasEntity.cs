using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model;


namespace Proyectores.Model.Entities {
    public class PersonasEntity {

        public decimal ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public decimal ID_TIPO_DOCUMENTO { get; set; }
        public decimal DOCUMENTO { get; set; }
        public decimal? CUIT { get; set; }
        public decimal ID_LOCALIDAD { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public decimal? ID_TIPO_PERSONA { get; set; }
        public string LEGAJO { get; set; }
        public string LocNombre { get; set; }

        private string _docnombre;
        public string DocNombre {
            get { return _docnombre; }
            set {
                _docnombre = value;
                if (DOCUMENTO != 0)
                    DOCUMENTO_FULL = value + " - " + DOCUMENTO.ToString();
            }
        }

        public string TIPO_PERSONA { get; set; }
        public string APE_NOM { get; set; }
        public string DOCUMENTO_FULL { get; set; }

        public PersonasEntity() {
            new PersonasEntity(new Personas());
        }

        public PersonasEntity(Personas x) {
            ID = x.ID;
            NOMBRE = x.NOMBRE;
            APELLIDO = x.APELLIDO;
            ID_TIPO_DOCUMENTO = x.ID_TIPO_DOCUMENTO;
            DOCUMENTO = x.DOCUMENTO;
            CUIT = x.CUIT;
            ID_LOCALIDAD = x.ID_LOCALIDAD;
            DIRECCION = x.DIRECCION;
            TELEFONO = x.TELEFONO;
            EMAIL = x.EMAIL;
            ID_TIPO_PERSONA = x.ID_TIPO_PERSONA;
            LEGAJO = x.LEGAJO;
            APE_NOM = x.APELLIDO + ", " + x.NOMBRE;
            

        }

    }
}

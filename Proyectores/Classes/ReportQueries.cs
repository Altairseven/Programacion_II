using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyectores.Model.Entities;
using Proyectores.Model;
using System.Windows.Forms;

namespace Proyectores.Classes {
    public class ReportQueries {

        ProyectoresModelEntities _db = new ProyectoresModelEntities();

        public List<PrestamosEntity> GetReservasList() {
            List<PrestamosEntity> List = new List<PrestamosEntity>();

            var P = from a in _db.Prestamos
                    join b in _db.Personas on a.ID_PERSONA equals b.ID
                    join c in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals c.ID
                    join d in _db.Salones on a.ID_SALON equals d.ID
                    where a.ACTIVO == 1
                    select new {
                        a,
                        APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                        TIPO = c.NOMBRE,
                        SALON = d.NOMBRE
                    };

            foreach (var item in P) {
                PrestamosEntity Entity = new PrestamosEntity(item.a);
                Entity.APE_NOM = item.APE_NOM;
                Entity.TIPO_PERSONA = item.TIPO;
                Entity.SALON = item.SALON;
                Entity.ButtonLB = "Dar de Baja";
                List.Add(Entity);
            }




            return List;
        }

        public void Proyectores_GetList(string modo, DataGridView Grilla, DateTime Desde, DateTime Hasta) {
            switch (modo) {
                case "Baja_por_Cancelacion":
                    Grilla.DataSource = GetList_Baja_por_Cancelacion(modo, Desde, Hasta);
                    Setup_ReservasType_Report(Grilla);
                    Grilla.Columns["FECHA_BAJA"].Visible = true;
                    break;

                default:
                    break;
            }
        }

        #region Consultas
        public List<ReservasEntity> GetList_Baja_por_Cancelacion(string modo, DateTime Desde, DateTime Hasta) {
            List<ReservasEntity> List = new List<ReservasEntity>();

            var q = from a in _db.Reserva
                    join b in _db.Personas on a.ID_PERSONA equals b.ID
                    join c in _db.Salones on a.ID_SALON equals c.ID
                    join d in _db.Tipos_Persona on b.ID_TIPO_PERSONA equals d.ID
                    where a.ID_MOTIVO_BAJA == 2
                    && (Desde < a.FECHA_RESERVA && a.FECHA_RESERVA < Hasta)
                    select new {
                        a,
                        APE_NOM = b.APELLIDO + ", " + b.NOMBRE,
                        NOMBRE_TIPO_PERSONA = d.NOMBRE,
                        NOMBRE_SALON = c.NOMBRE
                    };

            foreach (var item in q) {
                ReservasEntity Entity = new ReservasEntity(item.a);
                Entity.APE_NOM = item.APE_NOM;
                Entity.NOMBRE_SALON = item.NOMBRE_SALON;
                Entity.NOMBRE_TIPO_PERSONA = item.NOMBRE_TIPO_PERSONA;
                List.Add(Entity);
            }



            return List;
        }


        #endregion

        #region GridSetups

        private void Setup_ReservasType_Report(DataGridView Grilla) {
            foreach (DataGridViewColumn col in Grilla.Columns) {
                switch (col.Name) {
                    case "FECHA_RESERVA":
                        col.DisplayIndex = 0;
                        col.HeaderText = "Fecha";
                        col.Width = 110;
                        break;
                    case "FECHA_BAJA": //default, ocultada
                        col.DisplayIndex = 1;
                        col.HeaderText = "F. Cancel.";
                        col.Width = 110;
                        col.Visible = false;
                        break;
                    case "APE_NOM":
                        col.DisplayIndex = 2;
                        col.HeaderText = "Fecha";
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "NOMBRE_TIPO_PERSONA":
                        col.DisplayIndex = 3;
                        col.HeaderText = "Tipo";
                        col.Width = 110;
                        break;
                    case "NOMBRE_SALON":
                        col.DisplayIndex = 4;
                        col.HeaderText = "Salon";
                        col.Width = 110;
                        break;
                    case "H_DESDEsrt":
                        col.DisplayIndex = 5;
                        col.HeaderText = "Desde";
                        col.Width = 110;
                        break;
                    case "H_HASTAsrt":
                        col.DisplayIndex = 6;
                        col.HeaderText = "Hasta";
                        col.Width = 110;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Classes;
using Proyectores.Model.Entities;
using Proyectores.Model;

namespace Proyectores.Forms.ABM {
    public partial class HistorialGrilla : Form {
        public HistorialGrilla() {
            InitializeComponent();
        }

        ReportQueries RClass = new ReportQueries();
        

        

        private void HistorialGrilla_Load(object sender, EventArgs e) {
            Reportes R = new Reportes();
            Hasta_TP.MinDate = Desde_TP.Value;
            Modo_CB.DataSource = new Reportes().RList;
        }

        private void Dates_ValueChanged(object sender, EventArgs e) {
            string name = ((DateTimePicker)sender).Name;
            if (name == "Desde_TP") {
                Hasta_TP.MinDate = Desde_TP.Value;
                if (Desde_TP.Value > Hasta_TP.Value)
                    Hasta_TP.Value = Desde_TP.Value;
            }


        }

        private void Consulta_Click(object sender, EventArgs e) {
            string Modo_Consulta = Modo_CB.SelectedValue.ToString();
            if (Modo_Consulta == "") {
                MessageBox.Show("Seleccione un tipo de reporte valido.");
                return;
            }
            RClass.Proyectores_GetList(Modo_Consulta, Grid, Desde_TP.Value, Hasta_TP.Value);
        }






    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyectores.Forms.ABM;
using Syncfusion.Windows.Forms.Tools;

namespace Proyectores.Forms {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            SetupTabs();
        }

        public Main(decimal userid) {
            InitializeComponent();
            SetupTabs();
        }

        private List<IGrilla> IForms;

        private void Main_Load(object sender, EventArgs e) {

            
        }

        private void SetupTabs() {
            IForms = new List<IGrilla>();
            InicioGrilla inicio = new InicioGrilla();
            inicio.TopLevel = false;
            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            TabInicio.Controls.Add(inicio);
            inicio.Show();
            IGrilla Iinicio = inicio;
            IForms.Add(Iinicio);

            ReservasGrilla reservas = new ReservasGrilla();
            reservas.TopLevel = false;
            reservas.FormBorderStyle = FormBorderStyle.None;
            reservas.Dock = DockStyle.Fill;
            TabReservas.Controls.Add(reservas);
            reservas.Show();
            IGrilla IReservas = reservas;
            IForms.Add(IReservas);

            PersonasGrilla Personas = new PersonasGrilla();
            Personas.TopLevel = false;
            Personas.FormBorderStyle = FormBorderStyle.None;
            Personas.Dock = DockStyle.Fill;
            TabPersonas.Controls.Add(Personas);
            Personas.Show();
            IGrilla IPersonas = Personas;
            IForms.Add(IPersonas);

            ProyectoresGrilla Proyectores = new ProyectoresGrilla();
            Proyectores.TopLevel = false;
            Proyectores.FormBorderStyle = FormBorderStyle.None;
            Proyectores.Dock = DockStyle.Fill;
            TabProyectores.Controls.Add(Proyectores);
            Proyectores.Show();
            IGrilla IProyectores = Proyectores;
            IForms.Add(IProyectores);

            HistorialGrilla Historial = new HistorialGrilla();
            Historial.TopLevel = false;
            Historial.FormBorderStyle = FormBorderStyle.None;
            Historial.Dock = DockStyle.Fill;
            TabAjustes.Controls.Add(Historial);
            Historial.Show();

            TabPageAdv[] tabs =  new TabPageAdv[]{
                TabInicio,
                TabReservas,
                TabPersonas,
                TabProyectores,
                TabAjustes
            };
            TB_Control.Controls.Clear();
            TB_Control.Controls.AddRange(tabs);


        }

        private void TB_Control_TabIndexChanged(object sender, EventArgs e) {

        }

        private void TB_Control_SelectedIndexChanged(object sender, EventArgs e) {
            int index = TB_Control.SelectedIndex;
            if (index <= IForms.Count -1)
                IForms[index].GetData();
        }

        private void button1_Click(object sender, EventArgs e) {
            HistorialGrilla g = new HistorialGrilla();
            g.Show();
        }
    }
}

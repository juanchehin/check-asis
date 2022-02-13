using check_asis.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis.Presentacion
{
    public partial class Preplanilla : UserControl
    {
        public Preplanilla()
        {
            InitializeComponent();
        }

        private void ReporteAsistencias()
        {
            Reportes.ReportAsistencias rpt = new Reportes.ReportAsistencias();
            DataTable dt = new DataTable();
            DAsistencias funcion = new DAsistencias();
            funcion.mostrar_asistencias_diarias(ref dt, dtInicio.Value, dtFin.Value, Convert.ToInt32(lblNroSemana.Text));
            rpt.DataSource = dt;
            rpt.table1.DataSource = dt;


            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }
        private void calcular_numero_de_semana()
        {
            DateTime v2 = dtFin.Value;
            lblNroSemana.Text = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek).ToString();
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            calcular_numero_de_semana();
            ReporteAsistencias();
        }

        private void dtFin_ValueChanged(object sender, EventArgs e)
        {
            calcular_numero_de_semana();
            ReporteAsistencias();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyntaxErrorWebApp
{
    public partial class MisPrestamos : System.Web.UI.Page
    {
        public class Prestamo
        {
            public int IDPrestamo { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public DateTime FechaPrestamo { get; set; }
            public DateTime FechaDevolucion { get; set; }
            public string Ubicacion { get; set; }
            public string Disponibilidad { get; set; }
            public string Descripcion { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPrestamosPrueba();
            }
        }
        private void CargarPrestamosPrueba()
        {
            var prestamos = new List<Prestamo>
        {
            new Prestamo
            {
                IDPrestamo = 1,
                Titulo = "El Origen de las Especies",
                Autor = "Charles Darwin",
                FechaPrestamo = DateTime.Now.AddDays(-5),
                FechaDevolucion = DateTime.Now.AddDays(10),
                Ubicacion = "Estantería A3",
                Disponibilidad = "1 copia disponible",
                Descripcion = "Obra fundamental sobre la teoría de la evolución."
            },
            new Prestamo
            {
                IDPrestamo = 2,
                Titulo = "Cien Años de Soledad",
                Autor = "Gabriel García Márquez",
                FechaPrestamo = DateTime.Now.AddDays(-7),
                FechaDevolucion = DateTime.Now.AddDays(7),
                Ubicacion = "Estantería B1",
                Disponibilidad = "2 copias disponibles",
                Descripcion = "Crónica de la familia Buendía en Macondo."
            }
        };

            rptPrestamos.DataSource = prestamos;
            rptPrestamos.DataBind();
        }

        protected void btnRenovar_Command(object sender, CommandEventArgs e)
        {
            int idPrestamo = Convert.ToInt32(e.CommandArgument);
            /**/
            ScriptManager.RegisterStartupScript(this, this.GetType(), "renovado",
                $"alert('Préstamo con ID {idPrestamo} renovado con éxito.');", true);
        }
    }
}
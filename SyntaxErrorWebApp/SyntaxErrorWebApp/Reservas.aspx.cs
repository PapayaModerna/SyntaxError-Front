using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyntaxErrorWebApp
{
    public class ReservaMock
    {
        public string Descripcion { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; }
    }
    public partial class Reservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Esto es Logica cuando se empieza a cargar la pagina para las reservas*/if (!IsPostBack)
            {
                CargarReservasUsuario();
            }
        }
        private void CargarReservasUsuario()
        {
            try
            {
                var reservas = new List<ReservaMock>
                {
                    new ReservaMock { Descripcion = "Reserva de libro: Cien Años de Soledad", FechaReserva = DateTime.Today.AddDays(-2), Estado = "Activa" },
                    new ReservaMock { Descripcion = "Reserva de sala de estudio", FechaReserva = DateTime.Today.AddDays(-1), Estado = "Cancelada" },
                    new ReservaMock { Descripcion = "Reserva de laptop", FechaReserva = DateTime.Today, Estado = "Completada" }
                };

                rptReservas.DataSource = reservas;
                rptReservas.DataBind();
                lblSinReservas.Visible = reservas.Count == 0;
                //Obtiene los atributos del usuario
                //Comito esto porque cada vez que ejecuto , me pide iniciar sesion
                /*
                 string usuario = Session["Usuario"]?.ToString(); // o usa un método más seguro de autenticación

                if (string.IsNullOrEmpty(usuario))
                {
                    Response.Redirect("~/Login.aspx");
                    return;
                }

                 */


                //Esto es logica para cargar las reservas de los usuarios
                /*
                 using (var cliente = new ServicioReservasClient())
                {
                    var reservas = cliente.ObtenerReservasPorUsuario(usuario);

                    if (reservas != null && reservas.Length > 0)
                    {
                        rptReservas.DataSource = reservas;
                        rptReservas.DataBind();
                        lblSinReservas.Visible = false;
                    }
                    else
                    {
                        lblSinReservas.Visible = true;
                    }
                }*/
            }
            catch (Exception ex)
            {
                // Manejo de errores
                lblSinReservas.Text = "Ocurrió un error al cargar las reservas.";
                lblSinReservas.Visible = true;
                
            }
        }
        void btnCancelarSolicitud() { 
            /*Logica de cancelar*/
        }
    }
}
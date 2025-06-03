using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyntaxErrorWebApp
{
    public class RecursoMock
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Ubicacion { get; set; }
        public string Disponibilidad { get; set; }
        public string Descripcion { get; set; }
        public string Editorial { get; set; }
        public string Edicion { get; set; }
        public string Nivel { get; set; }
        public string Tema { get; set; }
        public string Categoria { get; set; }
        public string AnhioPubli { get; set; }
    }

    public partial class Recursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var master = (Site1)this.Master;
            master.BodyCssClass = "recursos-page";
            if (!IsPostBack)
            {
                CargarRecursosMock();
            }
        }

        /*Boton que ejecuta la lógica de buscar por libro o autor*/
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            /*string criterio = txtBusqueda.Text.Trim();
            
            CargarRecursos(criterio, filtrosSeleccionados);*/
        }

        /*Boton que ejecuta la logica de negocio para aplicar filtros a la busqueda de libros*/
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            /*var filtrosTematica = chkTematica.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToList();
            var filtrosNivel = chkNivel.Items.Cast<ListItem>().Where(i => i.Selected).Select(i => i.Value).ToList();

            CargarRecursos(txtBusqueda.Text.Trim(), filtrosTematica, filtrosNivel);*/
        }

        /*Carga los filtros a la busqueda*/
        private void CargarRecursos(string busqueda, List<string> tematicas, List<string> niveles)
        {
            /*var lista = MiLogicaNegocio.ObtenerRecursos(busqueda, tematicas, niveles);
            rptRecursos.DataSource = lista;
            rptRecursos.DataBind();*/
        }

        /*Carga más detalle a los libros que se muestran cuando se busca un recurso*/
        private void btnDetalle(object sender,EventArgs e) 
        { 
            /*Nada*/
        }
        private void CargarRecursosMock()
        {
            var recursos = new List<RecursoMock>
    {
        new RecursoMock
        {
            Codigo = "LIB001",
            Titulo = "Introducción a la Programación",
            Autor = "Juan Pérez",
            Ubicacion = "Estantería A2",
            Disponibilidad = "Disponible",
            Descripcion = "Libro básico de programación con ejemplos en C#.",
            Edicion = "3era Edicion",
            Editorial = "Editorial PUCP",
            Nivel = "Basico 2",
            Tema = "Programacion",
            AnhioPubli = "2015",
            Categoria = "Genero"
        },
        new RecursoMock
        {
            Codigo = "LIB002",
            Titulo = "Algoritmos y Estructuras de Datos",
            Autor = "Ana Torres",
            Ubicacion = "Estantería B1",
            Disponibilidad = "Prestado",
            Descripcion = "Guía práctica para dominar algoritmos clásicos."
        },
        new RecursoMock
        {
            Codigo = "EQP003",
            Titulo = "Laptop Lenovo ThinkPad",
            Autor = "Recursos Tecnológicos",
            Ubicacion = "Sala de préstamo",
            Disponibilidad = "Disponible",
            Descripcion = "Laptop para uso académico con Windows 11."
        }
    };

            rptRecursos.DataSource = recursos;
            rptRecursos.DataBind();
        }
        protected void btnSolicitarPrestamo_Command(object sender, CommandEventArgs e)
        {
            /*
             int idPrestamo = Convert.ToInt32(e.CommandArgument);

            // Simulación de la solicitud
            ScriptManager.RegisterStartupScript(this, this.GetType(), "prestamoSolicitado",
                $"alert('Solicitud de préstamo enviada para el recurso con ID {idPrestamo}.');", true);

            // Cierre del modal desde backend
            ScriptManager.RegisterStartupScript(this, this.GetType(), "cerrarModal",
                "closeModal();", true);*/

        }

    }
}
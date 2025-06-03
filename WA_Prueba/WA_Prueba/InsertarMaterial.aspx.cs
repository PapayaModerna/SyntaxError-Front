using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WA_Prueba.MaterialWS;
using WA_Prueba.EditorialWS;
using System.Collections;
using WA_Prueba.CreadorMaterialWS;
namespace WA_Prueba
{
    public partial class InsertarMaterial : System.Web.UI.Page
    {
        private MaterialWSClient materialwsClient;
        private EditorialWSClient editorialwsClient;

        protected void Page_Init(object sender, EventArgs e)
        {
            materialwsClient = new MaterialWSClient();
            editorialwsClient = new EditorialWSClient();
        }
        private void ListarEditoriales()
        {
            WA_Prueba.EditorialWS.editorialDTO[] editoriales = editorialwsClient.listarEditoriales();
            ArrayList editorialList = new ArrayList();
            foreach(var editorial in editoriales)
            {
                editorialList.Add(new {editorial.idEditorial,editorial.nombre});
            }
            ddlEditorial.DataSource = editorialList;
            ddlEditorial.DataTextField = "nombre";
            ddlEditorial.DataValueField = "idEditorial";
            ddlEditorial.DataBind();
            ddlEditorial.Items.Insert(0, new ListItem("Seleccione una editorial", "0"));

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = txtTitulo.Text.Trim();
                string edicion = txtEdicion.Text.Trim();
                int anioPublicacion = Convert.ToInt32(ddlAnioPublicacion.SelectedValue);
                string nivelIngles = ddlNivelIngles.SelectedValue;
                string descripcion = txtDescripcion.Text.Trim();
                int idEditorial = Convert.ToInt32(ddlEditorial.SelectedValue);

                // Llamar al método insertar del servicio web
                int resultado = materialwsClient.insertarMaterial(titulo, edicion, nivelIngles, anioPublicacion,null,idEditorial);
                if (resultado > 0)
                {
                    lblMensaje.Text = "Material agregado correctamente.";
                }
                else
                {
                    lblMensaje.Text = "Error al agregar el material.";
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra
                lblMensaje.Text = "Ocurrió un error: " + ex.Message;
            }
        }

        private void LlenarAnioPublicacion()
        {
            int currentYear = DateTime.Now.Year;

            // Agregar los años al DropDownList
            for (int i = 1900; i <= currentYear; i++)
            {
                ddlAnioPublicacion.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarAnioPublicacion();
                ListarEditoriales(); // Llamamos al método para listar las editoriales
            }
        }
    }
}
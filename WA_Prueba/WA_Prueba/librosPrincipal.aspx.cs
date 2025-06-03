using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WA_Prueba.MaterialWS;

namespace WA_Prueba
{
    public partial class librosPrincipal : System.Web.UI.Page
    {
        private MaterialWSClient materialwsClient;

        protected void Page_Init(object sender, EventArgs e)
        {
            materialwsClient = new MaterialWSClient();
        }

        protected void LoadMateriales()
        {
            try
            {
                materialDTO[] materialesArray = materialwsClient.listarTodos();
                List<materialDTO> materiales = materialesArray.ToList();
                dgvLibros.DataSource = materiales;
                dgvLibros.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al cargar los materiales: " + ex.Message + "');</script>");
            }
        }
        protected void dgvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "VerDetalles")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                rowIndex--;
                GridViewRow row = dgvLibros.Rows[rowIndex];
                string idMaterial = row.Cells[0].Text;

                try
                {
                    // Obtener los detalles del libro
                    materialDTO material = materialwsClient.obtenerPorId(Convert.ToInt32(idMaterial));

                    if (material != null)
                    {
                        // Asignar los detalles a los controles
                        detalleTitulo.InnerText = material.titulo ?? "No disponible";
                        detalleAnio.InnerText = material.anioPublicacion.ToString() ?? "No disponible";
                        detalleCategorias.InnerText = "No disponible";
                        detalleAutor.InnerText = "No disponible";
                        detalleEditorial.InnerText = "No disponible";
                        detalleDescripcion.InnerText = "No disponible";
                        hfMaterialId.Value = Convert.ToString(idMaterial);

                        // Mostrar los detalles
                        detallesContainer.Style["display"] = "block";  // Cambiamos display a "block" para mostrar el contenedor
                        statsContainer.Style["display"] = "none";
                    }
                    else
                    {
                        Response.Write("<script>alert('No se encontró el material');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error al obtener los detalles: " + ex.Message + "');</script>");
                }

            } 
        }
        protected void EliminarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int idMaterial = Convert.ToInt32(hfMaterialId.Value);
                int result = materialwsClient.eliminarMaterial(idMaterial);
                if (result>0)
                {
                    LoadMateriales();

                    // Ocultar la sección de detalles y mostrar nuevamente la lista y estadísticas
                    detallesContainer.Style["display"] = "none";
                    statsContainer.Style["display"] = "block";
                    dgvLibros.Style["display"] = "block";  // Mostrar la lista de libros

                    // Mostrar mensaje de éxito
                    Response.Write("<script>alert('Material eliminado exitosamente');</script>");
                }
                else
                {
                    Response.Write("<script>alert('No se pudo eliminar el material, probablemente hayan ejemplares en el sistema');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error al eliminar el material: " + ex.Message + "');</script>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMateriales(); // Cargamos los materiales
            }
        }
    }
}
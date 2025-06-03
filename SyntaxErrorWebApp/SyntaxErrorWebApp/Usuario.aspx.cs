using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyntaxErrorWebApp
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Sesion['usuario'] == null) {
                Response.Redirect("~/login.aspx");
            }
            if (!IsPostBack)
            {
                // Simulación de usuario en sesión (reemplaza con tu lógica real)
                string nombre = "Andrés";
                string apellido1 = "Melgar";
                string apellido2 = "Sasieta";
                string codigo = "222152";
                string correo = "A.Melgar@pucp.edu.pe";
                string telefono = "993444652";
                string direccion = "Av. Universitaria 1953";

                /*
                PersonaWS.persona persona = (PersonaWS.persona)Session["usuario"];
                lblNombreCompleto.Text = persona.nombre + " " + persona.apellido1;
                lblInicialUsuario.Text = persona.nombre.Substring(0,1);
                
                txtNombre.Text = persona.nombre;
                txtApellido1.Text = persona.apellido1;
                txtApellido2.Text = persona.apellido2;
                txtCodigo.Text = persona.codigo;
                txtCorreo.Text = persona.correo;
                txtTelefono.Text = persona.telefono;
                txtDireccion.Text = persona.direccion;

                 */
                lblNombreCompleto.Text = nombre + " " + apellido1;
                string inicial = nombre.Substring(0, 1);
                lblInicialUsuario.Text = inicial;
                
                txtNombre.Text = nombre;
                txtApellido1.Text = apellido1;
                txtApellido2.Text = apellido2;
                txtCodigo.Text = codigo;
                txtCorreo.Text = correo;
                txtTelefono.Text = telefono;
                txtDireccion.Text = direccion;
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Lógica para cerrar sesión
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string nuevaClave = txtPassword.Text;

            // Guardar en la base de datos o llamar a servicio
            // ...
        }

        protected void btnCambiarClave_Click(object sender, EventArgs e)
        {
            // Opcional: lógica separada para cambiar la clave
        }
    }
}
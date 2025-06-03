using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SyntaxErrorWebApp.LoginWS;

namespace SyntaxErrorWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        private PersonaWS personaWS;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Boton para ejecutar la lógica del inicio de sesión
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtLoginCodigo.Text;
            string password = txtLoginPassword.Text;

            PersonaWS.persona persona = personaWS.verificaPersona(correo, password);


            if (persona !=null)
            {
                Session["usuario"] = persona;
                if (correo.Contains(".admin")) {
                    Session["CantidadMaxPrestamos"] = 2;
                    Session["DiasMaximo"] = 14;
                }
                else {
                    if (correo.Contains(".teacher")){
                        Session["CantidadMaxPrestamos"] = 5;
                        Session["DiasMaximo"] = 14;
                    }
                    else
                    {
                        Session["CantidadMaxPrestamos"] = 3;
                        Session["DiasMaximo"] = 7;
                    }
                    Response.Redirect("~/index.aspx");
                }
            }
            else 
            {
                lblMensaje.Text = "Correo o contraseñas incorrectos.";
                lblMensaje.Visible = true;
            }
        }

        //Boton para ejecutar la lógica de reestablecer la contraseña
        protected void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        //Botón para ejecutar la lógica de registrar un nuevo usuario
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
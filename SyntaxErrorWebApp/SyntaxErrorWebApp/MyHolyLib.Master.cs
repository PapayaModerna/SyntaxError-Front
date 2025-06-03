using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyntaxErrorWebApp
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string BodyCssClass { get; set; } = "default-body";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["persona"] == null)
            {   Response.Redirect("Login.aspx");
            }
            if (Session["persona"] != null && !IsPostBack)
            {
                var persona = (PersonaDTO)Session["persona"];
                lblNombre.Text = persona.Nombre + " " + persona.Apellido;
                lblInicial.Text = persona.Nombre.Substring(0, 1).ToUpper();
            }
        }
    }
}
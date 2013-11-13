using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class CrearGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {

                }

            }
            else
            {
                Response.Redirect("/Default.aspx");
            }
        }

        protected void crearGrupoBt_Click(object sender, EventArgs e)
        {
            if (!Grupo.existeGrupo(nombreGrupo.Text))
            {
                Grupo.crearGrupo(nombreGrupo.Text);
                mensajeGrupo.Text = "El grupo" + nombreGrupo.Text + "ha sido creado con éxito";
            }
            else
            {
                mensajeGrupo.Text = "El grupo ya existe, elige otro nombre";
            }
        }
    }
}
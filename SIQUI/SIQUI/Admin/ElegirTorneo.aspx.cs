using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Admin
{
    public partial class ElegirTorneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!((Usuario)Session["currentUser"]).isAdmin())
            {
                Response.Redirect("/Default.aspx");
            }
            if (!IsPostBack)
            {
                BaseDatos.Consulta("select nombreTorneo, codigoTorneo from Torneo where nombreTorneo != 'inicio'");
                listadoCampeonatos.DataSource = BaseDatos.Dr;
                listadoCampeonatos.DataTextField = "nombreTorneo";
                listadoCampeonatos.DataValueField = "codigoTorneo";
                listadoCampeonatos.DataBind();
            }
        }

        protected void elegirBt_Click(object sender, EventArgs e)
        {
            ((Torneo)Session["torneoActual"]).torneo = listadoCampeonatos.SelectedItem.Text;
            ((Torneo)Session["torneoActual"]).idTorneo = listadoCampeonatos.SelectedValue;


        }
    }
}
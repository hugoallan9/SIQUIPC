using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class BuscarGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                if (((SIQUI.Clases.Usuario)Session["currentUser"]).isAdmin())
                {
                    Response.Redirect("/Default.aspx");
                }
                
            }

            if (!IsPostBack)
            {
                Grupo.buscarGrupos();
                muestrarioGrupos.DataSource = BaseDatos.Dr;
                muestrarioGrupos.DataTextField = "nombreGrupo";
                muestrarioGrupos.DataValueField = "codigoGrupo";
                muestrarioGrupos.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Miembros/MostrarGrupo.aspx?grupo=" + muestrarioGrupos.SelectedValue);
        }
    }
}
using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal menu = (Literal)this.Master.FindControl("MenuLiteral");
            if (Session["currentUser"] != null)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {
                    menu.Text = "<li><a href=\"/Admin/Ingresar Estructura.aspx\">>Ingresar Torneo</a></li> \n " +
                        "<li><a href=\"/Admin/EditarTorneo.aspx\">>Editar Torneo</a></li> \n" +
                        "<li><a href=\"/Admin/ElegirTorneo.aspx\">>Elegir Torneo</a></li> \n" +
                        "<li><a href=\"/Admin/IngresarResultados.aspx\">>Ingresar Resultados del Campeonato</a></li> \n";
                }
                else
                {
                    menu.Text = "<li><a href=\"/Miembros/CrearQuiniela.aspx\">> Ingresar Quiniela </a> \n"+
                        "<li><a href=\"/Miembros/MisQuinielas.aspx\">> Mis Quinielas </a> \n" +
                        "<li><a href=\"/Miembros/CrearGrupo.aspx\">> Crear un Grupo </a> \n" +
                        "<li><a href=\"/Miembros/BuscarGrupo.aspx\">> Ver Grupos de Usuarios </a> \n" +
                        "<li><a href=\"/Miembros/VerResultados.aspx\">> Ver Resultados </a> \n";
                }

            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "registro":
                    Response.Redirect("~/Account/Register.aspx");
                    break;
            }
        }
    }
}
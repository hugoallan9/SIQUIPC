using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Admin
{
    public partial class VerTorneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                if (!((Usuario)Session["currentUser"]).isAdmin())
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            if (!IsPostBack)
            {
                String consulta = "SELECT codigoTorneo as [Código], nombreTorneo as [Nombre del Toreno], estado from Torneo";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                quinielasGrid.DataSource = tabla;
                quinielasGrid.DataBind();
            }
        }

        protected void quinielasGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = quinielasGrid.SelectedRow;
            Response.Redirect("~/Admin/EditarTorneo.aspx?codigo=" + row.Cells[1].Text);
        }

        protected void quinielasGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = quinielasGrid.Rows[e.NewSelectedIndex];
        }
    }
}
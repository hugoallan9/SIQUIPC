using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class EditarQuiniela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            if (!IsPostBack)
            {
                String consulta = "SELECT codigoPronostico as [Código], primerPuesto as [Equipo en primer posición], segundoPuesto as [Equipo en Segundo posición], fase from Pronostico where quinielaMadre="  + Request.QueryString["codigo"];
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
            Response.Redirect("~/Miembros/EditarPronostico.aspx?codigo=" + row.Cells[1].Text);
        }

        protected void quinielasGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = quinielasGrid.Rows[e.NewSelectedIndex];
        }
    }
}
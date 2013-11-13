using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class MisQuinielas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
            if (!IsPostBack)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {
                    String consulta = "SELECT * from Quiniela ";
                    BaseDatos db = new BaseDatos();
                    db.cargarData(consulta);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                    DataTable tabla = new DataTable();
                    myAdapter.Fill(tabla);
                    GridView1.DataSource = tabla;
                    GridView1.DataBind();
                }
                else
                {

                    String consulta = "SELECT codigoQuiniela as [Código], nombreQuiniela as [Nombre de la Quiniela], torneo as [Código del torneo] from Quiniela where propietario=" + ((Usuario)Session["currentUser"]).Codigo;
                    BaseDatos db = new BaseDatos();
                    db.cargarData(consulta);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                    DataTable tabla = new DataTable();
                    myAdapter.Fill(tabla);
                    quinielasGrid.DataSource = tabla;
                    quinielasGrid.DataBind();
                }
            }
        }

        protected void quinielasGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = quinielasGrid.SelectedRow;
            Response.Redirect("~/Miembros/EditarQuiniela.aspx?codigo=" + row.Cells[1].Text);
        }

        protected void quinielasGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = quinielasGrid.Rows[e.NewSelectedIndex];
        }
    }
}
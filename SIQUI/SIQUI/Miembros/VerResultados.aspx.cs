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
    public partial class VerResultados : System.Web.UI.Page
    {
        Quiniela result;
        Resultado result1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                result = new Quiniela(((Torneo)Session["torneoActual"]).idTorneo);
                result1 = new Resultado();
                result1.Consulta("select * from Quiniela where nombreQuiniela='master' and torneo=" + ((Torneo)Session["torneoActual"]).idTorneo);
                Resultado parcial = new Resultado();
                parcial.Consulta("select * from Quiniela where torneo=" + ((Torneo)Session["torneoActual"]).idTorneo);
                if (result1.Dr.HasRows)
                {
                    result1.Dr.Read();
                    while (parcial.Dr.Read())
                    {
                        result.calcularResultado(Convert.ToString(result1.Dr.GetInt32(0)), Convert.ToString(parcial.Dr.GetInt32(0)));
                    }
                }
            }
            String consulta = "select Quiniela.nombreQuiniela, sum(Pronostico.puntajeNormal) as Puntos  from Pronostico inner join Quiniela on Pronostico.quinielaMadre = Quiniela.codigoQuiniela   where quinielaMadre in (select codigoQuiniela from Quiniela where Quiniela.torneo="+((Torneo)Session["torneoActual"]).idTorneo+") group by nombreQuiniela ";
            BaseDatos db = new BaseDatos();
            db.cargarData(consulta);
            SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
            DataTable tabla = new DataTable();
            myAdapter.Fill(tabla);
            quinielasGrid.DataSource = tabla;
            quinielasGrid.DataBind();
        }

        protected void quinielasGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = quinielasGrid.SelectedRow;
            //Response.Redirect("~/Miembros/EditarPronostico.aspx?codigo=" + row.Cells[1].Text);
        }

        protected void quinielasGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = quinielasGrid.Rows[e.NewSelectedIndex];
        }
    }
}
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
    public partial class MostrarGrupo : System.Web.UI.Page
    {
        Quiniela result;
        Resultado result1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] != null)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {
                    Response.Redirect("/Default.aspx");
                }
                if (!IsPostBack)
                {
                    BaseDatos.Consulta("select Quiniela.nombreQuiniela, Quiniela.codigoQuiniela from Quiniela where codigoQuiniela not in (select quiniela from Inscripcion_Grupo where grupo="+Request.QueryString["grupo"]+")");
                    quinielasAsignables.DataSource = BaseDatos.Dr;
                    quinielasAsignables.DataTextField = "nombreQuiniela";
                    quinielasAsignables.DataValueField = "codigoQuiniela";
                    quinielasAsignables.DataBind();
                    result = new Quiniela(((Torneo)Session["torneoActual"]).idTorneo);
                    result1 = new Resultado();
                    result1.Consulta("select * from Quiniela where nombreQuiniela='master' and torneo=" + ((Torneo)Session["torneoActual"]).idTorneo);
                    Resultado parcial = new Resultado();
                    parcial.Consulta("select * from Inscripcion_Grupo where grupo=" + Request.QueryString["grupo"]);
                    if (result1.Dr.HasRows)
                    {
                        result1.Dr.Read();
                        while (parcial.Dr.Read())
                        {
                            result.calcularResultado( Convert.ToString(result1.Dr.GetInt32(0)), Convert.ToString(parcial.Dr.GetInt32(1)));
                        }
                    }
                }

                String consulta = "select Quiniela.nombreQuiniela, sum(Pronostico.puntajeNormal) as Puntos  from Pronostico inner join Quiniela on Pronostico.quinielaMadre = Quiniela.codigoQuiniela   where quinielaMadre in (select quiniela from Inscripcion_Grupo where grupo="+Request.QueryString["grupo"]+") group by nombreQuiniela ";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                grupoGv.DataSource = tabla;
                grupoGv.DataBind();
            }
        }

        protected void asignarBt_Click(object sender, EventArgs e)
        {
            BaseDatos.Consulta("insert into Inscripcion_Grupo(quiniela,grupo)values("+quinielasAsignables.SelectedValue+","+ Request.QueryString["grupo"]+ ")");
            msgLb.Text = "Quiniela Asignada!";
        }
    }
}
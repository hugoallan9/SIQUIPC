using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Admin
{
    public partial class EditarTorneo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }

            if (!IsPostBack)
            {
                String consulta = "Select * from Torneo where codigoTorneo=" + ((Torneo)Session["torneoActual"]).idTorneo;
                BaseDatos.Consulta(consulta);
                if (BaseDatos.Dr.Read())
                {
                    try
                    {
                        TextBox1.Text = BaseDatos.Dr.GetString(4);

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String consulta = "update Torneo set estado='" + TextBox1.Text + "' where codigoTorneo=" + ((Torneo)Session["torneoActual"]).idTorneo;
            BaseDatos.Consulta(consulta);

        }
    }
}
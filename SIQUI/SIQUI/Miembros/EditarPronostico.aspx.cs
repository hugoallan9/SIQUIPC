using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class EditarPronostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }

            if (!IsPostBack)
            {
                BaseDatos db = new BaseDatos();
                String consulta = "Select codigoPronostico, primerPuesto, segundoPuesto, ganador, fase from Pronostico where codigoPronostico=" + Request.QueryString["codigo"];
                BaseDatos.Consulta(consulta);
                if (BaseDatos.Dr.Read())
                {
                    try
                    {
                        Label1.Text = BaseDatos.Dr.GetString(4);
                        TextBox1.Text = Convert.ToString(BaseDatos.Dr.GetInt32(1));
                        TextBox2.Text = Convert.ToString(BaseDatos.Dr.GetInt32(2));
                        TextBox3.Text = Convert.ToString(BaseDatos.Dr.GetInt32(3));
                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String consulta;

            if (Label1.Text != "grupos") 
            {
                consulta = "Update Pronostico set primerPuesto=" + TextBox1.Text + ",segundoPuesto=" + TextBox2.Text + ", ganador=" + TextBox3.Text + " where codigoPronostico=" + Request.QueryString["codigo"];
            }
            else
            {
                consulta = "Update Pronostico set primerPuesto=" + TextBox1.Text + ",segundoPuesto=" + TextBox2.Text +  " where codigoPronostico=" + Request.QueryString["codigo"];
            }
            
            BaseDatos nueva = new BaseDatos();
            BaseDatos.Consulta(consulta);
        }
    }
}
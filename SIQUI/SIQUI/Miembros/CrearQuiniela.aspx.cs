using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class CrearQuiniela : System.Web.UI.Page
    {
        Usuario nuevo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((Torneo)Session["torneoActual"]).idTorneo == "-1")
            {
                Response.Redirect("/Default.aspx");
            }

            if (Session["currentUser"]!= null)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {
                    //Response.Redirect("~/Default.aspx");
                }
                else
                {
                    torneoLb.Text = ((Torneo)Session["torneoActual"]).torneo;
                }
                nuevo = (Usuario)Session["currentUser"];
               
                if (!IsPostBack)
                {
                    ((Usuario)Session["currentUser"]).dondePuedeCrearQuinielas();
                    if (BaseDatos.Dr.HasRows)
                    {
                        FileUpload1.Visible = false;
                        Button1.Visible = false;
                        ingresoQBt.Visible = false;
                        mensaje.Text = "Has excedido el número de Quinielas o No hay torneos abiertos";
                    }
                }


            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }

            
        }

        protected void ingresoQBt_Click(object sender, EventArgs e)
        {
            Quiniela quiniela = new Quiniela(nombreQuiniela.Text, Convert.ToString(nuevo.Codigo), ((Torneo)Session["torneoActual"]).idTorneo);
            if (quiniela.existeQuiniela(nombreQuiniela.Text, Convert.ToString(nuevo.nombreUsuario), ((Torneo)Session["torneoActual"]).idTorneo))
            {
                mensaje.Text = "El nombre de la quiniela ya existe";
            }
            else
            {
                quiniela.grabarQuiniela(nombreQuiniela.Text);
                Response.Redirect("~/Miembros/ProcesoQuiniela.aspx?torneo=" + ((Torneo)Session["torneoActual"]).idTorneo + "&quiniela=" + nombreQuiniela.Text);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                //try
                //{
                    String fileName = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/") + fileName);
                    LectorQuiniela lector = new LectorQuiniela(Server.MapPath("~/") + fileName, ((Torneo)Session["torneoActual"]).idTorneo);
                    lector.obtenerDatos();
                    lector.obtenerQuiniela();
                    xmlLb.Text = lector.validarQuiniela();
                //}
                //catch (Exception ex)
                //{
                  //  xmlLb.Text = "El Archivo no pudo ser cargado. Ha ocurrido el siguiente error: " + ex.Message;
                //}
            }
        }
    }
}
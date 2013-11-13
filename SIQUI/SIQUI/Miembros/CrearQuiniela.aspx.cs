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

            if (Session["currentUser"]!= null)
            {
                if (((Usuario)Session["currentUser"]).isAdmin())
                {
                    Response.Redirect("~/Default.aspx");
                }
                nuevo = (Usuario)Session["currentUser"];
                if (!IsPostBack)
                {
                    nuevo.dondePuedeCrearQuinielas();
                  
                    torneoDDL.DataSource =  BaseDatos.Dr;
                    torneoDDL.DataTextField = "nombreTorneo";
                    torneoDDL.DataValueField = "codigoTorneo";
                    torneoDDL.DataBind();


                    if (BaseDatos.Dr.HasRows)
                    {
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
            Quiniela quiniela = new Quiniela(nombreQuiniela.Text, Convert.ToString(nuevo.Codigo), torneoDDL.SelectedValue);
            if (quiniela.existeQuiniela(nombreQuiniela.Text, Convert.ToString(nuevo.Codigo)))
            {
                mensaje.Text = "El nombre de la quiniela ya existe";
            }
            else
            {
                quiniela.grabarQuiniela(nombreQuiniela.Text);
                Response.Redirect("~/Miembros/ProcesoQuiniela.aspx?torneo=" + torneoDDL.SelectedValue + "&quiniela=" + nombreQuiniela.Text);
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
                    LectorQuiniela lector = new LectorQuiniela(Server.MapPath("~/") + fileName, torneoDDL.SelectedValue);
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
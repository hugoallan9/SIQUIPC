using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Admin
{
    public partial class Ingresar_Estructura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["archivo"] != null)
            {
                LectorXml lector = new LectorXml(Server.MapPath("~/") + Request.QueryString["archivo"]);
                lector.obtenerEstructura();

            }
        }
       
        protected void cargaBt_Click(object sender, EventArgs e)
        {
            if (archivoXml.HasFile)
            {
                try
                {
                    String fileName = Path.GetFileName(archivoXml.FileName);
                    archivoXml.SaveAs(Server.MapPath("~/") + fileName);
                    rutaLb.Text = fileName + " ha sido cargado.";
                    Response.Redirect("/Admin/Ingresar Estructura.aspx?archivo="+fileName);
                }
                catch(Exception ex)
                {
                    rutaLb.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
}
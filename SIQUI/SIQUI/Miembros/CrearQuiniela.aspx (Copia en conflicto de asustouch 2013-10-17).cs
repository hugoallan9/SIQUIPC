using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class CrearQuiniela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentUser"]!= null)
            {
                Usuario nuevo = (Usuario)Session["currentUser"];
                if (!IsPostBack)
                {

                }

            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}
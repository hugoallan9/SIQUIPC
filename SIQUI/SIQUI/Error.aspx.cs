using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["error"] == "mail")
            {
                mensajesLiteral.Text = "<h2>Error</h2> <br/> <p>El correo que proporcionaste está siendo utilizado por otro usuario, por favor verifica que " + Request.QueryString["argumento"] + " sea tuyo.</p>";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using SIQUI.Clases;

namespace SIQUI.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);
            TextBox nombre = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("FirstName");
            TextBox apellido = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("LastName");
            TextBox userName = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("UserName");
            TextBox nacionalidad = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Nacionalidad");
            TextBox email = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Email");
            TextBox passwd = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Password");
            TextBox preguntaSeguridad = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Question");
            TextBox respuesta = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Answer");
            Usuario nuevoUsuario = new Usuario(userName.Text, nombre.Text, apellido.Text, nacionalidad.Text, email.Text);
            MembershipCreateStatus status;
            String url = nuevoUsuario.crearUsuario(passwd.Text, preguntaSeguridad.Text, respuesta.Text);
            Response.Redirect(url);
        }
    }
}
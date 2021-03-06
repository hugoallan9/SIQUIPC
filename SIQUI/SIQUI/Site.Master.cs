﻿using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;


        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

  

            if (Session["currentUser"] != null)
            {
                Usuario nuevo = (Usuario)Session["currentUser"];
                if ((bool)Session["estadoLogin"])
                {
                    LabelNombre.Text = "Bienvenido " + nuevo.Nombre;
                    userTB.Visible = false;
                    LabelPass.Text = nuevo.Apellido;
                    passTB.Visible = false;
                    IngresoBt.Text = "Salir";
                    PanelRegistro.Visible = false;
                    torneoLb.Text = "Torneo: " + ((Torneo)Session["torneoActual"]).torneo;
                    listaTorneos.Visible = false;
                }
                else
                {

                }
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
                BaseDatos bd = new BaseDatos();
                BaseDatos.Consulta("select codigoTorneo, nombreTorneo from Torneo where estado = 'finalizado'");
                listaTorneos.DataSource = BaseDatos.Dr;
                listaTorneos.DataTextField = "nombreTorneo";
                listaTorneos.DataValueField = "codigoTorneo";
                listaTorneos.DataBind();
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IngresoBt_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario(userTB.Text, "", "", "", "");
            Torneo torneoActual;
            if (listaTorneos.SelectedValue != "")
            {
                torneoActual = new Torneo(listaTorneos.SelectedItem.Text, listaTorneos.SelectedValue);
            }
            else
            {
                torneoActual = new Torneo("", "-1");
            }
        
            if (Session["estadoLogin"] == null)
            {
                Session["estadoLogin"] = false;
            }
        

            if (nuevo.obtenerUsuario(userTB.Text, passTB.Text) && !(bool)Session["estadoLogin"])
            {
                Session["currentUser"] = nuevo;
                Session["torneoActual"] = torneoActual;
                Session["estadoLogin"] = true;
                LabelNombre.Text = "Bienvenido " + nuevo.Nombre;
                userTB.Visible = false;
                LabelPass.Text = nuevo.Apellido;
                passTB.Visible = false;
                IngresoBt.Text = "Salir";
                PanelRegistro.Visible = false;
                listaTorneos.Visible = false;
                torneoLb.Text =  "Torneo: "  + ((Torneo)Session["torneoActual"]).torneo; 
                Response.Redirect("~/Default.aspx");
            }
            else if ((bool)Session["estadoLogin"])
            {
                LabelNombre.Text = "Usuario";
                LabelPass.Text = "Contraseña";
                userTB.Visible = true;
                passTB.Visible = true;
                IngresoBt.Text = "Ingresar";
                PanelRegistro.Visible = true;
                Session.Clear();
                Response.Redirect("~/Default.aspx");
            }
            else if (!nuevo.obtenerUsuario(userTB.Text, passTB.Text))
            {
                avisoLB.Text = "Error de autenticación";
                Session["estadoLogin"] = false;
            }
              
        }
    }
}
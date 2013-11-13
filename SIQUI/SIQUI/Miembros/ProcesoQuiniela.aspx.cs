using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI.Miembros
{
    public partial class ProcesoQuiniela : System.Web.UI.Page
    {
        Torneo nuevoTorneo;
        Quiniela quiniela;
        Usuario usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["quiniela"] != null)
            {
                quiniela = new Quiniela("", "", "");
                quiniela = (Quiniela)Session["quiniela"];
                quiniela.inicializarPronosticos();
            }
            

            if (!IsPostBack)
            {
                usuario =  (Usuario) Session["currentUser"];
                nuevoTorneo = new Torneo(Request.QueryString["torneo"]);
                quiniela = new Quiniela(Request.QueryString["quiniela"], Convert.ToString(usuario.Codigo),Request.QueryString["torneo"]);
                Session["quiniela"] = quiniela;
                nuevoTorneo.determinarGrupo("a");
                DropDownListGA1.DataSource = BaseDatos.Dr;
                DropDownListGA1.DataTextField = "nombre";
                DropDownListGA1.DataValueField = "codigoEquipo";
                DropDownListGA1.DataBind();

                nuevoTorneo.determinarGrupo("a");
                DropDownListGA2.DataSource = BaseDatos.Dr;
                DropDownListGA2.DataTextField = "nombre";
                DropDownListGA2.DataValueField = "codigoEquipo";
                DropDownListGA2.DataBind();

                nuevoTorneo.determinarGrupo("b");
                DropDownListGB1.DataSource = BaseDatos.Dr;
                DropDownListGB1.DataTextField = "nombre";
                DropDownListGB1.DataValueField = "codigoEquipo";
                DropDownListGB1.DataBind();


                nuevoTorneo.determinarGrupo("b");
                DropDownListGB2.DataSource = BaseDatos.Dr;
                DropDownListGB2.DataTextField = "nombre";
                DropDownListGB2.DataValueField = "codigoEquipo";
                DropDownListGB2.DataBind();


                nuevoTorneo.determinarGrupo("c");
                DropDownListGC1.DataSource = BaseDatos.Dr;
                DropDownListGC1.DataTextField = "nombre";
                DropDownListGC1.DataValueField = "codigoEquipo";
                DropDownListGC1.DataBind();


                nuevoTorneo.determinarGrupo("c");
                DropDownListGC2.DataSource = BaseDatos.Dr;
                DropDownListGC2.DataTextField = "nombre";
                DropDownListGC2.DataValueField = "codigoEquipo";
                DropDownListGC2.DataBind();


                nuevoTorneo.determinarGrupo("d");
                DropDownListGD1.DataSource = BaseDatos.Dr;
                DropDownListGD1.DataTextField = "nombre";
                DropDownListGD1.DataValueField = "codigoEquipo";
                DropDownListGD1.DataBind();

                nuevoTorneo.determinarGrupo("d");
                DropDownListGD2.DataSource = BaseDatos.Dr;
                DropDownListGD2.DataTextField = "nombre";
                DropDownListGD2.DataValueField = "codigoEquipo";
                DropDownListGD2.DataBind();

                nuevoTorneo.determinarGrupo("e");
                DropDownListGE1.DataSource = BaseDatos.Dr;
                DropDownListGE1.DataTextField = "nombre";
                DropDownListGE1.DataValueField = "codigoEquipo";
                DropDownListGE1.DataBind();

                nuevoTorneo.determinarGrupo("e");
                DropDownListGE2.DataSource = BaseDatos.Dr;
                DropDownListGE2.DataTextField = "nombre";
                DropDownListGE2.DataValueField = "codigoEquipo";
                DropDownListGE2.DataBind();

               nuevoTorneo.determinarGrupo("f");
                DropDownListGF1.DataSource = BaseDatos.Dr;
                DropDownListGF1.DataTextField = "nombre";
                DropDownListGF1.DataValueField = "codigoEquipo";
                DropDownListGF1.DataBind();

                nuevoTorneo.determinarGrupo("f");
                DropDownListGF2.DataSource = BaseDatos.Dr;
                DropDownListGF2.DataTextField = "nombre";
                DropDownListGF2.DataValueField = "codigoEquipo";
                DropDownListGF2.DataBind();

                nuevoTorneo.determinarGrupo("g");
                DropDownListGG1.DataSource = BaseDatos.Dr;
                DropDownListGG1.DataTextField = "nombre";
                DropDownListGG1.DataValueField = "codigoEquipo";
                DropDownListGG1.DataBind();

                nuevoTorneo.determinarGrupo("g");
                DropDownListGG2.DataSource = BaseDatos.Dr;
                DropDownListGG2.DataTextField = "nombre";
                DropDownListGG2.DataValueField = "codigoEquipo";
                DropDownListGG2.DataBind();

                nuevoTorneo.determinarGrupo("h");
                DropDownListGH1.DataSource = BaseDatos.Dr;
                DropDownListGH1.DataTextField = "nombre";
                DropDownListGH1.DataValueField = "codigoEquipo";
                DropDownListGH1.DataBind();

                nuevoTorneo.determinarGrupo("h");
                DropDownListGH2.DataSource = BaseDatos.Dr;
                DropDownListGH2.DataTextField = "nombre";
                DropDownListGH2.DataValueField = "codigoEquipo";
                DropDownListGH2.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListO11.DataSource = BaseDatos.Dr;
                DropDownListO11.DataTextField = "nombre";
                DropDownListO11.DataValueField = "codigoEquipo";
                DropDownListO11.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO12.DataSource = BaseDatos.Dr;
                DropDownListO12.DataTextField = "nombre";
                DropDownListO12.DataValueField = "codigoEquipo";
                DropDownListO12.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO21.DataSource = BaseDatos.Dr;
                DropDownListO21.DataTextField = "nombre";
                DropDownListO21.DataValueField = "codigoEquipo";
                DropDownListO21.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO22.DataSource = BaseDatos.Dr;
                DropDownListO22.DataTextField = "nombre";
                DropDownListO22.DataValueField = "codigoEquipo";
                DropDownListO22.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO31.DataSource = BaseDatos.Dr;
                DropDownListO31.DataTextField = "nombre";
                DropDownListO31.DataValueField = "codigoEquipo";
                DropDownListO31.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO32.DataSource = BaseDatos.Dr;
                DropDownListO32.DataTextField = "nombre";
                DropDownListO32.DataValueField = "codigoEquipo";
                DropDownListO32.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO41.DataSource = BaseDatos.Dr;
                DropDownListO41.DataTextField = "nombre";
                DropDownListO41.DataValueField = "codigoEquipo";
                DropDownListO41.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO42.DataSource = BaseDatos.Dr;
                DropDownListO42.DataTextField = "nombre";
                DropDownListO42.DataValueField = "codigoEquipo";
                DropDownListO42.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO51.DataSource = BaseDatos.Dr;
                DropDownListO51.DataTextField = "nombre";
                DropDownListO51.DataValueField = "codigoEquipo";
                DropDownListO51.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO52.DataSource = BaseDatos.Dr;
                DropDownListO52.DataTextField = "nombre";
                DropDownListO52.DataValueField = "codigoEquipo";
                DropDownListO52.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListO61.DataSource = BaseDatos.Dr;
                DropDownListO61.DataTextField = "nombre";
                DropDownListO61.DataValueField = "codigoEquipo";
                DropDownListO61.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO62.DataSource = BaseDatos.Dr;
                DropDownListO62.DataTextField = "nombre";
                DropDownListO62.DataValueField = "codigoEquipo";
                DropDownListO62.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO71.DataSource = BaseDatos.Dr;
                DropDownListO71.DataTextField = "nombre";
                DropDownListO71.DataValueField = "codigoEquipo";
                DropDownListO71.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO72.DataSource = BaseDatos.Dr;
                DropDownListO72.DataTextField = "nombre";
                DropDownListO72.DataValueField = "codigoEquipo";
                DropDownListO72.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO81.DataSource = BaseDatos.Dr;
                DropDownListO81.DataTextField = "nombre";
                DropDownListO81.DataValueField = "codigoEquipo";
                DropDownListO81.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListO82.DataSource = BaseDatos.Dr;
                DropDownListO82.DataTextField = "nombre";
                DropDownListO82.DataValueField = "codigoEquipo";
                DropDownListO82.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC11.DataSource = BaseDatos.Dr;
                DropDownListC11.DataTextField = "nombre";
                DropDownListC11.DataValueField = "codigoEquipo";
                DropDownListC11.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC12.DataSource = BaseDatos.Dr;
                DropDownListC12.DataTextField = "nombre";
                DropDownListC12.DataValueField = "codigoEquipo";
                DropDownListC12.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC21.DataSource = BaseDatos.Dr;
                DropDownListC21.DataTextField = "nombre";
                DropDownListC21.DataValueField = "codigoEquipo";
                DropDownListC21.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC22.DataSource = BaseDatos.Dr;
                DropDownListC22.DataTextField = "nombre";
                DropDownListC22.DataValueField = "codigoEquipo";
                DropDownListC22.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC31.DataSource = BaseDatos.Dr;
                DropDownListC31.DataTextField = "nombre";
                DropDownListC31.DataValueField = "codigoEquipo";
                DropDownListC31.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC32.DataSource = BaseDatos.Dr;
                DropDownListC32.DataTextField = "nombre";
                DropDownListC32.DataValueField = "codigoEquipo";
                DropDownListC32.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC41.DataSource = BaseDatos.Dr;
                DropDownListC41.DataTextField = "nombre";
                DropDownListC41.DataValueField = "codigoEquipo";
                DropDownListC41.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListC42.DataSource = BaseDatos.Dr;
                DropDownListC42.DataTextField = "nombre";
                DropDownListC42.DataValueField = "codigoEquipo";
                DropDownListC42.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListS11.DataSource = BaseDatos.Dr;
                DropDownListS11.DataTextField = "nombre";
                DropDownListS11.DataValueField = "codigoEquipo";
                DropDownListS11.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListS12.DataSource = BaseDatos.Dr;
                DropDownListS12.DataTextField = "nombre";
                DropDownListS12.DataValueField = "codigoEquipo";
                DropDownListS12.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListS21.DataSource = BaseDatos.Dr;
                DropDownListS21.DataTextField = "nombre";
                DropDownListS21.DataValueField = "codigoEquipo";
                DropDownListS21.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListS22.DataSource = BaseDatos.Dr;
                DropDownListS22.DataTextField = "nombre";
                DropDownListS22.DataValueField = "codigoEquipo";
                DropDownListS22.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListF11.DataSource = BaseDatos.Dr;
                DropDownListF11.DataTextField = "nombre";
                DropDownListF11.DataValueField = "codigoEquipo";
                DropDownListF11.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListF12.DataSource = BaseDatos.Dr;
                DropDownListF12.DataTextField = "nombre";
                DropDownListF12.DataValueField = "codigoEquipo";
                DropDownListF12.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO1.DataSource = BaseDatos.Dr;
                DropDownListWO1.DataTextField = "nombre";
                DropDownListWO1.DataValueField = "codigoEquipo";
                DropDownListWO1.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO2.DataSource = BaseDatos.Dr;
                DropDownListWO2.DataTextField = "nombre";
                DropDownListWO2.DataValueField = "codigoEquipo";
                DropDownListWO2.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO3.DataSource = BaseDatos.Dr;
                DropDownListWO3.DataTextField = "nombre";
                DropDownListWO3.DataValueField = "codigoEquipo";
                DropDownListWO3.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO4.DataSource = BaseDatos.Dr;
                DropDownListWO4.DataTextField = "nombre";
                DropDownListWO4.DataValueField = "codigoEquipo";
                DropDownListWO4.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO5.DataSource = BaseDatos.Dr;
                DropDownListWO5.DataTextField = "nombre";
                DropDownListWO5.DataValueField = "codigoEquipo";
                DropDownListWO5.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO6.DataSource = BaseDatos.Dr;
                DropDownListWO6.DataTextField = "nombre";
                DropDownListWO6.DataValueField = "codigoEquipo";
                DropDownListWO6.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWO7.DataSource = BaseDatos.Dr;
                DropDownListWO7.DataTextField = "nombre";
                DropDownListWO7.DataValueField = "codigoEquipo";
                DropDownListWO7.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListWO8.DataSource = BaseDatos.Dr;
                DropDownListWO8.DataTextField = "nombre";
                DropDownListWO8.DataValueField = "codigoEquipo";
                DropDownListWO8.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWC1.DataSource = BaseDatos.Dr;
                DropDownListWC1.DataTextField = "nombre";
                DropDownListWC1.DataValueField = "codigoEquipo";
                DropDownListWC1.DataBind();


                nuevoTorneo.listadoEquipos();
                DropDownListWC2.DataSource = BaseDatos.Dr;
                DropDownListWC2.DataTextField = "nombre";
                DropDownListWC2.DataValueField = "codigoEquipo";
                DropDownListWC2.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWC3.DataSource = BaseDatos.Dr;
                DropDownListWC3.DataTextField = "nombre";
                DropDownListWC3.DataValueField = "codigoEquipo";
                DropDownListWC3.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWC4.DataSource = BaseDatos.Dr;
                DropDownListWC4.DataTextField = "nombre";
                DropDownListWC4.DataValueField = "codigoEquipo";
                DropDownListWC4.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWS1.DataSource = BaseDatos.Dr;
                DropDownListWS1.DataTextField = "nombre";
                DropDownListWS1.DataValueField = "codigoEquipo";
                DropDownListWS1.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWS2.DataSource = BaseDatos.Dr;
                DropDownListWS2.DataTextField = "nombre";
                DropDownListWS2.DataValueField = "codigoEquipo";
                DropDownListWS2.DataBind();

                nuevoTorneo.listadoEquipos();
                DropDownListWF1.DataSource = BaseDatos.Dr;
                DropDownListWF1.DataTextField = "nombre";
                DropDownListWF1.DataValueField = "codigoEquipo";
                DropDownListWF1.DataBind();
            }
        }

        protected void DropDownListGA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GA.Primero = DropDownListGA1.SelectedValue;
        }

        protected void DropDownListGA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GA.Segundo = DropDownListGA2.SelectedValue;
        }

        protected void DropDownListGB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GB.Primero = DropDownListGB1.SelectedValue;
        }

        protected void DropDownListGB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GB.Segundo = DropDownListGB2.SelectedValue;
        }

        protected void DropDownListGC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GC.Primero = DropDownListGC1.SelectedValue;
        }

        protected void DropDownListGC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GC.Segundo = DropDownListGC2.SelectedValue;
        }

        protected void DropDownListGD1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GD.Primero = DropDownListGD1.SelectedValue;
        }

        protected void DropDownListGD2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GD.Segundo = DropDownListGD2.SelectedValue;
        }

        protected void DropDownListGE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GE.Primero = DropDownListGE1.SelectedValue;
        }

        protected void DropDownListGE2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GE.Segundo = DropDownListGE2.SelectedValue;
        }

        protected void DropDownListGF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GF.Primero = DropDownListGF1.SelectedValue;
        }

        protected void DropDownListGF2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GF.Segundo = DropDownListGF2.SelectedValue;
        }

        protected void DropDownListGG1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GG.Primero = DropDownListGG1.SelectedValue;
        }

        protected void DropDownListGG2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GG.Segundo = DropDownListGG2.SelectedValue;
        }

        protected void DropDownListGH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GH.Primero = DropDownListGH1.SelectedValue;
        }

        protected void DropDownListGH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.GH.Segundo = DropDownListGH2.SelectedValue;
        }

        protected void DropDownListO11_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O1.Primero = DropDownListO11.SelectedValue;
        }

        protected void DropDownListO12_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O1.Segundo = DropDownListO12.SelectedValue;
        }

        protected void DropDownListO21_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O2.Primero = DropDownListO21.SelectedValue;
        }

        protected void DropDownListO22_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O2.Segundo = DropDownListO22.SelectedValue;
        }

        protected void DropDownListO31_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O3.Primero = DropDownListO31.SelectedValue;
        }

        protected void DropDownListO32_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O3.Segundo = DropDownListO32.SelectedValue;
        }

        protected void DropDownListO41_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O4.Primero = DropDownListO41.SelectedValue;
        }

        protected void DropDownListO42_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O4.Segundo = DropDownListO42.SelectedValue;
        }

        protected void DropDownListO51_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O5.Primero = DropDownListO51.SelectedValue;
        }

        protected void DropDownListO52_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O5.Segundo = DropDownListO52.SelectedValue;
        }

        protected void DropDownListO61_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O6.Primero = DropDownListO61.SelectedValue;
        }

        protected void DropDownListO62_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O6.Segundo = DropDownListO62.SelectedValue;
        }

        protected void DropDownListO71_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O7.Primero = DropDownListO71.SelectedValue;
        }

        protected void DropDownListO72_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O7.Segundo = DropDownListO72.SelectedValue;
        }

        protected void DropDownListO81_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O8.Primero = DropDownListO81.SelectedValue;
        }

        protected void DropDownListO82_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O8.Segundo = DropDownListO82.SelectedValue;
        }

        protected void DropDownListC11_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C1.Primero = DropDownListC11.SelectedValue;
        }

        protected void DropDownListC12_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C2.Segundo = DropDownListC12.SelectedValue;
        }

        protected void DropDownListC21_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C2.Primero = DropDownListC21.SelectedValue;
        }

        protected void DropDownListC22_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C2.Segundo = DropDownListC22.SelectedValue;
        }

        protected void DropDownListC31_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C3.Primero = DropDownListC31.SelectedValue;
        }

        protected void DropDownListC32_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C3.Segundo = DropDownListC32.SelectedValue;
        }

        protected void DropDownListC41_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C4.Primero = DropDownListC41.SelectedValue;
        }

        protected void DropDownListC42_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C4.Segundo = DropDownListC42.SelectedValue;
        }

        protected void DropDownListS11_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S1.Primero = DropDownListS11.SelectedValue;
        }

        protected void DropDownListS12_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S1.Segundo = DropDownListS12.SelectedValue;
        }

        protected void DropDownListS21_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S2.Primero = DropDownListS21.SelectedValue;
        }

        protected void DropDownListS22_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S2.Segundo = DropDownListS22.SelectedValue;
        }

        protected void DropDownListF11_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.F.Primero = DropDownListF11.SelectedValue;

        }

        protected void DropDownListF12_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.F.Segundo = DropDownListF12.SelectedValue;
        }

        protected void DropDownListWO1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O1.Ganador = DropDownListWO1.SelectedValue;
        }

        protected void DropDownListWO2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O2.Ganador = DropDownListWO2.SelectedValue;
        }

        protected void DropDownListWO3_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O3.Ganador = DropDownListWO3.SelectedValue;
        }

        protected void DropDownListWO4_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O4.Ganador = DropDownListWO4.SelectedValue;
        }

        protected void DropDownListWO5_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O5.Ganador = DropDownListWO5.SelectedValue;
        }

        protected void DropDownListWO6_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O6.Ganador = DropDownListWO6.SelectedValue;
        }

        protected void DropDownListWO7_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O7.Ganador = DropDownListWO7.SelectedValue;
        }

        protected void DropDownListWO8_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.O8.Ganador = DropDownListWO8.SelectedValue;
        }

        protected void DropDownListWC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C1.Ganador = DropDownListWC1.SelectedValue;
        }

        protected void DropDownListWC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C2.Ganador = DropDownListWC2.SelectedValue;
        }

        protected void DropDownListWC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C3.Ganador = DropDownListWC3.SelectedValue;
        }

        protected void DropDownListWC4_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.C4.Ganador = DropDownListWC4.SelectedValue;
        }

        protected void DropDownListWS1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S1.Ganador = DropDownListWS1.SelectedValue;
        }

        protected void DropDownListWS2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.S2.Ganador = DropDownListWS2.SelectedValue;
        }

        protected void DropDownListWF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quiniela.F.Ganador = DropDownListWF1.SelectedValue;
        }

        protected void grabarBt_Click(object sender, EventArgs e)
        {
            quiniela.salvarQuiniela();
            Response.Redirect("~/Miembros/CrearQuiniela.aspx");
        }











    }
}
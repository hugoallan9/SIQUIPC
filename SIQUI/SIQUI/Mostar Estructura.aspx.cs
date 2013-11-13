using SIQUI.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIQUI
{
    public partial class Mostar_Estructura : System.Web.UI.Page
    {
        String idTorneo = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["torneo"] != null)
            {
                idTorneo = Request.QueryString["torneo"];
                llenarGrids();
            }
        }

        private void llenarGrids()
        {
            llenarGrid("a");
            llenarGrid("b");
            llenarGrid("c");
            llenarGrid("d");
            llenarGrid("e");
            llenarGrid("f");
            llenarGrid("g");
            llenarGrid("h");
            llenarGrid("O1");
            llenarGrid("O2");
            llenarGrid("O3");
            llenarGrid("O4");
            llenarGrid("O5");
            llenarGrid("O6");
            llenarGrid("O7");
            llenarGrid("O8");

        }

        private void llenarGrid(string p)
        {
            

            if (p == "a")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                grida.DataSource = tabla;
                grida.DataBind();
            }
            else if (p == "b")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridb.DataSource = tabla;
                gridb.DataBind();
            }
            else if (p == "c")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridc.DataSource = tabla;
                gridc.DataBind();
            }
            else if (p == "d")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridd.DataSource = tabla;
                gridd.DataBind();
            }
            else if (p == "e")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gride.DataSource = tabla;
                gride.DataBind();
            }
            else if (p == "f")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridf.DataSource = tabla;
                gridf.DataBind();
            }
            else if (p == "g")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridg.DataSource = tabla;
                gridg.DataBind();

            }
            else if (p == "h")
            {
                String consulta = "SELECT nombre as Selección, codigoEquipo as [Código Equipo] from Equipo where (grupo='" + p + "' and torneo=" + idTorneo + "and nombre is not null)";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridh.DataSource = tabla;
                gridh.DataBind();
            }else if(p == "O1")
            {
                String consulta = "SELECT nombre as [Llave], rival1 as [Equipo 1], rival2 as [Equipo 2] from Duelo_Ficticio where (fase='octavos' and torneo=" + idTorneo + ")";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO1.DataSource = tabla;
                gridO1.DataBind();
            }
            else if (p == "O2")
            {
                String consulta = "SELECT codigoEquipoFicticio as [Código Equipo], grupo as [Del grupo], posicion as [Quedó en posición] from Equipo_Ficticio where (posicion is not null and torneo=" + idTorneo+ ")";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO2.DataSource = tabla;
                gridO2.DataBind();
            }
            else if (p == "O3")
            {
                String consulta = "SELECT nombre as [Llave], rival1 as [Equipo 1], rival2 as [Equipo 2] from Duelo_Ficticio where (fase='cuartos' and torneo=" + idTorneo + ")";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO3.DataSource = tabla;
                gridO3.DataBind();
            }
            else if (p == "O4")
            {
                String consulta = "select codigoEquipoFicticio as [Código Equipo], nombre as [Ganador Llave] from Equipo_Ficticio where  codigoEquipoFicticio in (select rival1 from Duelo_Ficticio where (fase='cuartos' and torneo=" + idTorneo + ") union select rival2 from Duelo_Ficticio where (fase='cuartos' and torneo = " + idTorneo + "  ))";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO4.DataSource = tabla;
                gridO4.DataBind();
            }
            else if(p == "O5")
            {
                String consulta = "SELECT nombre as [Llave], rival1 as [Equipo 1], rival2 as [Equipo 2] from Duelo_Ficticio where (fase='SemiFinal' and torneo=" + idTorneo + ")";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO5.DataSource = tabla;
                gridO5.DataBind();
            }
            else if(p == "O6")
            {
                String consulta = "select codigoEquipoFicticio as [Código Equipo], nombre as [Ganador Llave] from Equipo_Ficticio where  codigoEquipoFicticio in (select rival1 from Duelo_Ficticio where (fase='SemiFinal' and torneo=" + idTorneo + ") union select rival2 from Duelo_Ficticio where (fase='SemiFinal' and torneo = " + idTorneo + "  ))";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO6.DataSource = tabla;
                gridO6.DataBind();
            }
            else if (p == "O7")
            {
                String consulta = "SELECT nombre as [Llave], rival1 as [Equipo 1], rival2 as [Equipo 2] from Duelo_Ficticio where (fase='Final' and torneo=" + idTorneo + ")";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO7.DataSource = tabla;
                gridO7.DataBind();
            }
            else if (p == "O8")
            {
                String consulta = "select codigoEquipoFicticio as [Código Equipo], nombre as [Ganador Llave] from Equipo_Ficticio where  codigoEquipoFicticio in (select rival1 from Duelo_Ficticio where (fase='Final' and torneo=" + idTorneo + ") union select rival2 from Duelo_Ficticio where (fase='Final' and torneo = " + idTorneo + "  ))";
                BaseDatos db = new BaseDatos();
                db.cargarData(consulta);
                SqlDataAdapter myAdapter = new SqlDataAdapter(db.Cmm);
                DataTable tabla = new DataTable();
                myAdapter.Fill(tabla);
                gridO8.DataSource = tabla;
                gridO8.DataBind();
            }
        
        }
    }
}
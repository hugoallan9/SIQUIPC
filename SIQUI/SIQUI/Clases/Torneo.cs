using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIQUI.Clases
{
    public class Torneo:BaseDatos
    {
        private String codigoTorneo;
        private String nombreTorneo;

        public String idTorneo
        {
            set { codigoTorneo = value; }
            get { return codigoTorneo; }
        }

        public String torneo
        {
            set { nombreTorneo = value; }
            get { return nombreTorneo; }
        }
        public void determinarGrupo(String grupo)
        {
            String consulta = "select nombre, codigoEquipo from Equipo where torneo = " + codigoTorneo + " and grupo = '" + grupo+"'"   ;
            Consulta(consulta);
        }

        public void listadoEquipos()
        {
            String consulta = "select nombre, codigoEquipo from Equipo where torneo = " + codigoTorneo;
            Consulta(consulta);
        }


        public Torneo(string codigo)
        {
            codigoTorneo = codigo;
        }

        public Torneo(String nombre, String codigo)
        {
            nombreTorneo = nombre;
            codigoTorneo = codigo;
        }
    }
}
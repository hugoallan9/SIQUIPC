using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIQUI.Clases
{
    public class Torneo:BaseDatos
    {
        private String codigoTorneo;
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

    }
}
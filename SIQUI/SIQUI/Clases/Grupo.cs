using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIQUI.Clases
{
    public class Grupo
    {
        private String nombre;
        private int codigoGrupo;

        public Grupo(int codigoGrupo)
        {
            this.codigoGrupo = codigoGrupo;
        }

        public static Boolean existeGrupo(String nombre)
        {
            Boolean existe;
            String consulta = "select * from Grupo_User where nombreGrupo='" + nombre + "'";
            BaseDatos.Consulta(consulta);
            existe = BaseDatos.Dr.HasRows;
            return existe;
        }

        public static void crearGrupo(String nombre)
        {
            String consulta = "Insert into Grupo_User(nombreGrupo)values('" + nombre + "')";
            BaseDatos.Consulta(consulta);
        }

        public static String nombreGrupo(int codigo)
        {
            String consulta = "select * from Grupo_User where codigoGrupo=" + codigo;
            BaseDatos.Consulta(consulta);
            return BaseDatos.Dr.GetString(1);
        }

        public static void buscarGrupos()
        {
            String consulta = "Select * from Grupo_User";
            BaseDatos.Consulta(consulta);
        }
    }
}
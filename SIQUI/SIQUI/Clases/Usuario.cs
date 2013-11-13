using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace SIQUI.Clases
{
    public class Usuario: BaseDatos
    {
        private int codigoUsuario;
        private String nombre, apellido, paisOrigen, email, userName;


        public Usuario(String userName, String nombre, String apellido, String paisOrigen, String email)
        {
            this.userName = userName;
            this.nombre = nombre;
            this.apellido = apellido;
            this.paisOrigen = paisOrigen;
            this.email = email;
        }

        public String nombreUsuario
        {
            get { return userName; }
        }
        public  String crearUsuario(String passwd, String pregunta, String res)
        {
            MembershipCreateStatus status;
            Membership.CreateUser(userName, passwd, email, pregunta, res, true, out status);
            String respuesta = "";
            if (esNuevo())
            {
                String codigoCrearUsuario = "Insert into Usuario(nombreUsuario, nombre, apellido, nacionalidad, passwd, email, isAdmin)values('" + userName + "','" + nombre + "','" + apellido + "','" +
                    paisOrigen + "'," + "pwdencrypt('" + passwd + "'),'" + email + "'," + 0 + ")";
                Consulta(codigoCrearUsuario);
                respuesta = "~/";
            }
            else if(status == MembershipCreateStatus.DuplicateEmail)
            {
                
                respuesta = "~/Error.aspx?error=mail" + "&argumento=" + email;
            }
            else if (status == MembershipCreateStatus.DuplicateUserName)
            {
                respuesta = "~/Error.aspx?error=user" + "&argumento=" + userName;
            }

            return respuesta;
           
        }

        public bool esNuevo()
        {
            bool respuesta;
            String consulta = "Select count(*) from Usuario where email='" + email + "'";
            Consulta(consulta);
            Dr.Read();
            if (Dr.GetInt32(0) == 0)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;

        }

        public Boolean obtenerUsuario(String usuario, String passwd)
        {
            Boolean respuesta = false;
            String consulta = "Select codigoUsuario, nombre, apellido, nacionalidad, email from Usuario where nombreUsuario='" + usuario + "' and pwdcompare('" +passwd + "', passwd)=1" ;
            Consulta(consulta);
            if (respuesta=Dr.Read())
            {
                Codigo = Dr.GetInt32(0);
                Nombre = Dr.GetString(1);
                Apellido = Dr.GetString(2);
                Pais = Dr.GetString(3);
                Correo = Dr.GetString(4);
            }



            return respuesta;
           
        }

       

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Pais
        {
            get { return paisOrigen; }
            set { paisOrigen = value; }
        }

        public String Correo
        {
            get { return email; }
            set { email = value; }
        }


        public void dondePuedeCrearQuinielas()
        {

            if (tieneQuinielas())
            {
                String consulta = "Select nombreTorneo, codigoTorneo from Torneo where estado='finalizado' and codigoTorneo in(Select torneo from(Select Count(codigoQuiniela) as [Total por torneo], torneo from Quiniela where propietario=" + codigoUsuario + "group by torneo)b where b.[Total por torneo]<5 )";
                Consulta(consulta);
            }
            else
            {
                String consulta1 = "Select nombreTorneo, codigoTorneo from Torneo";
                Consulta(consulta1);
            }
        }

        private bool tieneQuinielas()
        {
            bool respuesta = false;
            String consulta = "select * from Quiniela where propietario=" + codigoUsuario;
            Consulta(consulta);
            respuesta = Dr.Read();
            return respuesta;
        }

        public bool isAdmin()
        {
            String consulta = "Select * from Usuario where codigoUsuario=" + codigoUsuario;
            Consulta(consulta);
            Dr.Read();
            bool respuesta =(bool) Dr.GetSqlBoolean(7);
            return respuesta;
        }

    }
}
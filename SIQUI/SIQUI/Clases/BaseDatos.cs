using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SIQUI.Clases
{
    public class BaseDatos
    {
        private static SqlDataReader mydr;
        private static String conexion = "Data Source=T800\\SQLEXPRESS;Initial Catalog=Proyecto2;Integrated Security=True";
        private static SqlConnection myConection;
        private static SqlCommand myCommand;

        public BaseDatos()
        {
            myConection = new SqlConnection(conexion);

        }

        public static void Consulta(String consulta)
        {
            if (Cnn.State == System.Data.ConnectionState.Open)
            {
                
                myCommand = new SqlCommand(consulta, myConection);
                Dr.Close();
                Dr = myCommand.ExecuteReader();
            }
            else
            {
                myConection.Open();
                myCommand = new SqlCommand(consulta, myConection);
                Dr = myCommand.ExecuteReader();
            }
        }


        public void cargarData(String consulta)
        {
            if (Cnn.State == System.Data.ConnectionState.Open)
            {

                myCommand = new SqlCommand(consulta, myConection);
            }
            else
            {
                myConection.Open();
                myCommand = new SqlCommand(consulta, myConection);
            }
        }

        public static SqlDataReader Dr
        {
            get { return mydr; }
            set { mydr = value; }
        }

        public static  SqlConnection Cnn
        {
            get { return myConection; }
            set { myConection = value; }
        }

        public SqlCommand Cmm
        {
            get { return myCommand; }
            set { myCommand = value; }
        }

        public static void  consultaFecha(String consulta)
        {
            if (Cnn.State == System.Data.ConnectionState.Open)
            {

                myCommand = new SqlCommand(consulta, myConection);
                myCommand.Parameters.AddWithValue("@time", DateTime.Now);
                Dr.Close();
                myCommand.ExecuteNonQuery();
            }
            else
            {
                myConection.Open();
                myCommand = new SqlCommand(consulta, myConection);
                myCommand.Parameters.AddWithValue("@time", DateTime.Now);
                myCommand.ExecuteNonQuery();
            }
        }

    }
}
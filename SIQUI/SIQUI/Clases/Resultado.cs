using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SIQUI.Clases
{
    public class Resultado
    {
        private  SqlDataReader mydr;
        private  String conexion = "Data Source=ASUSTOUCH\\SQLEXPRESS;Initial Catalog=Proyecto2;Integrated Security=True";
        private  SqlConnection myConection;
        private  SqlCommand myCommand;

        public Resultado()
        {
            myConection = new SqlConnection(conexion);
        }

        public  void Consulta(String consulta)
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

        public  SqlDataReader Dr
        {
            get { return mydr; }
            set { mydr = value; }
        }

        public  SqlConnection Cnn
        {
            get { return myConection; }
            set { myConection = value; }
        }

        public SqlCommand Cmm
        {
            get { return myCommand; }
            set { myCommand = value; }
        }

        public  void consultaFecha(String consulta)
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
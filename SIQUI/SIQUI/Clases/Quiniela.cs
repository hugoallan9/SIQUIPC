using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;

namespace SIQUI.Clases
{
    public class Quiniela:BaseDatos
    {
        private String codigoQuiniela;
        public String nombreQuiniela;
        private String propietario;
        private String torneo;
        Pronostico qGA = new Pronostico();
        Pronostico qGB = new Pronostico();
        Pronostico qGC = new Pronostico();
        Pronostico qGD = new Pronostico();
        Pronostico qGF = new Pronostico();
        Pronostico qGG = new Pronostico();
        Pronostico qGH = new Pronostico();
        Pronostico qGE = new Pronostico();
        Pronostico qO2 = new Pronostico();
        Pronostico qO3 = new Pronostico();
        Pronostico qO4 = new Pronostico();
        Pronostico qO5 = new Pronostico();
        Pronostico qO6 = new Pronostico();
        Pronostico qO7 = new Pronostico();
        Pronostico qO8 = new Pronostico();
        Pronostico qO1 = new Pronostico();
        Pronostico qC1 = new Pronostico();
        Pronostico qC2 = new Pronostico();
        Pronostico qC3 = new Pronostico();
        Pronostico qC4 = new Pronostico();
        Pronostico qS1 = new Pronostico();
        Pronostico qS2 = new Pronostico();
        Pronostico qF = new Pronostico();


        public Pronostico GA
        {
            get { return qGA; }
        }

        public Pronostico GB
        {
            get { return qGB; }
            
        }

        public Pronostico GC
        {
            get { return qGC; }
            
        }

        public Pronostico GD
        {
            get { return qGD; }
            
        }

        public Pronostico GE
        {
            get { return qGE; }
            
        }

        public Pronostico GF
        {
            get { return qGF; }
            
        }

        public Pronostico GG
        {
            get { return qGG; }
            
        }


        public Pronostico GH
        {
            get { return qGH; }
            
        }

        public Pronostico O1
        {
            get { return qO1; }
            
        }

        public Pronostico O2
        {
            get { return qO2; }
            
        }

        public Pronostico O3
        {
            get { return qO3; }
            
        }

        public Pronostico O4
        {
            get { return qO4; }
            
        }

        public Pronostico O5
        {
            get { return qO5; }
            
        }

        public Pronostico O6
        {
            get { return qO6; }
            
        }

        public Pronostico O7
        {
            get { return qO7; }
            
        }

        public Pronostico O8
        {
            get { return qO8; }
            
        }

        public Pronostico C1
        {
            get { return qC1; }
            
        }

        public Pronostico C2
        {
            get { return qC2; }
            
        }

        public Pronostico C3
        {
            get { return qC3; }
            
        }

        public Pronostico C4
        {
            get { return qC4; }
            
        }


        public Pronostico S1
        {
            get { return qS1; }
            
        }

        public Pronostico S2
        {
            get { return qS2; }
            
        }

        public Pronostico F
        {
            get { return qF; }
            
        }

        

        public Quiniela(String nombre, String propietario, String torneo)
        {
            this.propietario = propietario;
            this.torneo = torneo;
            this.nombreQuiniela = nombre;
            String consulta = "Select max(codigoQuiniela) from Quiniela";
            Consulta(consulta);
            if (Dr.HasRows)
            {
                Dr.Read();
                if(!Dr.IsDBNull(0))
                codigoQuiniela = Convert.ToString(Dr.GetInt32(0));
            }
         Pronostico qGA= new Pronostico();
         Pronostico qGB= new Pronostico();
         Pronostico qGC= new Pronostico();
         Pronostico qGD= new Pronostico();
         Pronostico qGF= new Pronostico();
         Pronostico qGG= new Pronostico();
         Pronostico qGH= new Pronostico();
         Pronostico qGE= new Pronostico();
         Pronostico qO2= new Pronostico();
         Pronostico qO3= new Pronostico();
         Pronostico qO4= new Pronostico();
         Pronostico qO5= new Pronostico();
         Pronostico qO6= new Pronostico();
         Pronostico qO7= new Pronostico();
         Pronostico qO8= new Pronostico();
         Pronostico qO1= new Pronostico();
         Pronostico qC1= new Pronostico();
         Pronostico qC2= new Pronostico();
         Pronostico qC3= new Pronostico();
         Pronostico qC4= new Pronostico();
         Pronostico qS1= new Pronostico();
         Pronostico qS2= new Pronostico();
        }
    



        public  Boolean existeQuiniela(String nombre, String usuario)
        {
            Boolean respuesta = true;
            String consulta = "Select * from Quiniela where nombreQuiniela='" + nombreQuiniela + "' and propietario=(select codigoUsuario from Usuario where nombreUsuario='" + usuario + "')" ;
            Consulta(consulta);
            respuesta = Dr.Read();
            String consulta1 = "select codigoUsuario from Usuario where nombreUsuario='" + usuario + "'";
            Consulta(consulta1);
            Dr.Read();
            propietario = Convert.ToString(Dr.GetInt32(0));
            return respuesta;
        }


        public void inicializarPronosticos()
        {
            Pronostico qGA = new Pronostico();
            Pronostico qGB = new Pronostico();
            Pronostico qGC = new Pronostico();
            Pronostico qGD = new Pronostico();
            Pronostico qGF = new Pronostico();
            Pronostico qGG = new Pronostico();
            Pronostico qGH = new Pronostico();
            Pronostico qGE = new Pronostico();
            Pronostico qO2 = new Pronostico();
            Pronostico qO3 = new Pronostico();
            Pronostico qO4 = new Pronostico();
            Pronostico qO5 = new Pronostico();
            Pronostico qO6 = new Pronostico();
            Pronostico qO7 = new Pronostico();
            Pronostico qO8 = new Pronostico();
            Pronostico qO1 = new Pronostico();
            Pronostico qC1 = new Pronostico();
            Pronostico qC2 = new Pronostico();
            Pronostico qC3 = new Pronostico();
            Pronostico qC4 = new Pronostico();
            Pronostico qS1 = new Pronostico();
            Pronostico qS2 = new Pronostico();
        }

        public void  grabarQuiniela(String nombre)
        {
            String consulta = "Insert into Quiniela(nombreQuiniela, fechaCreacion, fechaModificacion, propietario, torneo)values('"+nombre+ "',@time, @time," + propietario + "," + torneo + ")";
            consultaFecha(consulta);
        }

        public void grabarQuiniela()
        {
            String consulta = "Insert into Quiniela(nombreQuiniela, fechaCreacion, fechaModificacion, propietario, torneo)values('" + nombreQuiniela + "',@time, @time," + propietario + "," + torneo + ")";
            consultaFecha(consulta);
            String consulta1 = "Select max(codigoQuiniela) from Quiniela";
            Consulta(consulta1);
            if (Dr.HasRows)
            {
                Dr.Read();
                if (!Dr.IsDBNull(0))
                    codigoQuiniela = Convert.ToString(Dr.GetInt32(0));
            }
        }

        public void salvarQuiniela()
        {
            grabarGrupos();
            grabarOctavos();
            grabarCuartos();
            grabarSemis();
            grabarFinal();
        }

        public void grabarGrupos()
        {
            String consulta = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GA.Primero + "," + GA.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GB.Primero + "," + GB.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta1);
            String consulta2 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GC.Primero + "," + GC.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta3 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GD.Primero + "," + GD.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta4 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GE.Primero + "," + GE.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta5 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GF.Primero + "," + GF.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta6 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GG.Primero + "," + GG.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta7 = "Insert into Pronostico(primerPuesto, segundoPuesto,fase,quinielaMadre)values(" + GH.Primero + "," + GH.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

        public void grabarOctavos()
        {
            String consulta = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O1.Primero + "," + O1.Segundo + "," + O1.Ganador +",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O2.Primero + "," + O2.Segundo + "," + O2.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta2 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O3.Primero + "," + O3.Segundo + "," + O3.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta3 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O4.Primero + "," + O4.Segundo + "," + O4.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta4 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O5.Primero + "," + O5.Segundo + "," + O5.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta5 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O6.Primero + "," + O6.Segundo + "," + O6.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta6 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O7.Primero + "," + O7.Segundo + "," + O7.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta7 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + O8.Primero + "," + O8.Segundo + "," + O8.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

        public void grabarCuartos()
        {
            String consulta = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + C1.Primero + "," + C1.Segundo + "," + C1.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + C2.Primero + "," + C2.Segundo + "," + C2.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta2 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + C3.Primero + "," + C3.Segundo + "," + C3.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta3 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + C4.Primero + "," + C4.Segundo + "," + C4.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

        public void grabarSemis()
        {
            String consulta = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + S1.Primero + "," + S1.Segundo + "," + S1.Ganador + ",'semifinales'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + S2.Primero + "," + S2.Segundo + "," + S2.Ganador + ",'semifinales'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

        public void grabarFinal()
        {
            String consulta = "Insert into Pronostico(primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values(" + F.Primero + "," + F.Segundo + "," + F.Ganador + ",'finales'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

    }
}
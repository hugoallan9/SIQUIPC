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

        public Quiniela(String codigo)
        {
            this.codigoQuiniela = codigo;
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
    
    



        public  Boolean existeQuiniela(String nombre, String usuario, String torneo)
        {
            Boolean respuesta = true;
            String consulta = "Select * from Quiniela where nombreQuiniela='" + nombreQuiniela + "' and torneo="+ torneo  +"and propietario=(select codigoUsuario from Usuario where nombreUsuario='" + usuario + "')" ;
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
            String consulta = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoA'," + GA.Primero + "," + GA.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoB'," + GB.Primero + "," + GB.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta1);
            String consulta2 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoC'," + GC.Primero + "," + GC.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta2);
            String consulta3 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoD'," + GD.Primero + "," + GD.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta3);
            String consulta4 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoE'," + GE.Primero + "," + GE.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta4);
            String consulta5 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoF'," + GF.Primero + "," + GF.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta5);
            String consulta6 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoG'," + GG.Primero + "," + GG.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta6);
            String consulta7 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto,fase,quinielaMadre)values('grupoH'," + GH.Primero + "," + GH.Segundo + ",'grupos'," + codigoQuiniela + ")";
            Consulta(consulta7);
        }

        public void grabarOctavos()
        {
            String consulta = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo1'," + O1.Primero + "," + O1.Segundo + "," + O1.Ganador +",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo2'," + O2.Primero + "," + O2.Segundo + "," + O2.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta1);
            String consulta2 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo3'," + O3.Primero + "," + O3.Segundo + "," + O3.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta2);
            String consulta3 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo4'," + O4.Primero + "," + O4.Segundo + "," + O4.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta3);
            String consulta4 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo5'," + O5.Primero + "," + O5.Segundo + "," + O5.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta4);
            String consulta5 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo6'," + O6.Primero + "," + O6.Segundo + "," + O6.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta5);
            String consulta6 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo7'," + O7.Primero + "," + O7.Segundo + "," + O7.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta6);
            String consulta7 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('octavo8'," + O8.Primero + "," + O8.Segundo + "," + O8.Ganador + ",'octavos'," + codigoQuiniela + ")";
            Consulta(consulta7);
        }

        public void grabarCuartos()
        {
            String consulta = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('cuarto1'," + C1.Primero + "," + C1.Segundo + "," + C1.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('cuarto2'," + C2.Primero + "," + C2.Segundo + "," + C2.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta1);
            String consulta2 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('cuarto3'," + C3.Primero + "," + C3.Segundo + "," + C3.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta2);
            String consulta3 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('cuarto4'," + C4.Primero + "," + C4.Segundo + "," + C4.Ganador + ",'cuartos'," + codigoQuiniela + ")";
            Consulta(consulta3);
        }

        public void grabarSemis()
        {
            String consulta = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('semifinal1'," + S1.Primero + "," + S1.Segundo + "," + S1.Ganador + ",'semifinales'," + codigoQuiniela + ")";
            Consulta(consulta);
            String consulta1 = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('semifinal2'," + S2.Primero + "," + S2.Segundo + "," + S2.Ganador + ",'semifinales'," + codigoQuiniela + ")";
            Consulta(consulta1);
        }

        public void grabarFinal()
        {
            String consulta = "Insert into Pronostico(nombre,primerPuesto, segundoPuesto, ganador, fase,quinielaMadre)values('final'," + F.Primero + "," + F.Segundo + "," + F.Ganador + ",'finales'," + codigoQuiniela + ")";
            Consulta(consulta);
        }

        public void calcularResultado(String codigoQuiniela, String idQuiniela)
        {
            Resultado resultado = new Resultado();
            Resultado provisional = new Resultado();
            String consulta = "select * from Pronostico where quinielaMadre=" + idQuiniela;
            BaseDatos.Consulta(consulta);
            while (BaseDatos.Dr.Read())
            {
                String nombreLlave = Dr.GetString(1);
                String codigoPronostico = Convert.ToString(Dr.GetInt32(0));
                String primerPuesto = Convert.ToString(Dr.GetInt32(2)) ;
                String segundoPuesto = Convert.ToString(Dr.GetInt32(3)); 
                String fase = Dr.GetString(5);
                String ganador ; 
               
                switch(fase)
                {
                    case "grupos":
                        int posicionado = 0;
                        resultado.Consulta("select * from Pronostico where quinielaMadre=" + codigoQuiniela + " and ( primerPuesto=" + primerPuesto + " or primerPuesto=" + segundoPuesto  + " or segundoPuesto=" + segundoPuesto + " or segundoPuesto=" + primerPuesto +")");
                          if (resultado.Dr.HasRows)
                         {
                            resultado.Dr.Read();
                            if(String.Compare(primerPuesto, Convert.ToString(resultado.Dr.GetInt32(2))) == 0  ||  String.Compare(primerPuesto, Convert.ToString(resultado.Dr.GetInt32(3))) ==0)
                             {
                              provisional.Consulta("update Pronostico set esAcertadoPrimero="+ 1 + "where codigoPronostico=" + codigoPronostico);
                              if (String.Compare(primerPuesto, Convert.ToString(resultado.Dr.GetInt32(2))) == 0)
                              {
                                  posicionado++;
                                  provisional.Consulta("update Pronostico set esPosicionado=" + posicionado  + "where codigoPronostico=" + codigoPronostico);
                              }
                            }
                             if (String.Compare(segundoPuesto, Convert.ToString(resultado.Dr.GetInt32(2))) == 0 || String.Compare(segundoPuesto, Convert.ToString(resultado.Dr.GetInt32(3))) == 0)
                             {
                                provisional.Consulta("update Pronostico set esAcertadoSegundo=" + 1 + "where codigoPronostico=" + codigoPronostico);
                                if (String.Compare(segundoPuesto, Convert.ToString(resultado.Dr.GetInt32(3))) == 0)
                                {
                                    posicionado++;
                                    provisional.Consulta("update Pronostico set esPosicionado=" + posicionado + "where codigoPronostico=" + codigoPronostico);
                                }
                            }
                        }
                        break;
                    case "octavos":
                        ganador =  Convert.ToString(Dr.GetInt32(4));
                        resultado.Consulta("select * from Pronostico where quinielaMadre="+codigoQuiniela +" and ganador='" + ganador + "' and fase='octavos'");
                        if (resultado.Dr.HasRows)
                        {
                            resultado.Dr.Read();
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 1 + "where codigoPronostico=" + codigoPronostico);
                            if (String.Compare(nombreLlave, resultado.Dr.GetString(1)) == 0)
                            {
                                provisional.Consulta("update Pronostico set esPosicionado=" + 2 + "where codigoPronostico=" + codigoPronostico);

                            }

                        }
                        else
                        {
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 0 + "where codigoPronostico=" + codigoPronostico);
                        }
                        break;

                    case "cuartos":
                        ganador = Convert.ToString(Dr.GetInt32(4));
                        
                        resultado.Consulta("select * from Pronostico where quinielaMadre="+codigoQuiniela+" and ganador='" + ganador + "' and fase='cuartos'");
                        if (resultado.Dr.HasRows)
                        {
                            resultado.Dr.Read();
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 1 + "where codigoPronostico=" + codigoPronostico);
                            if (String.Compare(nombreLlave, resultado.Dr.GetString(1)) == 0)
                            {
                                provisional.Consulta("update Pronostico set esPosicionado=" + 4 + "where codigoPronostico=" + codigoPronostico);

                            }

                        }
                        else
                        {
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 0 + "where codigoPronostico=" + codigoPronostico);
                        }
                        break;

                    case "semifinales":
                        ganador = Convert.ToString(Dr.GetInt32(4));
                        
                        resultado.Consulta("select * from Pronostico where quinielaMadre="+codigoQuiniela+" and ganador='" + ganador + "' and fase='semifinales'");
                        if (resultado.Dr.HasRows)
                        {
                            resultado.Dr.Read();
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 1 + "where codigoPronostico=" + codigoPronostico);
                            if (String.Compare(nombreLlave, resultado.Dr.GetString(1)) == 0)
                            {
                                provisional.Consulta("update Pronostico set esPosicionado=" + 8 + "where codigoPronostico=" + codigoPronostico);

                            }

                        }
                        else
                        {
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 0 + "where codigoPronostico=" + codigoPronostico);
                        }
                        break;

                    case "finales":
                        ganador = Convert.ToString(Dr.GetInt32(4));
                        
                        resultado.Consulta("select * from Pronostico where quinielaMadre="+codigoQuiniela+" and ganador='" + ganador + "' and fase='finales'");
                        if (resultado.Dr.HasRows)
                        {
                            resultado.Dr.Read();
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 1 + "where codigoPronostico=" + codigoPronostico);

                        }
                        else
                        {
                            provisional.Consulta("update Pronostico set esAcertadoPrimero=" + 0 + "where codigoPronostico=" + codigoPronostico);
                        }
                        break;
              
            }  
            }
        }

    }
}
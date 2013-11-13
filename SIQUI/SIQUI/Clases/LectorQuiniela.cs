using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace SIQUI.Clases
{
    public class LectorQuiniela:BaseDatos
    {
        private XmlNodeList quinielaUsuario;
        private XmlNodeList datosUsuario;
        private XmlNodeList grupos;
        private XmlNodeList octavos;
        private XmlNodeList cuartos;
        private XmlNodeList semifinales;
        private XmlNodeList finales;
        private XmlDocument documentoXml;
        private Quiniela quiniela;
        private String torneo;
        Usuario user;
      
        
        public LectorQuiniela(String ruta, String torneo)
        {
            this.torneo = torneo;
            documentoXml = new XmlDocument();
            documentoXml.Load(ruta);
            quinielaUsuario = documentoXml.GetElementsByTagName("QuinielaUsuario");
        }

        public void obtenerDatos()
        {
            datosUsuario = ((XmlElement)quinielaUsuario[0]).GetElementsByTagName("Usuario");
            XmlNodeList nombreUsuario = ((XmlElement)datosUsuario[0]).GetElementsByTagName("Nombre");
            //Tratando de obtener el usuario
            user = new Usuario(nombreUsuario[0].InnerText.Trim(), "", "", "", "");
            XmlNodeList quiniela = ((XmlElement)quinielaUsuario[0]).GetElementsByTagName("Quiniela");
            XmlNodeList nombreQuiniela = ((XmlElement)quiniela[0]).GetElementsByTagName("Nombre");
            this.quiniela = new Quiniela(nombreQuiniela[0].InnerText.Trim(), user.Nombre, torneo);
            this.quiniela.inicializarPronosticos();
        }

        public void obtenerQuiniela()
        {
            foreach (XmlElement quiniela in quinielaUsuario)
            {
                grupos = quiniela.GetElementsByTagName("Grupos");
                octavos = quiniela.GetElementsByTagName("Octavos");
                cuartos = quiniela.GetElementsByTagName("Cuartos");
                semifinales = quiniela.GetElementsByTagName("Semifinales");
                finales = quiniela.GetElementsByTagName("Campeon");
            }
            leerGrupos();
            leerOctavos();
            leerCuartos();
            leerSemis();
            leerFinal();
        }

        public String validarQuiniela()
        {
            String respuesta;
            if (quiniela.existeQuiniela(quiniela.nombreQuiniela, user.nombreUsuario))
            {
                respuesta = "La quiniela ya existe, elige otro nombre";
            }
            else
            {
                quiniela.grabarQuiniela();
                quiniela.salvarQuiniela();
                respuesta = "La quiniela ha sido creada";
            }
            return respuesta;
        }

        private void leerFinal()
        {
            quiniela.F.equipoGanador = resolverClave(finales[0].InnerText.Trim());
        }

        private void resolverSemis(string p1, string p2)
        {
            p2 = resolverClave(p2);
            switch (p1)
            {
                case "1":
                    quiniela.S1.equipoGanador = p2;
                    break;
                case "2":
                    quiniela.S1.equipoGanador = p2;
                    break;
            }
        }

        private void leerSemis()
        {
            foreach (XmlElement semifinal in semifinales)
            {
                foreach (XmlElement dato in semifinal)
                {
                    XmlNodeList nombreSemifinal = dato.GetElementsByTagName("Nombre");
                    XmlNodeList ganador = dato.GetElementsByTagName("Ganador");
                    resolverSemis(nombreSemifinal[0].InnerText.Trim(), ganador[0].InnerText.Trim());
                }
            }
        }

        private void leerCuartos()
        {
            foreach (XmlElement cuarto in cuartos)
            {
                foreach (XmlElement dato in cuarto)
                {
                    XmlNodeList nombreCuarto = dato.GetElementsByTagName("Nombre");
                    XmlNodeList ganador = dato.GetElementsByTagName("Ganador");
                    resolverCuartos(nombreCuarto[0].InnerText.Trim(), ganador[0].InnerText.Trim());
                }
            }
        }

        private void resolverCuartos(string p1, string p2)
        {
            p2 = resolverClave(p2);
            switch (p1)
            {
                case "1":
                    quiniela.C1.equipoGanador = p2;
                    break;
                case "2":
                    quiniela.C2.equipoGanador = p2;
                    break;
                case "3":
                    quiniela.C3.equipoGanador = p2;
                    break;
                case "4":
                    quiniela.C4.equipoGanador = p2;
                    break;

            }
        }

        private string resolverClave(string p2)
        {
            String clave = "";
            String consulta = "Select * from Equipo where nombre='"+ p2 + "' and torneo=" + torneo;
            Consulta(consulta);
            if (Dr.HasRows)
            {
                Dr.Read();
                clave = Convert.ToString( Dr.GetInt32(0));
            }
            return clave;
            
        }

        private void leerOctavos()
        {
            foreach (XmlElement octavo in octavos)
            {
                foreach (XmlElement dato in octavo)
                {
                    XmlNodeList nombreOctavo = dato.GetElementsByTagName("Nombre");
                    XmlNodeList ganador = dato.GetElementsByTagName("Ganador");
                    resolverOctavos(nombreOctavo[0].InnerText.Trim(), ganador[0].InnerText.Trim());
                }
            }
        }

        private void resolverOctavos(string p1, string p2)
        {
            p2 = resolverClave(p2);
            switch (p1)
            {
                case "1":
                    quiniela.O1.equipoGanador = p2;
                    break;
                case "2":
                    quiniela.O2.equipoGanador = p2;
                    break;
                case "3":
                    quiniela.O3.equipoGanador = p2;
                    break;
                case "4":
                    quiniela.O4.equipoGanador = p2;
                    break;
                case "5":
                    quiniela.O5.equipoGanador = p2;
                    break;
                case "6":
                    quiniela.O6.equipoGanador = p2;
                    break;
                case "7":
                    quiniela.O7.equipoGanador = p2;
                    break;
                case "8":
                    quiniela.O8.equipoGanador = p2;
                    break;
            }
        }

        private void leerGrupos()
        {
            foreach(XmlElement grupo in grupos)
            {
                foreach (XmlElement dato in grupo)
                {
                    XmlNodeList nombreGrupo = dato.GetElementsByTagName("Nombre");
                    XmlNodeList equipoPrimero = dato.GetElementsByTagName("Posicion1");
                    XmlNodeList equipoSegundo = dato.GetElementsByTagName("Posicion2");
                    asignarGrupo(nombreGrupo[0].InnerText.Trim(), equipoPrimero, equipoSegundo);
                }
            }
        }

        private void asignarGrupo(string p, XmlNodeList equipoPrimero, XmlNodeList equipoSegundo)
        {

            switch (p)
            {
                case "A":
                    quiniela.GA.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GA.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GA.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;

                case "B":
                    quiniela.GB.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GB.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GB.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "C":
                    quiniela.GC.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GC.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GC.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "D":
                    quiniela.GD.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GD.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GD.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "E":
                    quiniela.GE.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GE.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GE.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "F":
                    quiniela.GF.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GF.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GF.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "G":
                    quiniela.GG.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GG.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GG.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;
                case "H":
                    quiniela.GH.equipoPrimero = resolverClave(equipoPrimero[0].InnerText.Trim());
                    quiniela.GH.equipoSegundo = resolverClave(equipoSegundo[0].InnerText.Trim());
                    quiniela.GH.equipoGanador = resolverClave(equipoPrimero[0].InnerText.Trim());
                    break;

                    
            }
        }

      
    }
}
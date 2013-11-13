using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace SIQUI.Clases
{
    public class LectorXml: BaseDatos
    {
        private XmlNodeList quiniela;
        private XmlNodeList estructuraFija;
        private XmlNodeList nombre;
        private XmlNodeList estado;
        private XmlNodeList grupoA;
        private XmlNodeList grupoB;
        private XmlNodeList grupoC;
        private XmlNodeList grupoD;
        private XmlNodeList grupoE;
        private XmlNodeList grupoF;
        private XmlNodeList grupoG;
        private XmlNodeList grupoH;
        private XmlNodeList organiza8vos;
        private XmlNodeList organiza4tos;
        private XmlNodeList organizaSemis;
        private XmlNodeList organizaFinal;
        private XmlDocument documentoXml;
        private int idTorneo = -1;


        public LectorXml(String ruta)
        {
            documentoXml = new XmlDocument();
            documentoXml.Load(ruta);
            quiniela = documentoXml.GetElementsByTagName("Quiniela");
            
        }

        public void obtenerEstructura()
        {
            estructuraFija = ((XmlElement)quiniela[0]).GetElementsByTagName("EstructuraFija");
            foreach(XmlElement nodo in estructuraFija)
            {
                nombre = nodo.GetElementsByTagName("Nombre");
                estado = nodo.GetElementsByTagName("Estado");
                grupoA = nodo.GetElementsByTagName("GrupoA");
                grupoB = nodo.GetElementsByTagName("GrupoB");
                grupoC = nodo.GetElementsByTagName("GrupoC");
                grupoD = nodo.GetElementsByTagName("GrupoD");
                grupoE = nodo.GetElementsByTagName("GrupoE");
                grupoF = nodo.GetElementsByTagName("GrupoF");
                grupoG = nodo.GetElementsByTagName("GrupoG");
                grupoH = nodo.GetElementsByTagName("GrupoH");
                organiza8vos = nodo.GetElementsByTagName("Organiza8vos");
                organiza4tos = nodo.GetElementsByTagName("Organiza4tos");
                organizaSemis = nodo.GetElementsByTagName("OrganizaSemiFinal");
                organizaFinal = nodo.GetElementsByTagName("OrganizaFinal");
            }

            crearTorneo();
            getIdCampeonato(nombre[0].InnerText);
            desgloseEquipos();
            faseOctavos();
            faseCuartos();
            faseSemis();
            faseFinal();

        }

        private void faseFinal()
        {
            foreach (XmlElement equipo in organizaFinal)
            {
                XmlNodeList final = ((XmlElement)organizaFinal[0]).GetElementsByTagName("Final");
                foreach (XmlElement Orgs in final)
                {

                    XmlNodeList rival1 = Orgs.GetElementsByTagName("Rival1");
                    XmlNodeList rival2 = Orgs.GetElementsByTagName("Rival2");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);
                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'Final'," + idTorneo + ",'Final'" + ")";
                    Consulta(query4);



                }
            }
        }

        private void faseSemis()
        {
            foreach (XmlElement equipo in organizaSemis)
            {
                XmlNodeList semi1 = ((XmlElement)organizaSemis[0]).GetElementsByTagName("Semi1");
                foreach (XmlElement Orgs in semi1)
                {

                    XmlNodeList rival1 = Orgs.GetElementsByTagName("Rival1");
                    XmlNodeList rival2 = Orgs.GetElementsByTagName("Rival2");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);
                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'SemiFinal'," + idTorneo + ",'Semi1'" + ")";
                    Consulta(query4);
                }


                XmlNodeList semi2 = ((XmlElement)organizaSemis[0]).GetElementsByTagName("Semi2");
                foreach (XmlElement Orgs in semi2)
                {

                    XmlNodeList rival1 = Orgs.GetElementsByTagName("Rival1");
                    XmlNodeList rival2 = Orgs.GetElementsByTagName("Rival2");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);
                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'SemiFinal'," + idTorneo + ",'Semi2'" + ")";
                    Consulta(query4);
                }
            }
        }

        private void faseCuartos()
        {
            foreach (XmlElement equipo in organiza4tos)
            {
                XmlNodeList cuarto1 = ((XmlElement)organiza4tos[0]).GetElementsByTagName("Cuarto1");
                foreach (XmlElement Org4 in cuarto1)
                {

                    XmlNodeList rival1 = Org4.GetElementsByTagName("Rival1");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    XmlNodeList rival2 = Org4.GetElementsByTagName("Rival2");
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")" ;
                    Consulta(query2);

                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'cuartos'," + idTorneo + ",'Cuarto1'" + ")";
                    Consulta(query4);
                }


                XmlNodeList cuarto2 = ((XmlElement)organiza4tos[0]).GetElementsByTagName("Cuarto2");
                foreach (XmlElement Org4 in cuarto2)
                {

                    XmlNodeList rival1 = Org4.GetElementsByTagName("Rival1");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    XmlNodeList rival2 = Org4.GetElementsByTagName("Rival2");
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);

                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'cuartos'," + idTorneo + ",'Cuarto2'" + ")";
                    Consulta(query4);


                }



                XmlNodeList cuarto3 = ((XmlElement)organiza4tos[0]).GetElementsByTagName("Cuarto3");
                foreach (XmlElement Org4 in cuarto3)
                {

                    XmlNodeList rival1 = Org4.GetElementsByTagName("Rival1");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    XmlNodeList rival2 = Org4.GetElementsByTagName("Rival2");
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);

                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'cuartos'," + idTorneo + ",'Cuarto3'" + ")";
                    Consulta(query4);


                }


                XmlNodeList cuarto4 = ((XmlElement)organiza4tos[0]).GetElementsByTagName("Cuarto4");
                foreach (XmlElement Org4 in cuarto4)
                {

                    XmlNodeList rival1 = Org4.GetElementsByTagName("Rival1");
                    String query1 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival1[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query1);
                    XmlNodeList rival2 = Org4.GetElementsByTagName("Rival2");
                    String query2 = "Insert Equipo_Ficticio(nombre,torneo) values ('" + rival2[0].InnerText.Trim() + "'," + idTorneo + ")";
                    Consulta(query2);

                    String query3 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query3);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query4 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'cuartos'," + idTorneo + ",'Cuarto4'" + ")";
                    Consulta(query4);


                }


            }
        }

        private void faseOctavos()
        {
            foreach (XmlElement equipo in organiza8vos)
            {
                //-----------------------------------------------------------------------------------------
                XmlNodeList octavo1 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo1");
                foreach (XmlElement Org8 in octavo1)
                {

                    XmlNodeList Rival = ((XmlElement)octavo1[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('"+ grupo[0].InnerText.Trim() + "','"+ posicion[0].InnerText.Trim() + "'," +  idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo1[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values("+ riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos1'" +  ")"  ;
                    Consulta(query3);
                }
                //-------------------------------------------------------------------------------

                XmlNodeList octavo2 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo2");
                foreach (XmlElement Org8 in octavo2)
                {

                    XmlNodeList Rival = ((XmlElement)octavo2[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo2[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    //String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" +riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos2'" + ")";
                    //Consulta(query3);
                }

                //_----------------------------------------------------------------------------------

                XmlNodeList octavo3 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo3");
                foreach (XmlElement Org8 in octavo3)
                {

                    XmlNodeList Rival = ((XmlElement)octavo3[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo3[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos3'" + ")";
                    Consulta(query3);
                }
                //------------------------------------------------------------------------------------------

                XmlNodeList octavo4 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo4");
                foreach (XmlElement Org8 in octavo4)
                {

                    XmlNodeList Rival = ((XmlElement)octavo4[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo4[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos4'" + ")";
                    Consulta(query3);
                }                
                
                //-----------------------------------------------------------------------------------------


                XmlNodeList octavo5 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo5");
                foreach (XmlElement Org8 in octavo5)
                {

                    XmlNodeList Rival = ((XmlElement)octavo5[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo5[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos5'" + ")";
                    Consulta(query3);
                }
                //----------------------------------------------------------------------------------------


                XmlNodeList octavo6 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo6");
                foreach (XmlElement Org8 in octavo6)
                {

                    XmlNodeList Rival = ((XmlElement)octavo6[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo6[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos6'" + ")";
                    Consulta(query3);
                }

                //------------------------------------------------------------------------------------------
                XmlNodeList octavo7 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo7");
                foreach (XmlElement Org8 in octavo7)
                {

                    XmlNodeList Rival = ((XmlElement)octavo7[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo7[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos7'" + ")";
                    Consulta(query3);
                }

                //------------------------------------------------------------------------------------------
                XmlNodeList octavo8 = ((XmlElement)organiza8vos[0]).GetElementsByTagName("Octavo8");
                foreach (XmlElement Org8 in octavo8)
                {

                    XmlNodeList Rival = ((XmlElement)octavo8[0]).GetElementsByTagName("Rival1");
                    foreach (XmlElement rival in Rival)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }
                    XmlNodeList Rival2 = ((XmlElement)octavo8[0]).GetElementsByTagName("Rival2");
                    foreach (XmlElement rival in Rival2)
                    {
                        XmlNodeList grupo = rival.GetElementsByTagName("Grupo");
                        XmlNodeList posicion = rival.GetElementsByTagName("Posicion");
                        String query1 = "Insert into Equipo_Ficticio(grupo, posicion, torneo) values ('" + grupo[0].InnerText.Trim() + "','" + posicion[0].InnerText.Trim() + "'," + idTorneo + ")";
                        Consulta(query1);

                    }

                    String query2 = "select * from (select top(2) codigoEquipoFicticio from Equipo_Ficticio order by codigoEquipoFicticio DESC) b";
                    Consulta(query2);
                    Dr.Read();
                    int riv2 = Dr.GetInt32(0);
                    Dr.Read();
                    int riv1 = Dr.GetInt32(0);
                    String query3 = "Insert into Duelo_Ficticio(rival2,rival1,fase,torneo,nombre)values(" + riv2 + "," + riv1 + ",'octavos'," + idTorneo + ",'Octavos8'" + ")";
                    Consulta(query3);
                }
            }
        }

        private void getIdCampeonato(string p)
        {
            String consulta = "Select codigoTorneo from Torneo where nombreTorneo='" + p + "'";
            Consulta(consulta);
            if (Dr.Read())
            {
                idTorneo = Dr.GetInt32(0);
            }
        }

        private void desgloseEquipos()
        {
            foreach (XmlElement equipo in grupoA)
            {
                XmlNodeList equipo1A = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2A = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3A = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4A = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1A[0].InnerText.Trim() + "','" + "A" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2A[0].InnerText.Trim() + "','" + "A" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3A[0].InnerText.Trim() + "','" + "A" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4A[0].InnerText.Trim() + "','" + "A" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoB)
            {
                XmlNodeList equipo1B = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2B = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3B = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4B = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1B[0].InnerText.Trim() + "','" + "B" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2B[0].InnerText.Trim() + "','" + "B" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3B[0].InnerText.Trim() + "','" + "B" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4B[0].InnerText.Trim() + "','" + "B" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoC)
            {
                XmlNodeList equipo1C = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2C = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3C = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4C = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1C[0].InnerText.Trim() + "','" + "C" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2C[0].InnerText.Trim() + "','" + "C" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3C[0].InnerText.Trim() + "','" + "C" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4C[0].InnerText.Trim() + "','" + "C" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoD)
            {
                XmlNodeList equipo1D = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2D = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3D = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4D = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1D[0].InnerText.Trim() + "','" + "D" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2D[0].InnerText.Trim() + "','" + "D" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3D[0].InnerText.Trim() + "','" + "D" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4D[0].InnerText.Trim() + "','" + "D" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoE)
            {
                XmlNodeList equipo1E = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2E = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3E = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4E = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1E[0].InnerText.Trim() + "','" + "E" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2E[0].InnerText.Trim() + "','" + "E" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3E[0].InnerText.Trim() + "','" + "E" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4E[0].InnerText.Trim() + "','" + "E" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoF)
            {
                XmlNodeList equipo1F = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2F = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3F = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4F = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1F[0].InnerText.Trim() + "','" + "F" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2F[0].InnerText.Trim() + "','" + "F" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3F[0].InnerText.Trim() + "','" + "F" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4F[0].InnerText.Trim() + "','" + "F" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoG)
            {
                XmlNodeList equipo1G = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2G = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3G = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4G = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1G[0].InnerText.Trim() + "','" + "G" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2G[0].InnerText.Trim() + "','" + "G" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3G[0].InnerText.Trim() + "','" + "G" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4G[0].InnerText.Trim() + "','" + "G" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }

            foreach (XmlElement equipo in grupoH)
            {
                XmlNodeList equipo1H = equipo.GetElementsByTagName("Equipo1");
                XmlNodeList equipo2H = equipo.GetElementsByTagName("Equipo2");
                XmlNodeList equipo3H = equipo.GetElementsByTagName("Equipo3");
                XmlNodeList equipo4H = equipo.GetElementsByTagName("Equipo4");
                String query1 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo1H[0].InnerText.Trim() + "','" + "H" + "'," + idTorneo + ")";
                String query2 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo2H[0].InnerText.Trim() + "','" + "H" + "'," + idTorneo + ")";
                String query3 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo3H[0].InnerText.Trim() + "','" + "H" + "'," + idTorneo + ")";
                String query4 = "Insert into Equipo(nombre,grupo, torneo) values (" + "'" + equipo4H[0].InnerText.Trim() + "','" + "H" + "'," + idTorneo + ")";
                Consulta(query1);
                Consulta(query2);
                Consulta(query3);
                Consulta(query4);
            }
        }

        private void crearTorneo()
        {
            String consulta = "Insert into Torneo(nombreTorneo, anio, estado)values('" + nombre[0].InnerText + "',@time,'" + estado[0].InnerText + "')";
            BaseDatos.consultaFecha(consulta);
        }









    }
}
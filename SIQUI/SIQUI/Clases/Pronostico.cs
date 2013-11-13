using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIQUI.Clases
{
    public class Pronostico
    {
        public String equipoPrimero;
        public String equipoSegundo;
        public String equipoGanador;

        public Pronostico()
        {
            equipoGanador = "1";
            equipoPrimero = "1";
            equipoSegundo = "1";
        }

        public String Primero
        {
            set { equipoPrimero = value; }
            get { return equipoPrimero; }
        }

        public String Segundo
        {
            set { equipoSegundo = value; }
            get { return equipoSegundo; }
        }

        public String Ganador
        {
            set { equipoGanador = value; }
            get { return equipoGanador; }
        }
    }
}
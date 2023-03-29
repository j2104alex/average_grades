using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_calificacion
{
    public class Calificacion
    {
        //Bloque de atributo
        #region Atributo
        private string Identificacion;
        private string Nombre;
        private double N1;
        private double N2;
        private double N3;
        private double N4;
        private double Promedio;
        private string Error;
        #endregion

        //Bloque de metodos publicos
        #region Metodos publicos
        public Calificacion()
        {
            //Inicializacion de variables
            N1 = 0;
            N2 = 0;
            N3 = 0;
            N4 = 0;
            Promedio = 0;
            Error = "";
            Identificacion = "";
            Nombre = "";
        }

        public bool Calcular()
        {
            if (!Validar())
                return false;
            try
            {
                Promedio = (N1 + N2 + N3 + N4) / 4;
                return true;
            } catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }
        #endregion

        //Bloque de metodos privados
        #region Metodos privados
        private bool Validar()
        {
            //Condicionales de notas
            if (N1 < 0 || N1 > 5)
            {
                Error = "La primer nota no es válida, inserte un valor del 0 al 5";
                return false;
            }
            if (N2 < 0 || N2 > 5)
            {
                Error = "La segunda nota no es válida, inserte un valor del 0 al 5";
                return false;
            }
            if (N3 < 0 || N3 > 5)
            {
                Error = "La tercera nota no es válida, inserte un valor del 0 al 5";
                return false;
            }
            if (N4 < 0 || N4 > 5)
            {
                Error = "La cuarta nota no es válida, inserte un valor del 0 al 5";
                return false;
            }
            return true;
        }
        #endregion

        //Bloque de propiedades
        #region Propiedades
        public double SETN1
        {
            set { N1 = value; }
        }
        public double SETN2
        {
            set { N2 = value; }
        }
        public double SETN3
        {
            set { N3 = value; }
        }
        public double SETN4
        {
            set { N4 = value; }
        }
        public string SETNombre
        {
            set { Nombre = value; }
        }
        public string SETIdentificacion
        {
            set { Identificacion = value; }
        }
        public double GETPromedio
        {
            get { return Promedio; }
        }
        public string GETError
        {
            get { return Error; }
        }
        #endregion
    }
}

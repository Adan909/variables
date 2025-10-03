using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables.Modelos
{
    public class Arreglo
    {
        public static int[] edades = new int[10];
        public static int pos = 0;

        public static int GetPromedio()
        {
            int prom = 0;
            int suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = (int)suma / pos;
            return prom;
        }

        public static double GetPromedioD()
        {
            double prom = 0;
            double suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = (int)suma / pos;
            return prom;
        }
        public static int GetMax()
        {
            int edadMaxima = 0;
            foreach (int edad in edades)
            {
                if (edad > edadMaxima)
                {
                    edadMaxima = edad;
                }
            }
            return edadMaxima;
        }
        public static int GetMin()
        {
            int edadMinima = edades[0];
            for (int i = 1; i < pos; i++)
            {
                if (edades[i] < edadMinima) edadMinima = edades[i];
            }
            return edadMinima;
        }

        public static int GetMayoresEdad()
        {
            int edadMayor = 0;
            foreach (int edad in edades)
            {
                if (edad > 17)
                {
                    edadMayor++;
                }
            }
            return edadMayor;

        }
        public static int GetMenoresEdad()
        {
            int edadMenor = 0;
            foreach (int edad in edades)
            {
                if (edad > 0 & edad < 17)
                {
                    edadMenor++;
                }
            }
            return edadMenor;
        }
    }
}
       


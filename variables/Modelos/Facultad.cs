using System;


namespace variables.Modelos
{
    public class Facultad
    {
        public String Nombre;
        public String Codigo;

        public String MostrarDatos()
        {
            return "Facultad: " + Nombre + " Codigo: " + Codigo;

        }

    }
}

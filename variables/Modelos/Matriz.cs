using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace variables.Modelos
{
    public class Matriz
    {
        private const int fila= 2, columna= 2;
        private int[,] matrizCuadrada = new int[fila, columna];
        public int r { set; get; }  
        public int c { set; get; }

        public void Agregar(int dato)
        {
            if (r == fila || c == columna) return;
            
            if(c == columna)
            {
                c = 0;
                r++;
            }
            matrizCuadrada[r, c] = dato;
            c++;
        }

        public int[,] getMatrizC()
        {
            return this.matrizCuadrada;
        }
    }
}

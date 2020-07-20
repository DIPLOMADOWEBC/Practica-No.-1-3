using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_3
{
    class Program
    {
        private float[,] matr;

        static void Main(string[] args)
        {
            #region Ejemplo 2: Crear una matriz de 3 filas por 4 columnas e ingresar valores enteros, imprimir la primera fila.Imprimir la última fila e imprimir la primer columna

            Program prom = new Program();
            prom.Cargar();
            prom.imprimirPriFila();
            prom.imprimirUltFila();
            prom.imprimirPriColumna();

            Console.ReadKey();
            #endregion
        }
        public void Cargar()
        {

            matr = new float[3, 4];

            Console.WriteLine("MATRIS 3X4 \n");
            for (int f = 0; f < matr.GetLength(0); f++)
            {
                for (int c = 0; c < matr.GetLength(1); c++)
                {
                    Console.Write("INGRECE VALOR: ");
                    matr[f, c] = float.Parse(Console.ReadLine());
                }
            }

        }
        public void imprimirPriFila()
        {
            Console.WriteLine("\n*** PRIMERA FILA ***");
            for (int c = 0; c < matr.GetLength(1); c++)
            {
                Console.Write(matr[0, c] + " ");
            }
            Console.WriteLine(" ");
        }
        public void imprimirUltFila()
        {
            Console.WriteLine("\n*** ULTIMA FILA ***");
            for (int c = 0; c < matr.GetLength(1); c++)
            {
                Console.Write(matr[matr.GetLength(0) - 1, c] + " ");
            }
            Console.WriteLine(" ");
        }
        public void imprimirPriColumna()
        {
            Console.WriteLine("\n*** PRIMERA COLUMNA ***");
            for (int c = 0; c < matr.GetLength(0); c++)
            {
                Console.Write(matr[c, 0] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_3
{
    class Program
    {
        private double[,] salarios;
        private double salarioTar, salarioMa;

        static void Main(string[] args)
        {
            #region Ejemplo 1: Una empresa tiene dos turnos(mañana y tarde) en los que trabajan 8 empleados(4 por la mañana y 4 por la tarde)
            /*
                Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados por turno. Imprimir los gastos en sueldos de cada turno.            */
            Program prom = new Program();
            prom.Cargar();
            prom.GastosTurno();

            #endregion
        }
        public void Cargar()
        {

            salarios = new double[8, 2];

            Console.WriteLine("SUELDOS AGRUPADOS POR TURNO \n");
            for (int f = 0; f < salarios.GetLength(0); f++)
            {
                //AGRUPAR
                //Console.Write("TURNO: 1= MAÑANA | 2= TARDE: "); NO SE INGRESARA POR TECLADO, ESTO SERA FIJO 4 TURNOS EN LA MA:ANA y 4 TURNOS EN LA TARDE
                if (f < 4)
                    salarios[f, 0] = 1;//double.Parse(Console.ReadLine());
                else
                    salarios[f, 0] = 2;

                Console.Write("INGRECE SALARIO EMPLEADO {0}: ", (f + 1));
                salarios[f, 1] = double.Parse(Console.ReadLine());

                Console.WriteLine();

            }

        }
        public void GastosTurno()
        {
            for (int f = 0; f < salarios.GetLength(0); f++)
            {
                if (salarios[f, 0] == 1) //1= MAÑANA
                {
                    salarioMa += salarios[f, 1];
                }
                else if (salarios[f, 0] == 2) //2= TARDE
                {
                    salarioTar += salarios[f, 1];
                }
            }
            Console.WriteLine("TOTAL GASTO EN TURNO MAÑANA: {0}", salarioMa);
            Console.WriteLine("TOTAL GASTO EN TURNO TARDE: {0}", salarioTar);
            Console.ReadKey();
        }
    }
}

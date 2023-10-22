using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IExamenPrograC
{
    internal class ClsSubMenuReportes
    {
        private static byte opcion = 0;

        public static void submenu()
        {
            do
            {
                Console.WriteLine("1-Consultar Empleados");
                Console.WriteLine("2-Listar todos los Empleados");
                Console.WriteLine("3-Calcular y mostrar Promedios de Salarios");
                Console.WriteLine("4-Calcular y mostrar el salario mas alto y mas bajo de todos los Empleados");
                Console.WriteLine("5-Salir");
                byte.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.PorCedula(); break;
                    case 2: ClsEmpleado.ReporteGeneral(); break;
                    case 3: ClsEmpleado.PromedioSalario(); break;
                    case 4: ClsEmpleado.SalarioMasAltoYBajo(); break;


                    default:
                        break;

                }
            } while (opcion != 5);

        }

    }
}

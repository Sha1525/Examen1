using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IExamenPrograC
{
    internal class ClsMenu
    {
        static int opcion = 0;

        static public void Desplegar()
        {
            do
            {

                Console.WriteLine("1- Inicializar Arreglos");
                Console.WriteLine("2- Agregar Empleados");
                Console.WriteLine("3- Modificar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Consultar Empleados");
                Console.WriteLine("6- Reportes");
                Console.WriteLine("7- Salir");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        ClsEmpleado.Inicializar();
                        break;

                    case 2:
                        ClsEmpleado.AgregarEmpleado();
                        break;

                    case 3:
                        ClsEmpleado.ModificarEmpleado();
                        break;


                    case 4:
                        ClsEmpleado.BorrarEmpleado();
                        break;

                    case 5:
                        ClsEmpleado.ConsultarEmpleados();
                        break;

                    case 6:
                        ClsSubMenuReportes.submenu();
                        break;

                    default:
                        Console.WriteLine("Ingreso una opcion incorrecta");
                        break;
                }


            } while (opcion != 7);

        }
    }
}

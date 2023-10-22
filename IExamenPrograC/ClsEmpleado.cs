using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IExamenPrograC
{
    internal class ClsEmpleado
    {
        //atributos/
        static int cant = 5;
        static string[] cedula = new string[cant];
        static string[] nombre = new string[cant];
        static string[] direccion = new string[cant];
        static string[] telefono = new string[cant];
        static float[] salario = new float[cant];
        static byte indice;
        static int cont;

        //metodos/

        public static void Inicializar()
        {
            cant = 5;
            indice = 0;
            cont = 0;
            cedula = Enumerable.Repeat("", cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            direccion = Enumerable.Repeat("", cant).ToArray();
            telefono = Enumerable.Repeat("", cant).ToArray();
            salario = Enumerable.Repeat(0f, cant).ToArray();
            Console.WriteLine("Los Arreglos han sido inicializados");

        }

        public static void ConsultarEmpleados()
        {
            Console.WriteLine("*********LISTA DE EMPLEADOS:*************");

            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]}");
                Console.WriteLine($"Nombre: {nombre[i]}");
                Console.WriteLine($"Direccion: {direccion[i]}");
                Console.WriteLine($"Telefono: {telefono[i]}");
                Console.WriteLine($"Salario: {salario[i]}");
                Console.WriteLine("-----------------------------");
            }
        }

        public static void ReporteGeneral()
        {
            Console.WriteLine("**************REPORTE GENERAL**************");
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"Cedula:{cedula[i]} " +
                                  $"Nombre: {nombre[i]} " +
                                  $"Direccion: {direccion[i]}  " +
                                  $"Telefono:{telefono[i]}  " +
                                  $"Salario:{salario[i]} ");

            }
            Console.WriteLine("**************ULTIMA LINEA**************");
        }


        public static void PromedioSalario()
        {
            Console.WriteLine("**************Promedio de Salarios***************");

            float suma = 0;


            for (int i = 0; i < cant; i++)
            {

                suma += ClsEmpleado.salario[i];
            }
            float promedio = suma / cant;
            Console.WriteLine("********El promedio de los Salarios es:" + promedio + "***********");
        }

        public static void PorCedula()
        {
            Console.WriteLine("Digite la Cedula");
            string cedula = Console.ReadLine();
            Boolean encontro = false;

            for (int i = 0; i < cant; i++)
            {
                if (cedula.Equals(ClsEmpleado.cedula[i]))
                {
                    Console.WriteLine($"Cedula:{cedula[i]} " +
                                      $"Nombre: {nombre[i]} " +
                                      $"Direccion: {direccion[i]} " +
                                      $"Telefono:  {telefono[i]} " +
                                      $"Salario: {salario[i]} ");

                    encontro = true;
                    break;
                }
            }
            if (encontro == false)
            {
                Console.WriteLine("La cedula no existe");
            }
        }

        public static void SalarioMasAltoYBajo()
        {
            Console.WriteLine("Salario mas alto y salario más bajo");

            if (cant == 0)
            {
                Console.WriteLine("No hay salarios para analizar.");
                return;
            }

            float salarioMasAlto = ClsEmpleado.salario[0];
            float salarioMasBajo = ClsEmpleado.salario[0];

            for (int i = 1; i < cant; i++)
            {
                if (ClsEmpleado.salario[i] > salarioMasAlto)
                {
                    salarioMasAlto = ClsEmpleado.salario[i];
                }

                if (ClsEmpleado.salario[i] < salarioMasBajo)
                {
                    salarioMasBajo = ClsEmpleado.salario[i];
                }
            }

            Console.WriteLine("Salario Más Alto: " + salarioMasAlto);
            Console.WriteLine("Salario Más Bajo: " + salarioMasBajo);
        }

        public static void ModificarEmpleado()
        {
            Console.WriteLine("Modificar Empleado");

            Console.Write("Ingrese la cédula del empleado a modificar: ");
            string cedulaBuscada = Console.ReadLine();

            for (int i = 0; i < cont; i++)
            {
                if (cedula[i] == cedulaBuscada)
                {
                    Console.WriteLine($"Empleado encontrado (Cedula: {cedula[i]})");
                    Console.WriteLine("Ingrese los nuevos datos:");

                    Console.WriteLine("Nuevo Nombre: ");
                    nombre[i] = Console.ReadLine();

                    Console.WriteLine("Nueva Dirección: ");
                    direccion[i] = Console.ReadLine();

                    Console.WriteLine("Nuevo Teléfono: ");
                    telefono[i] = Console.ReadLine();

                    Console.WriteLine("Nuevo Salario: ");
                    float.TryParse(Console.ReadLine(), out salario[i]);

                    Console.WriteLine("Empleado modificado exitosamente.");
                    break;
                }
            }

            Console.WriteLine("Empleado no encontrado.");
        }

        public static void BorrarEmpleado()
        {
            Console.WriteLine("Borrar Empleado");

            Console.Write("Ingrese la cédula del empleado a borrar: ");
            string cedulaABorrar = Console.ReadLine();

            for (int i = 0; i < cont; i++)
            {
                if (cedula[i] == cedulaABorrar)
                {
                    Console.WriteLine($"Empleado encontrado (Cedula: {cedula[i]})");
                    Console.WriteLine("¿Seguro que desea borrar este empleado? (S/N)");

                    char respuesta = char.Parse(Console.ReadLine().ToString().ToUpper());

                    if (respuesta == 'S')
                    {

                        for (int j = i; j < cont - 1; j++)
                        {
                            cedula[j] = cedula[j + 1];
                            nombre[j] = nombre[j + 1];
                            direccion[j] = direccion[j + 1];
                            telefono[j] = telefono[j + 1];
                            salario[j] = salario[j + 1];
                        }
                        cont--;
                        Console.WriteLine("Empleado borrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se ha borrado el empleado.");
                    }
                    break;
                }
            }

            Console.WriteLine("Empleado no encontrado.");
        }

        public static void AgregarEmpleado()
        {
            char respuesta = 'N';

            do
            {

                Console.Clear();
                if (indice < cant)
                {
                    Console.WriteLine($"Ingrese la Cedula ({cont}): ");
                    cedula[indice] = Console.ReadLine();
                    Console.WriteLine($"Ingrese el Nombre ({cont}): ");
                    nombre[indice] = Console.ReadLine();
                    Console.WriteLine($"Ingrese la Direccion ({cont}): ");
                    direccion[indice] = Console.ReadLine();
                    Console.WriteLine($"Ingrese el Telefono ({cont}): ");
                    telefono[indice] = Console.ReadLine();
                    Console.WriteLine($"Ingrese el Salario ({cont}): ");
                    float.TryParse(Console.ReadLine(), out salario[indice]);
                    indice++;
                    cont++;
                    Console.WriteLine("Desea agregar otro Empleado (S/N)");

                    respuesta = char.Parse(Console.ReadLine().ToString().ToUpper());//para usar min y may
                }
                else
                {
                    Console.WriteLine("Ya no puede ingresar Empleados");
                    break;
                }
            } while (respuesta != 'N');
        }
    }
}

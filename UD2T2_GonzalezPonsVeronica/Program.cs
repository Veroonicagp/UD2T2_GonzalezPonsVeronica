using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////////////////////////////////////
///Tarea:UD2T2
///Alumna: Verónica González Pons
///Curso: 2023/2024
////////////////////////////////////////////

namespace UD2T2_GonzalezPonsVeronica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Empleados empleados = new Empleados();
            int num = 1;
            while (num != 0)
            {
                Console.Clear();
                Console.WriteLine("-------MENU--------");
                Console.Write("0 - Salir\r\n" +
                                  "1 - Crear empleado\r\n" +
                                  "2 - Actualizar salario\r\n" +
                                  "3 – Mostrar nombre\r\n" +
                                  "4 - Mostrar Edad\r\n" +
                                  "5 - Mostrar empleado \r\n" +
                                  "6 - Mostrar empleados\r\n" +
                                  "7 – Borrar empleado\r\n" +
                                  "Introduzca su opcion:");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        num = 0;
                        Console.WriteLine("ADIOS!!");
                        break;
                    case 1:
                        num = 1;
                        Console.WriteLine(" ");
                        CrearEmpleado(empleados);
                        break;
                    case 2:
                        num = 2;
                        Console.WriteLine(" ");
                        ActualizarSalario();


                        break;
                    case 3:
                        num = 3;
                        Console.WriteLine(" ");
                        MostrarNombre();
                        break;
                    case 4:
                        num = 4;
                        Console.WriteLine(" ");
                        MostrarEdad();
                        break;
                    case 5:
                        num = 5;
                        Console.WriteLine(" ");
                        MostrarEmpleado();
                        break;
                    case 6:
                        num = 6;
                        Console.WriteLine(" ");
                        empleados.MostrarEmpleados();
                        break;
                    case 7:
                        num = 7;
                        Console.WriteLine(" ");
                        BorrarEmpleado();
                        break;

                    default:
                        Console.WriteLine("Introduce un número del 0 al 7");
                        Console.WriteLine(" ");
                        break;



                }
                Console.Write("Pulsa INTRO para continuar....");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                Console.WriteLine(" ");
            }

            void CrearEmpleado(Empleados empleado)
            {
                Console.WriteLine("Introduce el nombre del Empleado");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduce el apellido del empleado");
                string ape1 = Console.ReadLine();
                Console.WriteLine("Introduce el segundo apellido del empleado");
                string ape2 = Console.ReadLine();
                Console.WriteLine("Introduce la edad del empleado");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el nif");
                string nif = Console.ReadLine();
                Console.WriteLine("Introduce la salario del empleado");
                double salario = double.Parse(Console.ReadLine());
                empleado.NuevoEmpleado(nombre, ape1, ape2, edad, nif, salario);
            }

            void ActualizarSalario()
            {
                Console.Write("Introduce el nif: ");
                string nif = Console.ReadLine();
                Console.Write("Actualiza el salario: ");
                double salario = double.Parse(Console.ReadLine());
                empleados.ActualizarSalarioEmpleado(nif, salario);


            }

            void MostrarNombre()
            {
                Console.Write("Introduce el nif: ");
                string nif = Console.ReadLine();
                empleados.ObtenerNombre(nif);

            }

            void MostrarEdad()
            {
                Console.Write("Introduce el nif: ");
                string nif = Console.ReadLine();
                empleados.ObtenerEdad(nif);

            }

            void MostrarEmpleado()
            {
                Console.Write("Introduce el nif: ");
                string nif = Console.ReadLine();
                empleados.InfoEmpleado(nif);

            }

            void BorrarEmpleado()
            {
                Console.Write("Introduce el nif: ");
                string nif = Console.ReadLine();
                empleados.BorrarEmpleado(nif);

            }




        }
    }
}
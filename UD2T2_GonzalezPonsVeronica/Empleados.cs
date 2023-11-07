using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T2_GonzalezPonsVeronica
{
    public class Empleados
    {
        List<Empleado> empleados = new List<Empleado>();

        public void NuevoEmpleado(string nombre, string ape1, string ape2, int edad, string nif, double salario)
        {
            empleados.Add(new Empleado(nombre, ape1, ape2, edad, nif, salario));
        }
        public Empleado ObtenerEmpleado(string nif)
        {
            return empleados.FirstOrDefault(e => e.Nif.Equals(nif));
        }

        public void ActualizarSalarioEmpleado(string nif, double salario)
        {
            ObtenerEmpleado(nif).Salario = salario;

        }

        public void MostrarEmpleados()
        {
            foreach (Empleado empleado in empleados)
            {
                empleado.DatosEmpleado(empleado);
            }

        }

        public void ObtenerNombre(string nif)
        {
            Console.WriteLine(ObtenerEmpleado(nif).Nombre);
        }

        public void ObtenerEdad(string nif)
        {
            Console.WriteLine(ObtenerEmpleado(nif).Edad);
        }

        public void InfoEmpleado(string nif)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Nif.Equals(nif))
                {
                    empleado.DatosEmpleado(empleado);
                }
            }
        }

        public void BorrarEmpleado(string nif)
        {
            empleados.Remove(ObtenerEmpleado(nif));
        }



    }


}

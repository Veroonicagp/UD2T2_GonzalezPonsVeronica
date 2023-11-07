using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T2_GonzalezPonsVeronica
{
    public class Empleado
    {
        string nombre;
        string apellido;
        string apellido2;
        int edad;
        string nif;
        double salario;

        public Empleado(string nombre, string apellido, string apellido2, int edad, string nif, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.nif = nif;
            this.salario = salario;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void NombreCompleto(Empleado empleado)
        {
            Console.WriteLine("Nombre: " + empleado.Nombre + "\r\n"
                             + "Apellido: " + empleado.Apellido + "\r\n"
                             + "2º Apellido: " + empleado.Apellido2 );
        }

        public void DatosEmpleado(Empleado empleado)
        {
            NombreCompleto(empleado);
            Console.WriteLine("Edad: " + empleado.Edad + "\r\n"
                              + "Salario: " + empleado.Salario + "\r\n");
        }

        internal static void Remove(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }



}

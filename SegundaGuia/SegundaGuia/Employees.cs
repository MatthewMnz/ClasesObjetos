using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaGuia
{
    internal class Employees
    {
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo;

        public Employees(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }

        public void ShowDetails()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de Empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
        }

        public int ObtainEmployeeNumber()
        {
            return this.numeroEmpleado;
        }

        public void ChangeStatus(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true;
                Console.WriteLine("Empleado activado");
            }
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("Empleado desactivado");
            }
            else
            {
                Console.WriteLine("Estado no valido");
            }
        }
    }
}

namespace SegundaGuia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de gestion de empleados");

            List<Employees> listaEmpleados = new List<Employees>();

            listaEmpleados.Add(new Employees("Juan", 101, 30000));
            listaEmpleados.Add(new Employees("Maria", 102, 35000));
            listaEmpleados.Add(new Employees("Pedro", 103, 32000, false));

            foreach (var empleado in listaEmpleados)
            {
                empleado.ShowDetails();
            }

            int numeroEmpleadoCambiarEstado = 103;
            Employees empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.ChangeStatus(1);
                empleadoCambiarEstado.ShowDetails();
            }
            else
            {
                Console.WriteLine($"Empleado con numero {numeroEmpleadoCambiarEstado} no encontrado.");
            }

            static Employees BuscarEmpleado(List<Employees> empleados, int numeroEmpleado)
            {
                foreach (var empleado in empleados)
                {
                    if (empleado.ObtainEmployeeNumber() == numeroEmpleado)
                    {
                        return empleado;
                    }
                }
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class ClaseMenu
    {
        static int opcion = 0;
        public static void MenuPrincipal() 
        {
            do
            {
                Console.Clear();
                Console.WriteLine("***** MENU PRINCIPAL *****\n");
                Console.WriteLine("1 - Inicializar Arreglos");
                Console.WriteLine("2 - Agregar Empleado");
                Console.WriteLine("3 - Modificar Empleado");
                Console.WriteLine("4 - Borrar Empleado");
                Console.WriteLine("5 - Consultar Empleado");
                Console.WriteLine("6 - Reporte");
                Console.WriteLine("7 - Salir\n");
                Console.WriteLine("Elija una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: ClaseEmpleados.Inicializar();                      
                        break;
                    case 2: ClaseEmpleados.AgregarEmpleado();
                        break;
                    case 3: ClaseEmpleados.ModificarEmpleado();                    
                        break;
                    case 4: ClaseEmpleados.BorrarEmpleado();
                        break;
                    case 5: ClaseEmpleados.ConsultarEmpleado();
                        break;
                    case 6: SubMenu();                     
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            } while (opcion != 7);

        }

        public static void SubMenu() 
        {
            do
            {
                Console.Clear();
                Console.WriteLine("***** SUBMENU *****\n");
                Console.WriteLine("1 - Consultar Empleados");
                Console.WriteLine("2 - Listar todos los empleados");
                Console.WriteLine("3 - Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4 - Calcular y mostrar el salario mas alto y el mas bajo de todos los empleados");
                Console.WriteLine("5 - Volver al menu principal\n");
                Console.WriteLine("Elija una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: ClaseEmpleados.ConsultarEmpleadosID();
                        break;
                    case 2: ClaseEmpleados.ListarEmpleados();
                        break;
                    case 3: ClaseEmpleados.PromedioSalarios();
                        break;
                    case 4: ClaseEmpleados.Mayor_MenorSalarios();
                        break;
                    case 5: MenuPrincipal();
                        break;
                    default:
                        break;
                }

            } while (opcion!=5 && opcion!=7);
        }

    }
}

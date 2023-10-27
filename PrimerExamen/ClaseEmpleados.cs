using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace PrimerExamen
{
    internal class ClaseEmpleados
    {
        static char respuesta = ' ';
        static Boolean Emp_Existe = false;
        static int buscar_id = 0;
        static int posicion = 1;
        static byte indice = 0;
        static int cant = 4;
        static int [] cedula = new int[cant];
        static string [] nombre = new string [cant];
        static string [] direccion = new string [cant];
        static int [] telefono = new int [cant];
        static float [] salario = new float [cant];

        
        //***********************MENUPRINCIPAL*********************************
        
        public static void Inicializar() 
        {
            cedula = Enumerable.Repeat(0, cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            direccion = Enumerable.Repeat("", cant).ToArray();
            telefono = Enumerable.Repeat(0, cant).ToArray();
            salario = Enumerable.Repeat(0f, cant).ToArray();
            posicion = 1;
            indice = 0;
            Console.Clear();
            Console.WriteLine("***** ARREGLOS INICIALIZADOS *****");
            Console.ReadLine();
        }
        public static void AgregarEmpleado()
        
        {
            
            do
            {
            Console.WriteLine($"Digite el numero de cedula {posicion}: ");
            cedula[indice] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite el nombre {posicion}: ");
            nombre[indice] = Console.ReadLine();
            Console.WriteLine($"Digite la direccion {posicion}: ");
            direccion[indice] = Console.ReadLine();
            Console.WriteLine($"Digite el telefono {posicion}: ");
            telefono[indice] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite el salario {posicion}: ");
            salario[indice] = float.Parse(Console.ReadLine());
            indice++;
            posicion++;
            Console.WriteLine("Desea agregar otro empleado? S/N");
            respuesta = char.Parse(Console.ReadLine().ToUpper());
            } while (respuesta!= 'N');
        }
        public static void ModificarEmpleado() 

        {
                 
            Console.WriteLine("Ingrese el numero de cedula del empleado a modificar: ");
            buscar_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                if (buscar_id == cedula[i])
                {
                    Console.WriteLine($"Empleado:\n Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    Emp_Existe=true;
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Digite el numero de cedula: ");
                    cedula[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Digite el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine($"Digite la direccion: ");
                    direccion[i] = Console.ReadLine();
                    Console.WriteLine($"Digite el telefono: ");
                    telefono[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Digite el salario: ");
                    salario[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("***** DATOS ACTUALIZADOS *****");
                    Console.ReadLine();
                    break;                 
                }
                
            }
            if (Emp_Existe == false) 
            {
                Console.WriteLine("***** EMPLEADO NO EXISTE *****");
                Console.ReadLine();
            }
        }
        public static void BorrarEmpleado() 
        {
            Console.WriteLine("Ingrese el numero de cedula del empleado a borrar: ");
            buscar_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < posicion; i++)
            {
                if (buscar_id == cedula[i])
                {
                    Console.WriteLine($"Empleado:\n Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    Emp_Existe = true;
                    Console.ReadLine();
                    Console.Clear();

                    cedula[i] = 0;
                    nombre[i] = "";
                    direccion[i] = "";
                    telefono[i] = 0;
                    salario[i] = 0;
                    Console.WriteLine("***** DATOS ACTUALIZADOS *****");
                    Console.ReadLine();
                    break;
                }

            }
            if (Emp_Existe == false)
            {
                Console.WriteLine("***** EMPLEADO NO EXISTE *****");
                Console.ReadLine();
            }
        }
        public static void ConsultarEmpleado() 
        {
            Console.WriteLine("***** LISTA DE EMPLEADOS *****\n");
            for (int i = 0;i < posicion-1;i++) 
            {
                Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}\n");
            }
            Console.ReadLine();
        }

        //***************************SUBMENU************************************

        public static void ConsultarEmpleadosID() 
        {
            Console.WriteLine("Ingrese el numero de cedula del empleado a consultar: ");
            buscar_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                if (buscar_id == cedula[i])
                {
                    Console.WriteLine($"Empleado:\n Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}");
                    Emp_Existe = true;
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            if (Emp_Existe == false)
            {
                Console.WriteLine("***** EMPLEADO NO EXISTE *****");
                Console.ReadLine();
            }
        }
        public static void ListarEmpleados() 
        {
            Console.WriteLine("***** LISTA DE EMPLEADOS POR ORDEN ALFABETICO *****\n Nombre: ");
            for (int i = 0; i < cant; i++)
            {
                Array.Sort(nombre);
                Console.WriteLine($"{nombre[i]}");
            }
            Console.ReadLine();
        }
        public static void PromedioSalarios() 
        {
            double promedio = 0;
            Console.WriteLine("***** PROMEDIO DE SALARIOS *****\n Lista de salarios: ");
            for (int i = 0; i < posicion-1; i++)
            {
                Console.WriteLine($"${salario[i]} \n");
                promedio = salario.Average();
                             
            }
            Console.WriteLine($"El promedio de los salarios es: ${promedio}");
            Console.ReadLine();
        }
        public static void Mayor_MenorSalarios() 
        {
            
            Console.WriteLine("***** SALARIO MAYOR Y MENOR *****\n");
            
                    double mayor = salario.Max();
                    double menor = salario.Where(x => x != 0).Min();
                    Console.WriteLine($"Salario Mayor: {mayor}\n");
                    Console.WriteLine($"Salario Menor: {menor}");
                    Console.ReadLine();                                     
          
        }
    }
}

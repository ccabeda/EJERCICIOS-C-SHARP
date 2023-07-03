//Los empleados de una cierta compañía se representan en la base de datos de la compañía por su nombre,número de empleado y DNI. Implemente todos los objentos necesarios que permita 
//tener una tablas de hash con estrategia de resolución de colisiones de dispersión abierta que permita guardar y acceder a los registros de los empleado por DNI.

using System;

namespace complejidad_semana_3
{
	class Program
	{
		 static void Main(string[] args)
        {
            // Crear una nueva tabla hash con tamaño 10
            TablaHash tabla = new TablaHash(10);

            // Crear algunos empleados
            Empleado empleado1 = new Empleado("Juan", 1001, 12345678);
            Empleado empleado2 = new Empleado("María", 1002, 23456789);
            Empleado empleado3 = new Empleado("Pedro", 1003, 34567890);

            // Agregar los empleados a la tabla hash
            tabla.Insertar(empleado1);
            tabla.Insertar(empleado2);
            tabla.Insertar(empleado3);
            Console.WriteLine("Ingrese el DNI del empleado que desea buscar: ");
            string buscar = Console.ReadLine();
        	Empleado encontrado = tabla.Buscar(buscar);
        	if (encontrado != null)
            {
                Console.WriteLine("Empleado encontrado: " + encontrado.nombre);
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }

            Console.ReadLine();
    }
            
            
		}
	}

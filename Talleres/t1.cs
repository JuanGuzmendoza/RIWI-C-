using System;

namespace CTalleres.Talleres
{
    /// <summary>
    /// Clase que contiene ejercicios básicos de C# para práctica de conceptos fundamentales.
    /// </summary>
    public class T1
    {
        /// <summary>
        /// Ejercicio 1:
        /// Imprime "¡Hola, mundo!" en la consola.
        /// </summary>
        public static void Ej1()
        {
            Console.WriteLine("Hola mundo");
        }

        /// <summary>
        /// Ejercicio 2:
        /// Declara un entero y un string, les asigna valores e imprime un saludo en consola.
        /// </summary>
        public static void Ej2()
        {
            int edad = 18;
            string nombre = "Juan David Guzman";
            Console.WriteLine("¡HOLA " + nombre + " DE " + edad + "!");
        }

        /// <summary>
        /// Ejercicio 3:
        /// Convierte un string a minúsculas y mayúsculas y muestra ambos resultados.
        /// </summary>
        public static void Ej3()
        {
            string nombre = "Juan David Guzman";
            Console.WriteLine("Nombre en minúsculas: " + nombre.ToLower());
            Console.WriteLine("Nombre en mayúsculas: " + nombre.ToUpper());
        }

        /// <summary>
        /// Ejercicio 4:
        /// Declara dos enteros y realiza operaciones de suma, resta, multiplicación y división. 
        /// Muestra los resultados en formato de reporte.
        /// </summary>
        public static void Ej4()
        {

            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine($@"
            == RESULTADO ==
            SUMA  : {n1 + n2} 
            ----------------
            RESTA : {n1 - n2}
            ----------------
            MULTI : {n1 * n2}
            ----------------
            DIVI  : {n1 / n2}
            ----------------
            ");
        }

        /// <summary>
        /// Ejercicio 5:
        /// Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que,
        /// y muestra los resultados.
        /// </summary>
        public static void Ej5()
        {
            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("== SELECCIONA UNA OPCIÓN ==");
            Console.WriteLine("1 - Igualdad (==)");
            Console.WriteLine("2 - Desigualdad (!=)");
            Console.WriteLine("3 - Mayor que (>)");
            Console.WriteLine("4 - Menor que (<)");
            Console.Write("Ingrese opción (1-4): ");
            string opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"¿{n1} == {n2}? " + (n1 == n2 ? "Sí" : "No"));
                    break;
                case "2":
                    Console.WriteLine($"¿{n1} != {n2}? " + (n1 != n2 ? "Sí" : "No"));
                    break;
                case "3":
                    Console.WriteLine($"¿{n1} > {n2}? " + (n1 > n2 ? "Sí" : "No"));
                    break;
                case "4":
                    Console.WriteLine($"¿{n1} < {n2}? " + (n1 < n2 ? "Sí" : "No"));
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione un número entre 1 y 4.");
                    break;
            }
        }

        /// <summary>
        /// Ejercicio 6:
        /// Solicita una cadena de texto, una subcadena a buscar, y una nueva subcadena para reemplazarla.
        /// Muestra la cadena resultante después del reemplazo.
        /// </summary>
        public static void Ej6()
        {
            Console.Clear(); // Limpia la consola al inicio (opcional)

            Console.WriteLine("===== EJERCICIO 6: REEMPLAZO DE TEXTO =====\n");

            Console.Write("Ingrese una cadena de texto:\n> ");
            string cadena = Console.ReadLine()!;

            Console.Write("\nIngrese la palabra o carácter que desea buscar:\n> ");
            string buscar = Console.ReadLine()!;

            Console.Write("\nIngrese la palabra o carácter que desea usar como reemplazo:\n> ");
            string reemplazo = Console.ReadLine()!;

            string nuevaCadena = cadena.Replace(buscar, reemplazo);

            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"Cadena original : {cadena}");
            Console.WriteLine($"Texto reemplazado: '{buscar}' por '{reemplazo}'");
            Console.WriteLine($"Nueva cadena    : {nuevaCadena}");

            Console.WriteLine("\n=====================\n");
        }


        
    }
}

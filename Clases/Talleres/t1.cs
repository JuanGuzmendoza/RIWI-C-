using System;
using Helpers.validaciones;

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
        /// Incluye validación para asegurarse de que el usuario solo ingrese números.
        /// </summary>
        public static void Ej4()
        {
            int n1 = Validaciones.validateNumber("Porfavor ingrese el primer numero: ");
            int n2 = Validaciones.validateNumber("Porfavor ingrese el segundo numero: ");


            // Reporte de operaciones
            Console.WriteLine($@"
            == RESULTADO ==
            SUMA  : {n1 + n2} 
            ----------------
            RESTA : {n1 - n2}
            ----------------
            MULTI : {n1 * n2}
            ----------------
            DIVI  : {(n2 != 0 ? (n1 / n2).ToString() : "No se puede dividir por cero")}
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
            int n1 = Validaciones.validateNumber("Ingrese el primer numero: ");
            int n2 = Validaciones.validateNumber("Ingrese el primer numero: ");


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

            Console.WriteLine("===== EJERCICIO 6: REEMPLAZO DE TEXTO =====\n");


            string cadena = Validaciones.validarContenido("Ingrese una cadena de texto:\n> ");
            string buscar = Validaciones.validarContenido("\nIngrese la palabra o carácter que desea buscar:\n> ");
            string reemplazo = Validaciones.validarContenido("\nIngrese la palabra o carácter que desea usar como reemplazo:\n> ");

            string nuevaCadena = cadena.Replace(buscar, reemplazo);

            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"Cadena original : {cadena}");
            Console.WriteLine($"Texto reemplazado: '{buscar}' por '{reemplazo}'");
            Console.WriteLine($"Nueva cadena    : {nuevaCadena}");

            Console.WriteLine("\n=====================\n");
        }
        
        /// <summary>
        /// Ejercicio 7:
        /// Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.
        /// </summary>
        public static void Ej7()
        {
            string nombre = Validaciones.validarContenido("Ingrese su nombre:\n> ");
            int edad= Validaciones.validateNumber("Ingrese su edad:\n>");

            Console.WriteLine($"¡Hola {nombre}, tienes {edad} años!");
        }

        /// <summary>
        /// Ejercicio 8:
        /// Declara un int y escribe un programa que indique si es mayor, menor o igual a 10.
        /// </summary>
        public static void Ej8()
        {

            int numero = Validaciones.validateNumber("Ingresde el numero a validar:\n> ");

            if (numero == 10)
            {
                Console.WriteLine("El numero es igual a 10");
            }
            else if (numero > 10)
            {
                Console.WriteLine("El numero es mayor a 10");
            }
            else
            {
                Console.WriteLine("El numero es menor a 10");
            }
        }

        /// <summary>
        /// Ejercicio 9:
        /// Declara dos variables double, realiza suma, resta, multiplicación y división,
        /// y muestra los resultados.
        /// </summary>
        public static void Ej9()
        {
            double n1 = Validaciones.validateDouble("Porfavor ingrese el primer numero: ");
            double n2 = Validaciones.validateDouble("Porfavor ingrese el segundo numero: ");


            // Reporte de operaciones
            Console.WriteLine($@"
            == RESULTADO ==
            SUMA  : {(n1 * n2).ToString("F2")} 
            ----------------
            RESTA : {(n1 - n2).ToString("F2")}
            ----------------
            MULTI : {(n1 * n2).ToString("F2")}
            ----------------
            DIVI  : {(n2 != 0 ? (n1 / n2).ToString("F2") : "No se puede dividir por cero")}
            ----------------
            ");
        }

        /// <summary>
        /// Ejercicio 10:
        /// Declara dos variables string, concatenarlas y mostrar el resultado.
        /// </summary>
        public static void Ej10()
        {

            string str1 = Validaciones.validarContenido("Ingrese el primer texto:\n> ");
            string str2 = Validaciones.validarContenido("Ingrese el segundo texto:\n> ");
            Console.WriteLine($"Texto concatenado: {str1} {str2}");
        }

        /// <summary>
        /// Ejercicio 11:
        /// Declara una variable int, conviértela a double y muestra ambos valores.
        /// </summary>
        public static void Ej11()
        {
            int numeroEntero = Validaciones.validateNumber("Ingrese un número entero:\n> ");
            double numeroDouble = Convert.ToDouble(numeroEntero);
            Console.WriteLine($"Número entero: {numeroEntero}");
            Console.WriteLine($"Número convertido a double: {numeroDouble}");
        }

        /// <summary>
        /// Ejercicio 12:
        /// Escribe un programa que pida al usuario un número y muestre si es positivo,
        /// negativo o cero.
        /// </summary>
        public static void Ej12()
        {
            int numero = Validaciones.validateNumber("Ingresde el numero a validar:\n> ");

            if (numero == 0)
            {
                Console.WriteLine("El numero es cero");
            }
            else if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
        }

        /// <summary>
        /// Ejercicio 13:
        /// Usa un bucle for para imprimir los números del 1 al 10.
        /// </summary>
        public static void Ej13()
        {
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);   
        }
        }

        /// <summary>
        /// Ejercicio 14:
        /// Elimina los espacios en blanco al inicio y al final de un string,
        /// y formatea el string para que empiece con mayúscula y el resto en minúsculas.
        /// </summary>
        public static void Ej14()
        {
            string texto = Validaciones.validarContenido("Ingrese un texto con espacios al inicio y al final:\n> ");
            texto = texto.Trim();
            texto = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
            Console.WriteLine($"Texto formateado: '{texto}'");
        }

        /// <summary>
        /// Ejercicio 15:
        /// Escribe un programa que pida al usuario un número y muestre su tabla
        /// de multiplicar del 1 al 10.
        /// </summary>
        public static void Ej15()
        {
            int numero = Validaciones.validateNumber("Ingrese un número para ver su tabla de multiplicar:\n> ");
            for (int i = 1;  i < 11;  i++)
            {
                Console.WriteLine(@$"{numero} x {i} = {numero * i}");
            }

        }



        /// <summary>
        /// Ejercicio 16:
        /// Concatena dos strings y muestra la longitud de cada uno.
        /// </summary>
        public static void Ej16()
        {
            string str1 = Validaciones.validarContenido("Ingrese el primer texto:\n> ");
            string str2 = Validaciones.validarContenido("Ingrese el segundo texto:\n> ");
            Console.WriteLine($"Cadena unida> {str1 + str2}");
            Console.WriteLine($"Longitud de la cadena 1: {str1.Length}");
            Console.WriteLine($"Longitud de la cadena 2: {str2.Length}");
        }
        /// <summary>
        /// Ejercicio 17:
        /// Extrae una subcadena de un string y muestra la subcadena y su longitud.
        /// </summary>
        public static void Ej17()
        {

            Console.WriteLine("===== EJERCICIO 6: REEMPLAZO DE TEXTO =====\n");


            string cadena = Validaciones.validarContenido("Ingrese una cadena de texto:\n> ");
            string buscar = Validaciones.validarContenido("\nIngrese la palabra o carácter que desea buscar:\n> ");
            int index = cadena.IndexOf(buscar);
            if (index == -1)
            {
                Console.WriteLine($"La subcadena '{buscar}' no se encontró en la cadena.");
                return;
            }
            string subcadena = cadena.Substring(index, buscar.Length);
            Console.WriteLine($"Subcadena extraída: '{subcadena}'");
            Console.WriteLine($"Longitud de la subcadena: {subcadena.Length}");
            Console.WriteLine("\n=====================\n");
            
        }


    }
}
